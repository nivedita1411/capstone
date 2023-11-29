using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace capstoneapi.Models
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
 
        public string? EventType{get;set;}
        public int HeadCount{get;set;}
        public int Payment{get;set;}
        [ForeignKey("Event")]
 
        public int EventId{get;set;}
 
       
    }
   
}



using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace capstoneapi.Models
{
    public class Payment{
        [Key]
        public int? PaymentId{get;set;}
        [ForeignKey("Booking")]
        public int? BookingId{get;set;}
        public int? OrganizerId{get;set;}
        public int Amount{get;set;}
        // [EmailAddress("Email")]
        public int? GSTCharges{get;set;}
 
        public DateTime EventDate{get;set;}
        public string Event{get;set;}
        public DateTime PaymentDate{get;set;}
        public int TotalAmt{get;set;}
 
 
 
 
       
       
       
       
    }
   
}