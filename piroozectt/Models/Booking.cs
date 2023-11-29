using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace piroozectt.Models
{
    public class Booking{
        [Key]
        public int BookingId{get;set;}
 
        public string? UserId{get;set;}
        public string? UserName{get;set;}
 
        public DateTime SubmissionDate{get;set;}
 
        public DateTime EventDate{get;set;}
 
        public string? Description{get;set;}
        public string? BookingStatus{get;set;}

        public ICollection<Payment> Payments { get; set; }
 
        public string? EventType{get;set;}
        public int HeadCount{get;set;}
        public int Payment{get;set;}
        [ForeignKey("Event")]
 
        public int ?EventId{get;set;}

        public Event? Event {get;set;}
        public User? User {get;set;}

        
 
       
    }
   
}

