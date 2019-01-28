using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOne.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HomeArena { get; set; }
        public string TeamType { get; set; }
        public string TeamHeadCoach { get; set; }
        public string TeamAssistingCoach1 { get; set; }
        public string TeamAssistingCoach2 { get; set; }
        public string TeamCashier { get; set; }
        public string TeamStaff1 { get; set; }
        public string TeamStaff2 { get; set; }
        public string TeamStaff3 { get; set; }
    }
}
