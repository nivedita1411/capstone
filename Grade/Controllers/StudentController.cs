using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Grade.Controllers
{
    
    public class StudentController : Controller
    {
        private readonly SGMSDbContext context;

        public StudentController(SGMSDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var data = context.students.Include("GradeName").ToList();
            return View(data);
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}