using System;
using System.Runtime.Serialization;

namespace Snapchat.ApiClient.Exceptions
{
#pragma warning disable CA1032 // Implement standard exception constructors
    [Serializable]
    public class UnauthorizedAccessException : Exception
#pragma warning restore CA1032 // Implement standard exception constructors
    {
        public UnauthorizedAccessException() : base(Constants.UNAUTHORIZED_USER)
        {
        }

        protected UnauthorizedAccessException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
