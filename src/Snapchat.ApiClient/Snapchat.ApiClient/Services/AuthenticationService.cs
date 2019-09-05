using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Snapchat.ApiClient.Entities.Api;
using Snapchat.ApiClient.Exceptions;
using Snapchat.ApiClient.Helpers;

namespace Snapchat.ApiClient.Services
{
    /// <summary>
    /// Provides methods to do authorization operations on Snapchat API.
    /// </summary>
    internal class AuthenticationService
    {
        private static AccessTokenCacheProvider _accessTokenCacheProvider;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _refreshToken;
        private readonly IRestClient _restClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationService"/> class.
        /// </summary>
        /// <param name="clientId">Client Id.</param>
        /// <param name="clientSecret">Client secret.</param>
        /// <param name="refreshToken">Refresh token.</param>
        internal AuthenticationService(string clientId, string clientSecret, string refreshToken)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _refreshToken = refreshToken;

            _restClient = new RestClient("https://accounts.snapchat.com/");

            if (_accessTokenCacheProvider is null)
            {
                _accessTokenCacheProvider = new AccessTokenCacheProvider();
            }
        }

        /// <summary>
        /// It does authorization on Snapchat API.
        /// </summary>
        /// <returns>Authorization response.</returns>
        public AuthResponse Get()
        {
            if (GetAccessTokenFromCache(out AuthResponse cachedResponse))
            {
                return cachedResponse;
            }

            var response = GetAccessTokenFromApi();

            AddTokenToCache(response);

            return response;
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

        private static string Serialize(object input)
        {
            var jsonSerializer = GetJsonSerializer();
            var result = new StringBuilder();

            using (var writer = new JsonTextWriter(new StringWriter(result)) { Formatting = Formatting.None })
            {
                jsonSerializer.Serialize(writer, input);
            }

            return result.ToString();
        }

        private AuthResponse GetAccessTokenFromApi()
        {
            var request = new RestRequest("/login/oauth2/access_token", Method.POST);

            request.AddParameter("refresh_token", _refreshToken);
            request.AddParameter("client_id", _clientId);
            request.AddParameter("client_secret", _clientSecret);
            request.AddParameter("grant_type", "refresh_token");

            var response = _restClient.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = Deserialize<AuthResponse>(response.Content);
                return result;
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException();
            }

            // TODO : move deserialize into seperate method
            var apiError = Deserialize<ErrorResponse>(response.Content);

            throw new ApiException(apiError, response.StatusCode);
        }

        private bool GetAccessTokenFromCache(out AuthResponse authResponse)
        {
            authResponse = new AuthResponse();

            if (_accessTokenCacheProvider.Contains(_refreshToken))
            {
                var cachedValue = _accessTokenCacheProvider.Get(_refreshToken);

                if (!string.IsNullOrEmpty(cachedValue))
                {
                    authResponse = Deserialize<AuthResponse>(cachedValue);

                    return true;
                }
            }

            return false;
        }

        private void AddTokenToCache(AuthResponse authResponse)
        {
            _accessTokenCacheProvider.Add(_refreshToken, Serialize(authResponse));
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
