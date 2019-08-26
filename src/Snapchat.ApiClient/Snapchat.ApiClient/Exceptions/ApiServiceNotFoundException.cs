using System;

namespace Snapchat.ApiClient
{
#pragma warning disable CA1032 // Implement standard exception constructors
    public class ApiServiceNotFoundException : Exception
#pragma warning restore CA1032 // Implement standard exception constructors
    {
        private Type _serviceType;

        //TODO : generate & pass correct message to base
        public ApiServiceNotFoundException(Type serviceType) : base()
        {
            _serviceType = serviceType;
        }
    }
}
