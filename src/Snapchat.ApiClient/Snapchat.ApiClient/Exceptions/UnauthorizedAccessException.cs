using System;
using System.Runtime.Serialization;

namespace Snapchat.ApiClient.Exceptions
{
#pragma warning disable CA1032 // Implement standard exception constructors
    [Serializable]
    public class UnauthorizedAccessException : Exception
#pragma warning restore CA1032 // Implement standard exception constructors
    {
        //TODO : generate & pass correct message to base
        public UnauthorizedAccessException() : base()
        {
        }

        protected UnauthorizedAccessException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
