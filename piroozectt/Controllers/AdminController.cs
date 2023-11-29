using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using piroozectt.Models;

namespace piroozectt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Admin : ControllerBase
    {

        [HttpPut]
        [Route("UpdateEvent/{id}")]
        public IActionResult PutEvent(int id, Event event)
        {
            try
            {
                context.
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public IActionResult DeleteEvent (int id)
        {
            try
            {
                if(id == null)
                {
                    throw 
                }
                context.DeleteEvent()
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
        [HttpDelete]
        [Route("DeleteDept/{id}")]
        public IActionResult DeleteDept(int id)
        {
            repo.DeleteDept(id);
            return Ok();
        }
        

    }
}

IDept repo;
        public DepartmentController(IDept _repo)
        {
            this.repo = _repo;
        }
        [HttpGet]
        [Route("ListDept")]
        public IActionResult GetDept()
        {
            var data = repo.GetDepartments();
            return Ok(data);
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult PostDept(Department dept)
        {
            if(ModelState.IsValid)
            {
                repo.AddDept(dept);
                return Created("Record Added",dept);
            }
            return BadRequest();
        }
        
        [Route("ListDept/{id}")]
        public IActionResult GetDept (int id)
        {
            var data = repo.FindDept(id);
            return Ok(data);
        }
        