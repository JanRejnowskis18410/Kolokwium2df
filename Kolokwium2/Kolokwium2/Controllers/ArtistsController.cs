using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return Ok(_service.GetArtist(id));
        }
    }
}