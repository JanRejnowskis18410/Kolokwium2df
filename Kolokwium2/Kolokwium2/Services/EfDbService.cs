using Kolokwium2.DTOs.Requests;
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
                throw new Exception($"Artist with id = {id} does not exist!");
            }

            artist.ArtistEvent = artist.ArtistEvent.OrderByDescending(a => a.PerformanceDate).ToList();

            return artist;
        }

        public void UpdateEventTime(int artistId, int eventId, UpdateArtistPerformanceDateRequest request)
        {
            var artist = _context.Artist.Include(a => a.ArtistEvent)
                                        .SingleOrDefault(a => a.IdArtist == artistId);

            if (artist == null)
            {
                throw new Exception($"Artist with id = {artistId} does not exist!");
            }

            var _event = _context.Event.SingleOrDefault(e => e.IdEvent == request.idEvent);

            if (_event == null)
                throw new Exception($"Event with id = {request.idEvent} does not exist!");

            var artistEvent = artist.ArtistEvent.SingleOrDefault(ae => ae.IdEvent == _event.IdEvent);

            if (artistEvent == null)
                throw new Exception($"Artist does not participate in event with id = {_event.IdEvent}");

            if (DateTime.Compare(artistEvent.PerformanceDate, DateTime.Now) <= 0)
                throw new Exception($"Event with id = {artistEvent.IdEvent} has already began!");

            if (DateTime.Compare(request.performanceDate, _event.StartDate) < 0)
                throw new Exception($"The new performance date is incorrect - before start date!");
            else if(DateTime.Compare(request.performanceDate, _event.EndDate) > 0)
                throw new Exception($"The new performance date is incorrect - after end date!");

            artistEvent.PerformanceDate = request.performanceDate;
            _context.SaveChanges();
        }
    }
}
