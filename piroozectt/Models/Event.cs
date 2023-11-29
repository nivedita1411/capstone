// using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace piroozectt.Models
{
    public class Event{
        [Key]
        public int EventId{get;set;}
        public string? EventType{get;set;}
        public string? Description{get;set;}
        public string? Package{get;set;}
        public string? ParticipantsCount{get;set;}
        public int Charges{get;set;}
 
 
        public ICollection<Booking> ?Booking{get;set;}
       
       
       
    }
   
}