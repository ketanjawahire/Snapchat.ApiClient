using System;
using System.Net;
using System.Runtime.Serialization;

namespace Snapchat.ApiClient.Exceptions
{
#pragma warning disable CA1032 // Implement standard exception constructors
    [Serializable]
    public class ApiException : Exception
#pragma warning restore CA1032 // Implement standard exception constructors
    {
        //TODO : check accessibility again
        private HttpStatusCode _statusCode;
        private ApiError _apiError;
        private ErrorResponse _errorResponse;

        //TODO : generate & pass correct message to base
        public ApiException(ApiError apiError, HttpStatusCode statusCode) : base()
        {
            _statusCode = statusCode;
            _apiError = apiError;
        }

        public ApiException(ErrorResponse errorResponse, HttpStatusCode statusCode) : base()
        {
            _statusCode = statusCode;
            _errorResponse = errorResponse;
        }

        protected ApiException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
