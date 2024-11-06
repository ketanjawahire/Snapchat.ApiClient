using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Snapchat.ApiClient.Exceptions
{
#pragma warning disable CA1032 // Implement standard exception constructors
    /// <summary>
    /// Represents 400 errors occured during API call.
    /// </summary>
    [Serializable]
    public class BadRequestException : Exception
#pragma warning restore CA1032 // Implement standard exception constructors
    {
        private readonly HttpStatusCode _statusCode;
        private readonly ApiError _apiError;
        private readonly ErrorResponse _errorResponse;

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestException"/> class.
        /// </summary>
        /// <param name="message">Exception message</param>
        public BadRequestException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestException"/> class.
        /// </summary>
        /// <param name="apiError">Object of type <see cref="ApiError"/>.</param>
        /// <param name="statusCode"><see cref="HttpStatusCode"/> returned by API HTTP request.</param>
        public BadRequestException(ApiError apiError, HttpStatusCode statusCode)
            : base(apiError != null ? $"{apiError.DebugMessage}. \n{apiError.DisplayMessage}. Check ApiError for more details." : string.Empty)
        {
            _statusCode = statusCode;
            _apiError = apiError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestException"/> class.
        /// </summary>
        /// <param name="serializationInfo">The System.Runtime.Serialization.SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="streamingContext">The System.Runtime.Serialization.StreamingContext that contains contextual information about the source or destination.</param>
        protected BadRequestException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}