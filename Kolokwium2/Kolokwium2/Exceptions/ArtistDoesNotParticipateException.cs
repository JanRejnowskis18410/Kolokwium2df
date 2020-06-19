using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Kolokwium2.Exceptions
{
    public class ArtistDoesNotParticipateException : Exception
    {
        public ArtistDoesNotParticipateException()
        {
        }

        public ArtistDoesNotParticipateException(string message) : base(message)
        {
        }

        public ArtistDoesNotParticipateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArtistDoesNotParticipateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
