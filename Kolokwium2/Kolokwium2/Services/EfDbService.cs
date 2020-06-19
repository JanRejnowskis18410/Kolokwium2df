using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public class EfDbService : IDbService
    {
        private readonly s18410Context _context;

        public EfDbService(s18410Context context)
        {
            _context = context;
        }

        public Artist GetArtist(int id)
        {
            var artist = _context.Artist.Include(a => a.ArtistEvent)
                           .FirstOrDefault(a => a.IdArtist == id);

            if(artist == null)
            {
                throw new Exception($"Artist with id={id} does not exist!");
            }

            artist.ArtistEvent = artist.ArtistEvent.OrderByDescending(a => a.PerformanceDate).ToList();

            return artist;
        }

        public void UpdateEventTime()
        {
            throw new NotImplementedException();
        }
    }
}
