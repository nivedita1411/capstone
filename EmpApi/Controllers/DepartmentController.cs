using EmpApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmpApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
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
        [HttpGet]
        [Route("List")]
    }
}