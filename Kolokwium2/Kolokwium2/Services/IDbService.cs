using Kolokwium2.Models;
using System.Collections;

namespace Kolokwium2.Services
{
    public interface IDbService
    {
        public Artist GetArtist(int id);
        public void UpdateEventTime();
    }
}
