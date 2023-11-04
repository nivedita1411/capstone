using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace MovieApp.Models
{
    public class MovieApp
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public string Name {get;set;}
        public int ReleaseYear {get;set;}
        public int Rating {get;set;}

        public ICollection<Detail> Details {get;set;}

    }
}