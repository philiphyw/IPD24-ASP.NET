using System;
using System.Runtime.Serialization;

namespace day02RazorMyFriends.Models
{
    [Serializable]
    internal class DataInvalidException : Exception
    {
        public DataInvalidException()
        {
        }

        public DataInvalidException(string message) : base(message)
        {
        }

        public DataInvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DataInvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}