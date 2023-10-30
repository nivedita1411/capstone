using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic; // for declaring collection
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
namespace EMS_Codefirst.Models;



[Index(nameof(Email), IsUnique = true)] //for unique email 
public class Employee
{
    [Key]
    public int EmpId {get;set;}
    [MaxLength(30)]
    public string Name {get;set;}
    public int Salary {get;set;}
    [ForeignKey("Dept")]
    public int DeptId {get;set;}
    [MaxLength(40)]
    public string Email {get;set;}
    public DateTime DOB {get;set;}

    public Dept Dept{get;set;}
}