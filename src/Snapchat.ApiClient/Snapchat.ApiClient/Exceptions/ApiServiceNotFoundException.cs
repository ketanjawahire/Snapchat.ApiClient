using System;
using System.Runtime.Serialization;

namespace Snapchat.ApiClient.Exceptions
{
#pragma warning disable CA1032 // Implement standard exception constructors
    [Serializable]
    public class ApiServiceNotFoundException : Exception
#pragma warning restore CA1032 // Implement standard exception constructors
    {
        private Type _serviceType;

        //TODO : generate & pass correct message to base
        public ApiServiceNotFoundException(Type serviceType) : base()
        {
            _serviceType = serviceType;
        }

        protected ApiServiceNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
