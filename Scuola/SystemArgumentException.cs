using System.Runtime.Serialization;

namespace Scuola
{
    [Serializable]
    internal class SystemArgumentException : Exception
    {
        public SystemArgumentException()
        {
        }

        public SystemArgumentException(string? message) : base(message)
        {
        }

        public SystemArgumentException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SystemArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}