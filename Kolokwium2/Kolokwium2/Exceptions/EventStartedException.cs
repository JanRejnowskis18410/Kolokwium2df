using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Kolokwium2.Exceptions
{
    public class EventStartedException : Exception
    {
        public EventStartedException()
        {
        }

        public EventStartedException(string message) : base(message)
        {
        }

        public EventStartedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EventStartedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
