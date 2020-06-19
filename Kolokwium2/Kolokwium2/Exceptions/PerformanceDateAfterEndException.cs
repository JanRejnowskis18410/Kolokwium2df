using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Kolokwium2.Exceptions
{
    public class PerformanceDateAfterEndException : Exception
    {
        public PerformanceDateAfterEndException()
        {
        }

        public PerformanceDateAfterEndException(string message) : base(message)
        {
        }

        public PerformanceDateAfterEndException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PerformanceDateAfterEndException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
