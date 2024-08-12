using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using Snapchat.ApiClient.Exceptions;
using Snapchat.ApiClient.Services.Interfaces;
using UnauthorizedAccessException = Snapchat.ApiClient.Exceptions.UnauthorizedAccessException;

namespace Snapchat.ApiClient.Services
{
    /// <summary>
    /// Base class for any Snapchat API service.
    /// </summary>
    internal abstract class BaseService : IApiService
    {
        private const string _apiRequestBaseUrl = "https://adsapi.snapchat.com/";
        private const string _apiVersion = "v1";

        private AuthenticationService _authService;
        private RestClient _restClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseService"/> class.
        /// </summary>
        /// <param name="authenticationService">Instance of <see cref="AuthenticationService"/>.</param>
        internal BaseService(AuthenticationService authenticationService)
        {
            _authService = authenticationService;
            _restClient = new RestClient($"{_apiRequestBaseUrl}{{version}}/");
            _restClient.AddDefaultUrlSegment("version", _apiVersion);
        }

        /// <summary>
        /// Executes API request and converts it into type TEntity.
        /// </summary>
        /// <typeparam name="TEntity">Desired response type.</typeparam>
        /// <param name="restRequest">Object of type <see cref="IRestRequest"/>.</param>
        /// <returns><typeparamref name="TEntity"/>TEntity.</returns>
        public TEntity Execute<TEntity>(IRestRequest restRequest)
            where TEntity : class, new()
        {
            Authorize();

            var response = _restClient.Execute(restRequest);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = Deserialize<TEntity>(response.Content);
                return result;
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException();
            }
            else if ((int)response.StatusCode == 429)
            {
                throw new RateLimitExceededException(response.Content.ToString(CultureInfo.InvariantCulture));
            }

            // TODO : move deserialize into seperate method
            var apiError = Deserialize<ApiError>(response.Content);

            throw new ApiException(apiError, response.StatusCode);
        }

        /// <summary>
        /// Gets absolute url from given url.
        /// </summary>
        /// <param name="pagingUrl">Input url.</param>
        /// <returns>Absolute url.</returns>
#pragma warning disable CA1054 // Uri parameters should not be strings
#pragma warning disable CA1055 // Uri return values should not be strings
        protected static string GetRestReqestUrlFromPagingUrl(string pagingUrl)
#pragma warning restore CA1055 // Uri return values should not be strings
#pragma warning restore CA1054 // Uri parameters should not be strings
        {
            return string.IsNullOrEmpty(pagingUrl) ? pagingUrl : pagingUrl.Replace($"{_apiRequestBaseUrl}{_apiVersion}", string.Empty);
        }

        /// <summary>
        /// Executed paged API request.
        /// </summary>
        /// <typeparam name="TRoot">Object of type <see cref="IRootObject{TWrapper, TEntity}"/>>.</typeparam>
        /// <typeparam name="TWrapper">Object of type <see cref="IWrapper{TEntity}"/>.</typeparam>
        /// <typeparam name="TEntity">Object of type <see cref="IEntity"/>.</typeparam>
        /// <param name="url">API request url.</param>
        /// <param name="pagingOption">API Paging options.</param>
        /// <returns>List of <see cref="IEntity"/>.</returns>
#pragma warning disable CA1054 // Uri parameters should not be strings
#pragma warning disable CA1822 // Mark members as static
        protected IEnumerable<TEntity> ExecutePagedRequest<TRoot, TWrapper, TEntity>(string url, PagingOption pagingOption)
            where TRoot : class, IRootObject<TWrapper, TEntity>, new()
            where TWrapper : class, IWrapper<TEntity>, new()
            where TEntity : class, IEntity, new()
#pragma warning restore CA1822 // Mark members as static
#pragma warning restore CA1054 // Uri parameters should not be strings
        {
            if (pagingOption is null)
            {
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                throw new ArgumentNullException(nameof(pagingOption), Constants.INVALID_PAGEOPTIONS);
            }

            List<TEntity> entities = null;
            var counter = 0;

            do
            {
                var request = new RestRequest(url, Method.GET);

                var response = Execute<TRoot>(request);
                var tmpEntities = Extract<TRoot, TWrapper, TEntity>(response);

                if (!tmpEntities.Any())
                {
                    break;
                }

                if (entities == null)
                {
                    entities = new List<TEntity>();
                }

                entities.AddRange(tmpEntities);

                if (string.IsNullOrEmpty(response.Paging.NextLink))
                {
                    break;
                }

                url = GetRestReqestUrlFromPagingUrl(response.Paging.NextLink);

                counter++;
            }
            while (counter < pagingOption.NumberOfPages);

            return entities;
        }

        /// <summary>
        /// Extracts <see cref="IEntity"/> from <see cref="IRootObject{TWrapper, TEntity}"/>.
        /// </summary>
        /// <typeparam name="TRoot">Object of type <see cref="IRootObject{TWrapper, TEntity}"/>.</typeparam>
        /// <typeparam name="TWrapper">Object of type <see cref="IWrapper{TEntity}"/>.</typeparam>
        /// <typeparam name="TEntity">Object of type <see cref="IEntity"/>.</typeparam>
        /// <param name="response">Input object of type <see cref="IRootObject{TWrapper, TEntity}"/>.</param>
        /// <returns>List of entities of type <see cref="IEntity"/>.</returns>
#pragma warning disable CA1822 // Mark members as static
        protected IEnumerable<TEntity> Extract<TRoot, TWrapper, TEntity>(TRoot response)
#pragma warning restore CA1822 // Mark members as static
            where TRoot : class, IRootObject<TWrapper, TEntity>, new()
            where TWrapper : class, IWrapper<TEntity>, new()
            where TEntity : class, IEntity, new()
        {
            if (response is null)
            {
                throw new ArgumentNullException(nameof(response));
            }

            return response.WrapperCollection.Select(e => e.Entity);
        }

        private static JsonSerializer GetJsonSerializer()
        {
            var jsonSerializer = new JsonSerializer
            {
                CheckAdditionalContent = true,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ConstructorHandling = ConstructorHandling.Default,
                ObjectCreationHandling = ObjectCreationHandling.Auto,
            };

            return jsonSerializer;
        }

        private void Authorize()
        {
            var authResponse = _authService.Get();

            _restClient.Authenticator = new JwtAuthenticator(authResponse.AccessToken);
        }

        private T Deserialize<T>(string content)
            where T : class, new()
        {
            var jsonSerializer = GetJsonSerializer();

            using (var reader = new JTokenReader(JToken.Parse(content)))
            {
                var result = jsonSerializer.Deserialize<T>(reader);

                return result;
            }
        }
    }
}
