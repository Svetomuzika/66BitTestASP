using System.Collections.Generic;
using _66BitTest.Models.Entites;
using static _66BitTest.Models.Model;

namespace _66BitTest.Models
{
    public class FootballersViewModel
    {
        public Footballer Footballer { get; set; }

        public List<Footballer> Footballers { get; set; }

        public List<string> Countries { get; set; }

        public List<string> Teams { get; set; }

        public Gender Sex { get; set; }
    }
}
