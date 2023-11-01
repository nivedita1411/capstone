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
            var data = context.students.Include("Grade").ToList();
            return View(data);
        }

        public IActionResult AddnewStudent( )
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddnewStudent(student stu)
        {
            if(ModelState.IsValid)
            {
                context.students.Add(stu);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(stu);

        }

        public IActionResult UpdateDetails(int Id)
        {
            var data = context.students.Find(Id);
            return View(data);
        }
        [HttpPost]
        public IActionResult UpdateDetails(student s)
        {
            if(ModelState.IsValid)
            {
                student stud = context.students.Find(s.Id);
                stud.StudentName = s.StudentName;
                stud.DOB = s.DOB;
                stud.photo = s.photo;
                stud.Height = s.Height;
                stud.Weight = s.Weight;

                context.SaveChanges();

                return RedirectToAction("Index");

            }

            return View();
        }

        // // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}