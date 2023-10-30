using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic; // for declaring collection
namespace EMS_Codefirst.Models;

[Table("Department")]

public class Dept
{
    // [key]
    public int Id {get;set;}
    [Required(ErrorMessage = "Name Cannot be Empty")]
    [MaxLength(30)]
    [Column("DeptName")]
    public string Name {get;set;}
    [MaxLength(30)]
    public string Location {get;set;}

    public ICollection <Employee>Employees{get;set;} //collection 

}