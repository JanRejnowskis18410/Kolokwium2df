using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2.DTOs.Requests;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers
{
    [Route("api/artists")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IDbService _service;

        public ArtistsController(IDbService service)
        {
            _service = service;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetTests(int id)
        {
            try
            {
                return Ok(_service.GetArtist(id));
            }catch(Exception exc)
            {
                return BadRequest(exc.Message);
            }
        }

        [HttpPut("{artistId:int}/events/{eventId:int}")]
        public IActionResult UpdatePerformanceDate(int artistId, int eventId, UpdateArtistPerformanceDateRequest request)
        {
            try
            {
                _service.UpdateEventTime(artistId, eventId, request);
                return Ok();
            } catch (Exception exc)
            {
                return BadRequest(exc.Message);
            }
        }
    }
}