using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOne.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Series { get; set; }
        public string GameTime { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name="Arvode")]
        public float Sallary { get; set; }
    }
}
