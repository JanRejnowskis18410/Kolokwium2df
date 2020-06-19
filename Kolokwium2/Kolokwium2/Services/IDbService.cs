using Kolokwium2.DTOs.Requests;
using Kolokwium2.Models;
using System.Collections;

namespace Kolokwium2.Services
{
    public interface IDbService
    {
        public Artist GetArtist(int id);
        public void UpdateEventTime(int artistId, int eventId, UpdateArtistPerformanceDateRequest request);
    }
}
