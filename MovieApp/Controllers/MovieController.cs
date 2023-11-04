using MovieApp.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MovieApp.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class MovieController : ControllerBase
    {
        MovieContext context = new MovieContext();
        [HttpGet]
        [Route("ListMovies")]
        public IActionResult Get()
        {
            var data = from m in context.Movies select m;
            return Ok(data);
        }
        [HttpGet]
        [Route("ListMovies/{id}")]
        public IActionResult Get(int id)
        {
            if(id == null)
            {
                return BadRequest("Id cannot be null");
            }
            var data = (from m in context.Movies where m.Id == id select m).FirstOrDefault();
            if(data == null)
            {
                return NotFound($"Movie {id} not found"); //404
            }
            return Ok(data); //200
        }

        [HttpPost]
        [Route("AddMovie")]
        public IActionResult Post(Movie movie)
        {
            if(ModelState.IsValid)
            {
                try{
                    context.Movies.Add(movie);
                    context.SaveChanges();
                }
                catch(SystemException ex)
                {
                    return BadRequest(ex.InnerException.Message);
                }
            }

            return Created("Record Added", movie); //
        }

        [HttpPut]
        [Route("EditMovie/{id}")]
        public IActionResult Put(int id, Movie movie)
        {
            if(ModelState.IsValid)
            {
                Movie omovie = context.Movies.Find(id);
                omovie.Name = movie.Name;
                omovie.Rating = movie.Rating;
                omovie.ReleaseYear = movie.ReleaseYear;
                context.SaveChanges();
                return Ok();
            }

            return BadRequest("Unable to Edit Record");
        }

        [HttpDelete]
        [Route("DeleteMovie/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var detail = context.Details.Where(d=> d.MovieId == id);
                if(detail.Count() != 0)
                {
                    throw new Exception("Cannot Delete Movie");
                }
                var data = context.Movies.Find(id);
                context.Movies.Remove(data);
                context.SaveChanges();
                return Ok();
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}