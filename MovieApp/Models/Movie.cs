using System.Collections.Generic;

namespace MovieApp.Models
{
    public class MovieApp
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public string Name {get;set;}
        
    }
}