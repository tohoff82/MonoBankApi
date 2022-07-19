using System;
using System.Runtime.Serialization;

namespace MonoBankApi.Exceptions
{
    public class MonoException : Exception
    {
        public MonoException()
        {
        }

        public MonoException(string message) : base(message) { }

        public MonoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MonoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
