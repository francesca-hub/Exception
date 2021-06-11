using System;
using System.Runtime.Serialization;

namespace Prova_finale
{
    [Serializable]
    internal class UsernamePresenteException : Exception
    {
        public UsernamePresenteException()
        {
        }

        public UsernamePresenteException(string message) : base(message)
        {
        }

        public UsernamePresenteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UsernamePresenteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}