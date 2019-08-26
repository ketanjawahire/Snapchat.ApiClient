using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;

namespace Snapchat.ApiClient
{
    public class AuthenticationService
    {
        private string _clientId;
        private string _clientSecret;
        private string _refreshToken;
        private IRestClient _restClient;

        public AuthenticationService(string clientId, string clientSecret, string refreshToken)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _refreshToken = refreshToken;

            _restClient = new RestClient("https://accounts.snapchat.com/");
        }

        public AuthResponse Get()
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

            //TODO : move deserialize into seperate method
            var apiError = Deserialize<ErrorResponse>(response.Content);

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
    }
}
