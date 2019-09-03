using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using Snapchat.ApiClient.Exceptions;
using Snapchat.ApiClient.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using UnauthorizedAccessException = Snapchat.ApiClient.Exceptions.UnauthorizedAccessException;

namespace Snapchat.ApiClient.Services
{
    internal abstract class BaseService : IApiService
    {
        private const string _apiRequestBaseUrl = "https://adsapi.snapchat.com/";
        private const string _apiVersion = "v1";

        private AuthenticationService _authService;
        private RestClient _restClient;

        internal BaseService(AuthenticationService authenticationService)
        {
            _authService = authenticationService;
            _restClient = new RestClient($"{_apiRequestBaseUrl}{{version}}/");
            _restClient.AddDefaultUrlSegment("version", _apiVersion);
        }

        private void _authorize()
        {
            var authResponse = _authService.Get();

            _restClient.Authenticator = new JwtAuthenticator(authResponse.AccessToken);
        }

        public T Execute<T>(IRestRequest restRequest) where T : class, new()
        {
            _authorize();

            var response = _restClient.Execute(restRequest);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = Deserialize<T>(response.Content);
                return result;
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
                throw new UnauthorizedAccessException();

            //TODO : move deserialize into seperate method
            var apiError = Deserialize<ApiError>(response.Content);

            throw new ApiException(apiError, response.StatusCode);
        }

        private static JsonSerializer GetJsonSerializer()
        {
            var jsonSerializer = new JsonSerializer
            {
                CheckAdditionalContent = true,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ConstructorHandling = ConstructorHandling.Default,
                ObjectCreationHandling = ObjectCreationHandling.Auto
            };

            return jsonSerializer;
        }

        private T Deserialize<T>(string content) where T : class, new()
        {
            var jsonSerializer = GetJsonSerializer();

            using (var reader = new JTokenReader(JToken.Parse(content)))
            {
                var result = jsonSerializer.Deserialize<T>(reader);

                return result;
            }
        }

#pragma warning disable CA1054 // Uri parameters should not be strings
#pragma warning disable CA1055 // Uri return values should not be strings
        protected static string GetRestReqestUrlFromPagingUrl(string pagingUrl)
#pragma warning restore CA1055 // Uri return values should not be strings
#pragma warning restore CA1054 // Uri parameters should not be strings
        {
            return string.IsNullOrEmpty(pagingUrl) ? pagingUrl : pagingUrl.Replace($"{_apiRequestBaseUrl}{_apiVersion}", string.Empty);
        }

        //TODO : Refine generic method
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
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                throw new ArgumentNullException(nameof(pagingOption), Constants.INVALID_PAGEOPTIONS);

            List<TEntity> entities = null;
            var counter = 0;

            do
            {
                var request = new RestRequest(url, Method.GET);

                var response = Execute<TRoot>(request);
                var tmpEntities = Extract<TRoot, TWrapper, TEntity>(response);

                if (!tmpEntities.Any())
                    break;

                if (entities == null)
                    entities = new List<TEntity>();

                entities.AddRange(tmpEntities);

                if (string.IsNullOrEmpty(response.Paging.NextLink))
                    break;

                url = GetRestReqestUrlFromPagingUrl(response.Paging.NextLink);

                counter++;
            } while (counter < pagingOption.NumberOfPages);

            return entities;
        }

#pragma warning disable CA1822 // Mark members as static
        protected IEnumerable<TEntity> Extract<TRoot, TWrapper, TEntity>(TRoot response)
#pragma warning restore CA1822 // Mark members as static
            where TRoot : class, IRootObject<TWrapper, TEntity>, new()
            where TWrapper : class, IWrapper<TEntity>, new()
            where TEntity : class, IEntity, new()
        {
            if (response is null)
                throw new ArgumentNullException(nameof(response));

            return response.WrapperCollection.Select(e => e.Entity);
        }
    }
}
