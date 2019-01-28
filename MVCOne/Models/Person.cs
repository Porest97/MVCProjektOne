using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOne.Models
{
    public class Person
    {
        public int Id { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:####-##-##-####}")]
        [Display(Name ="Personnummer:")]
        public long Ssn { get; set; }
        public string Nationality { get; set; }
        //DropdownList
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RefNumber { get; set; }
        //DropdownList
        public string Country { get; set; }
        public string City { get; set; }
        //DropdownList
        public string Distrikt { get; set; }
        public string Association { get; set; }
        //DropdownList
        public string Category { get; set; }
        //DropdownList
        public string RefType { get; set; }
        //DropdownList
        public string RefCategoryType { get; set; }
        //DropdownList
        public string ExaminationLevel { get; set; }
        //Kontakt Info
        //c/o
        public string CoName { get; set; }
        //Adress
        public string StreetAddress { get; set; }
        //Postnr.
        public string ZIPCode { get; set; }
        //Ort
        public string County { get; set; }
        //Tel.
        [DisplayFormat(DataFormatString = "{0:+##-###-###-###}")]
        public long Phone1 { get; set; }
        //Mobil
        [DisplayFormat(DataFormatString = "{0:+##-###-###-###}")]
        public long Phone2 { get; set; }
        //E-post
        public string EMail { get; set; }
    }   
}
