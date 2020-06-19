using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Kolokwium2.Exceptions
{
    public class EventDoesNotExistException : Exception
    {
        public EventDoesNotExistException()
        {
        }

        public EventDoesNotExistException(string message) : base(message)
        {
        }

        public EventDoesNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EventDoesNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
