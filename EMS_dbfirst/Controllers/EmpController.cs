

namespace EMS_dbfirst.Controllers;
public IActionResult List()
{
    var data = context.Employees.ToList();
    return View();
}

public IActionResult Create ()
{
    //dropdown for deptname
    ViewBag.DeptId = new SelectList(ContextBoundObject.Departments,"Id","DepartmentName");
    return View();
}
[HttpPost]
public IActionResult Create(Employee emp)
{
    if(ModelsState.IsValid)
    {
        context.Employees.Add(emp);
        context.SaveChanges();
        return RedirectToAction("List");
    }

    return View(emp);
}