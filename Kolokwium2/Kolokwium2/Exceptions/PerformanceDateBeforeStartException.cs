using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Kolokwium2.Exceptions
{
    public class PerformanceDateBeforeStartException : Exception
    {
        public PerformanceDateBeforeStartException()
        {
        }

        public PerformanceDateBeforeStartException(string message) : base(message)
        {
        }

        public PerformanceDateBeforeStartException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PerformanceDateBeforeStartException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
