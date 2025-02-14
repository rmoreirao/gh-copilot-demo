using albums_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace albums_api.Controllers
{
    [Route("artists")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        // GET: api/artists
        [HttpGet]
        public IActionResult Get()
        {
            var artists = Artist.GetAll();
            return Ok(artists);
        }

        // GET api/artists/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var artist = Artist.GetAll().FirstOrDefault(a => a.Id == id);
            if (artist == null)
            {
                return NotFound();
            }
            return Ok(artist);
        }

        // POST api/artists
        [HttpPost]
        public IActionResult Post([FromBody] Artist artist)
        {
            Artist.Add(artist);
            return CreatedAtAction(nameof(Get), new { id = artist.Id }, artist);
        }
    }
}
