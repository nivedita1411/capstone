using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EMS_dbfirst.Models;

public partial class Department
{
    public int Id { get; set; }
    [Display(Name = "Department Name")]
    [Required(ErrorMessage = "Department Name cannot be blank")]
    public string DeptName { get; set; } = null!;
    
    public string Location { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
