using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOne.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person Person { get; set; }
        public string Function { get; set; }
        public string Discription { get; set; }
        public double Active { get; set; }
        public string Role { get; set; }
    }
}
