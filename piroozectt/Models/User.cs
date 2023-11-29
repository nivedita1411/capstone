using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace capstoneapi.Models
{
    public class User{
        [Key]
        public int? UserId{get;set;}
        public string? UserName{get;set;}
        public string? Password{get;set;}
        public string MobileNumber{get;set;}
        // [EmailAddress("Email")]
        public string? Email{get;set;}

       public virtual ICollection<Booking> Booking {get;set;}
       
       
       
       
    }
   
}