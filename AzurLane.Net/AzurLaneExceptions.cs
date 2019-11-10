using System;
using System.Runtime.Serialization;
using AzurLane.Net.Core;

namespace AzurLane.Net
{
    public class ErrorResponseException : Exception
    {
        public ErrorResponseException() { }

        public ErrorResponseException(string message) : base(message) { }

        public ErrorResponseException(string message, Exception inner) : base(message, inner) { }
        
        public ErrorResponseException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        
        public ErrorResponseException(IErrorResponse error) : base(error.Error ?? error.Message) { }
    }
}