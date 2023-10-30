using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// using System.Collections.Generic; // for declaring collection
namespace LMS.Models;



public class LibraryCard
{
    public int Id{get;set;}
    public string CardNumber {get;set;}
    public string MemberName {get;set;}
    public DateTime ExpiryDate {get;set;}

}