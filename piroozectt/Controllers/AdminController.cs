using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using piroozectt.Models;
 
namespace EventBooking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        AppDbContext context=new AppDbContext();
 
        [HttpGet]
        [Route("ListBookings")]
        public IActionResult GetBooking()
        {
            // var data=context.Movies.ToList();
            var data=from m in context.Bookings select m;
            return Ok(data);
        }
 
        [HttpPost]
        [Route("AddBooking")]
        public IActionResult PostBooking(Booking Booking)
        {
            if(ModelState.IsValid)
            {
                try{
                    context.Bookings.Add(Booking);
                    context.SaveChanges();
 
                }
                catch(System.Exception ex){
                    return BadRequest(ex.InnerException.Message);
 
                }
            }
            return Created("Record Added", Booking);
 
        }
 
        [HttpPut]
        [Route("EditEvent/{id}")]
        public IActionResult PutBooking(int id, Booking Booking)
        {
            if(ModelState.IsValid)
            {
                Booking b = context.Bookings.Find(id);
                b.BookingStatus = Booking.BookingStatus;
                
                context.SaveChanges();
                return Ok();
 
            }
            return BadRequest("Unable to Edit Booking");
        }

        [HttpDelete]
        [Route("DeleteEvent/{id}")]
        public IActionResult DeleteEvent (int id)
        {
            var data = context.Bookings.Find(id);
            try
            {
                if(data == null)
                {
                    return NotFound();
                }
 
                context.Bookings.Remove(data);
                context.SaveChanges();
                return Ok();
            }
           
            catch (Exception e)
            {
               
                return BadRequest(e.Message);
            }
        }