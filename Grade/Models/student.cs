using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Grade.Models
{
    public class student
    {
        
        public int Id {get;set;}
        public string StudentName {get;set;}
        public DateTime DOB {get;set;}
        public byte[] photo {get;set;}
        public decimal Height {get;set;}
        public float Weight {get;set;}

        public Grade Grade {get;set;}

    }
}