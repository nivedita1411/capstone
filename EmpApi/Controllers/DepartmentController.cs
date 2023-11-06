using EmpApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Linq;
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
    }
}