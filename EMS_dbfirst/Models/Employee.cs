using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EMS_dbfirst.Models;

public partial class Employee
{
    public int EmpId { get; set; }
    [Required(ErrorMessage = "Name is required")]

    public string Name { get; set; } = null!;

    public int Salary { get; set; }

    public int DeptId { get; set; }

    public string Email { get; set; } = null!;
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    [DobCheck(ErrorMessage = "Atleast 25 years of age required")]
    public DateTime Dob { get; set; }

    public virtual Department Dept { get; set; } = null!;
}
