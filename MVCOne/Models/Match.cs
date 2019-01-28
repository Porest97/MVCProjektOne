using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOne.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime MatchDate { get; set; }
        public DayOfWeek DayOfWeek { get => MatchDate.DayOfWeek; }
        public Arena Arena { get; set; }
        public Series Series { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public string Score1 { get; set; }
        public string Score2 { get; set; }
        [Display(Name ="Domare")]
        public Referee Referee1 { get; set; }
        [Display(Name = "Domare")]
        public Referee Referee2 { get; set; }
        [Display(Name = "Linjedomare")]
        public Referee Referee3 { get; set; }
        [Display(Name = "Linjedomare")]
        public Referee Referee4 { get; set; }        
    }
}
