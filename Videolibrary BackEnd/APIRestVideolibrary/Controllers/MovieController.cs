using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videolibrary_CRUD.DataAccess;
using Videolibrary_CRUD.Backend;
using Microsoft.AspNetCore.Http;
using Videolibrary_CRUD.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIRestVideolibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieSC movieService = new MovieSC();
        // GET: api/<MovieController>
        [HttpGet]
        public IActionResult Get()
        {
            var movies = movieService.GetAllMovies().Select(s => new Movie
            {
                Id = s.Id,
                Title = s.Title,
                Director = s.Director,
                Genre = s.Genre,
                ReleaseDate = s.ReleaseDate,
                Rating = s.Rating

            }).ToList();

            return Ok(movies);
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var movie = movieService.GetMovieById(id);
                return Ok(movie);
            }
            catch(Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        // POST api/<MovieController>
        [HttpPost]
        public IActionResult Post([FromBody] MovieModel newMovie)
        {
            try
            {
                movieService.AddMovie(newMovie);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MovieModel newMovie)
        {
            try
            {
                movieService.UpdateMovieById(id, newMovie);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                movieService.DeleteMovieById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorServer(ex);
            }
        }

        #region helpers
        private IActionResult ThrowInternalErrorServer(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
        #endregion
    }
}
