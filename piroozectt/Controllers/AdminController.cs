using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using piroozectt.Models;


//  Register
// 2.     Login
// 3.     Post Event details
// 4.     Edit Event Details
// 5.     Delete Event Details
// 6.     View All Events
// 7.     View All Bookings
// 8.     View All Payments
// 9.     Logout
 
namespace EventBooking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        AppDbContext context=new AppDbContext();


        [HttpGet]
        [Route("/event")]
        public IActionResult GetEvent()
        {
            // var data=context.Movies.ToList();
            var data=from m in context.Events select m;
            return Ok(data);
        }
 
        [HttpGet]
        [Route("ListBookings")]
        public IActionResult GetBooking()
        {
            // var data=context.Movies.ToList();
            var data=from m in context.Bookings select m;
            return Ok(data);
        }
 
        [HttpPost]
        [Route("/event")]
        public IActionResult PostBooking(Event e)
        {
            if(ModelState.IsValid)
            {
                try{
                    context.Events.Add(e);
                    context.SaveChanges();
 
                }
                catch(System.Exception ex){
                    return BadRequest(ex.InnerException.Message);
 
                }
            }
            return Created("Record Added", e);
 
        }
 
        [HttpPut]
        [Route("EditEvent/{id}")]
        public IActionResult PutEvent(int id, Event e)
        {
            if(ModelState.IsValid)
            {
                Event ev = context.Events.Find(id);
                ev.EventType = e.EventType;
                ev.Description = e.Description;
                ev.Package = e.Package;
                ev.Charges = e.Charges;
                
                
                context.SaveChanges();
                return Ok();
 
            }
            return BadRequest("Unable to Edit Event");
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
 
                context.Events.Remove(data);
                context.SaveChanges();
                return Ok();
            }
           
            catch (Exception e)
            {
               
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("ListPayments")]
        public IActionResult GetPayment()
        {
            // var data=context.Movies.ToList();
            var data=from m in context.Payments select m;
            return Ok(data);
        }
    }
}