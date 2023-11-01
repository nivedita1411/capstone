using System;
using Microsoft.AspNetCore.Mvc;
using EMS_dbfirst.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMS_dbfirst.Controllers;

public class EmpController : Controller
{
    private readonly EmsdatabaseContext context;

    public EmpController (EmsdatabaseContext _context)
    {
        context = _context;
    }

    public IActionResult List()
{
    // var data = context.Employees.ToList();
    var data = context.Employees.Include("Dept").ToList();
    return View(data);
}

public IActionResult Create ()
{
    //dropdown for deptname
    ViewBag.DeptId = new SelectList(context.Departments,"Id","DepartmentName");
    return View();
}
[HttpPost]
public IActionResult Create(Employee emp)
{
    // if(ModelsState.IsValid)
    {
        context.Employees.Add(emp);
        context.SaveChanges();
        return RedirectToAction("List");
    }

    return View(emp);
}
}
