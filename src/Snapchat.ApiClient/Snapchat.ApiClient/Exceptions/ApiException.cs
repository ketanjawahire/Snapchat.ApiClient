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
        public HttpStatusCode httpStatusCode { get { return _statusCode; } }
        public ApiError ApiError { get { return _apiError; } }

        private readonly HttpStatusCode _statusCode;
        private readonly ApiError _apiError;
        private readonly ErrorResponse _errorResponse;

        public ApiException(ApiError apiError, HttpStatusCode statusCode) : base(apiError != null ? $"{apiError.DisplayMessage}. Check ApiError for more details." : string.Empty)
        {
            _statusCode = statusCode;
            _apiError = apiError;
        }

        public ApiException(ErrorResponse errorResponse, HttpStatusCode statusCode) : base (errorResponse != null ? errorResponse.ErrorDescription  : string.Empty)
        {
            _statusCode = statusCode;
            _errorResponse = errorResponse;
        }

        protected ApiException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
