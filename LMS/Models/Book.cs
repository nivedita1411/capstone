using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LMS.Models;

// Table[("Book")]
[Table("Book")]

public class Book
{
    public int Id {get;set;}
    public string Title {get;set;}
    public string Author {get;set;}
    public int PublisherYear {get;set;}
}