using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Snapchat.ApiClient.Exceptions
{
#pragma warning disable CA1032 // Implement standard exception constructors
    /// <summary>
    /// Represents unauthorized access errors occured during API call.
    /// </summary>
    [Serializable]
    public class RateLimitExceededException : Exception
#pragma warning restore CA1032 // Implement standard exception constructors
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitExceededException"/> class.
        /// </summary>
        /// <param name="message">Exception message</param>
        public RateLimitExceededException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitExceededException"/> class.
        /// </summary>
        /// <param name="serializationInfo">The System.Runtime.Serialization.SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="streamingContext">The System.Runtime.Serialization.StreamingContext that contains contextual information about the source or destination.</param>
        protected RateLimitExceededException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
