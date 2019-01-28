using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOne.Models
{
    public class Arena
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string ZIPCode { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string NameNumberOfKonferanses { get; set; }
        public string FoodCourt { get; set; }
        public string ParkingSpace { get; set; }
        public string AvailabilityHoursMoFre { get; set; }
        public string AvailabilityHoursWeekEnds { get; set; }
    }
}
