using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Snapchat.ApiClient
{
    public abstract class BaseService: IApiService
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

            if(response.StatusCode == HttpStatusCode.OK)
            {
                var result = Deserialize<T>(response.Content);
                return result;
            }
            else if(response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException();
            }

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

        //TODO : Try to make Extract method generic
        //public IEnumerable<T> Extract<T>(RootObject<IWrapper<T>, T> rootObject) where T : IEntity
        //{
        //    return rootObject.WrapperCollection.Select(e => e.Entity);
        //}

        //TODO : Refine generic method
        private IEnumerable<TEntity> PagedRequest<TEntity, TRoot>(string url, PagingOption pagingOption) where TRoot : RootObject<IWrapper<TEntity>, TEntity>, new() where TEntity : IEntity
        {
            if (pagingOption is null)
            {
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                throw new ArgumentNullException(nameof(pagingOption), Constants.INVALID_PAGEOPTIONS);
#pragma warning restore CA1303 // Do not pass literals as localized parameters
            }

            List<TEntity> campaigns = null;
            //var url = "/adaccounts/{adaccount_id}/campaigns";
            var counter = 0;
            do
            {
                var request = new RestRequest(url, Method.GET);
                //request.AddUrlSegment("adaccount_id", adAccountId);
                //request.AddQueryParameter("limit", pagingOption.Limit.ToString(CultureInfo.InvariantCulture));

                var response = Execute<TRoot>(request);
                var tmpCampaigns = Extract<TRoot, TEntity>(response);

                if (!tmpCampaigns.Any())
                    break;

                if (campaigns == null)
                    campaigns = new List<TEntity>();

                campaigns.AddRange(tmpCampaigns);

                if (string.IsNullOrEmpty(response.Paging.NextLink))
                    break;

                url = GetRestReqestUrlFromPagingUrl(response.Paging.NextLink);
                counter++;
            } while (counter < pagingOption.NumberOfPages);

            return campaigns;
        }

        //TODO : Refine generic method
        private IEnumerable<TEntity> Extract<TRoot, TEntity>(TRoot response)
            where TRoot : class, IRootObject<IWrapper<TEntity>, TEntity>, new()
            where TEntity : IEntity
        {
            return response.WrapperCollection.Select(e => e.Entity);
        }
    }
}
