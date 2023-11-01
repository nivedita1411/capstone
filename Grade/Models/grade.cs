using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using Grade.Models;

namespace Grade.Models
{
    public class grades
    {
        public int GradeId {get;set;}
        public string GradeName {get;set;}
        public string Section {get;set;}

        public ICollection<student> Students {get;set;}
    }
}