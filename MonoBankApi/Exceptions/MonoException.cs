using System;

namespace MonoBankApi.Exceptions
{
    public class MonoException : Exception
    {
        public MonoException(string message) : base(message) { }
    }
}
