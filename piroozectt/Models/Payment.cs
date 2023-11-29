using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace piroozectt.Models
{
    public class Payment{
        [Key]
        public int PaymentId{get;set;}
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

        public Booking? Booking {get; set;}
 
 
 
 
       
       
       
       
    }
   
}