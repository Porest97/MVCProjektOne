using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOne.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Phonenumber { get; set; }
        public int PersonId { get; set; }
    }
}
