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

        public ApiServiceNotFoundException(Type serviceType) : base(serviceType != null ? $"Snapchat API service of type {serviceType.Name} is not implemented yet. Please contact developer." : "Service of given type is not implemented yet. Please contact developer.")
        {
            _serviceType = serviceType;
        }

        protected ApiServiceNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
