//Controller Detail Controller
 
using MovieApp.Models;
// using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
// namespace MovieApp.Controllers{
//     [ApiController]
//     [Route("/[controller]")]
//     public class DetailController:ControllerBase{
//         MovieContext context=new MovieContext();
//         [HttpGet]
//         [Route("ListDetails")]
//         public  IActionResult Get(){
//             var data=from d in context.Details select new{
//                 d.Movie.Name,
//                 d.Actor,
//                 d.Role
//             };
//             return Ok(data);
//         }
//         [Route("MovieDetails/{id}")]
//         public IActionResult Get(int id)
//         {
//             var data=from d in context.Details where d.MovieId==d.Movie.Id select new{
//                 d.Actor,
//                 d.Role,
//                 d.Movie.Name,
//                 d.Movie.YearRelease
 
 
//             };
//             return Ok(data.ToList());
//         }
//         // [HttpGet]
//         // [Route("ListDetails")]
//         // public  IActionResult Get(){
//         //     var data=from m in context.Details select m;
//         //     return Ok(data);
//         // }
//         [HttpPost]
//         [Route("AddDetails")]
//         public IActionResult Post(Detail d){
//             if(ModelState.IsValid){
//                 try{
//                 context.Details.Add(d);
//                 context.SaveChanges();
//                 }
//                 catch(System.Exception ex){
//                     return BadRequest(ex.InnerException.Message);
//                 }
//             }
//             return Created("Details Added",d);
//         }
//     }
 
// }
 
 
 
 
 
 
namespace MovieApp.Controllers{
    [ApiController]
    [Route("/[controller]")]
    public class DetailController:ControllerBase{
        MovieContext context=new MovieContext();
        [HttpGet]
        [Route("ListDetails")]
        public IActionResult Get(){
            var data=from d in context.Details select new{
                d.Movie.Name,
                d.Actor,
                d.Role
            };
            return Ok(data.ToList());
        }
        [HttpGet]
        [Route("MovieDetails/{id}")]
        public IActionResult Get(int id){
            var data=from d in context.Details where d.MovieId==id select new{
            d.Actor,
            d.Role,
            d.Movie.Name,
            d.Movie.ReleaseYear
            };
            return Ok(data);
        }
        [HttpPost]
        [Route("AddMovieDetails")]
        public IActionResult Post(Detail d){
            if(ModelState.IsValid){
                try{
                    context.Details.Add(d);
                    context.SaveChanges();
                }catch(System.Exception ex){
                    return BadRequest(ex.InnerException.Message);
                }
            }
            return Created("Details",d);
        }
 
    }
}