using System;

namespace Snapchat.ApiClient
{
#pragma warning disable CA1032 // Implement standard exception constructors
    public class UnauthorizedAccessException : Exception
#pragma warning restore CA1032 // Implement standard exception constructors
    {
        //TODO : generate & pass correct message to base
        public UnauthorizedAccessException() : base()
        {
        }
    }
}
