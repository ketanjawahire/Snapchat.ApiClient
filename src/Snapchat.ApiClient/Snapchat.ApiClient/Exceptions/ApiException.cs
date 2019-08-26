using System;
using System.Net;

namespace Snapchat.ApiClient
{
#pragma warning disable CA1032 // Implement standard exception constructors
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
    }
}
