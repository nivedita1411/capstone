using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDMS.Models
{
    public class BloodDonor
    {
        public int ID {get;set;}
        public string Name {get;set;}
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DOB {get;set;}
        public string Gender {get;set;}
        public string BloodGroup {get;set;}
        // [MaxLength(10)]
        [RegularExpression(@"\d{10}", ErrorMessage = "Only 10 integers Allowed")]
        public string PhoneNumber {get;set;}
        [DataType(DataType.EmailAddress)]
        public string Email {get;set;}
        public string Location {get;set;}
    }
}