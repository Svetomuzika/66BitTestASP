using System;
using static _66BitTest.Models.Model;

namespace _66BitTest.Models.Entites
{
    public class Footballer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Gender Sex { get; set; }

        public string Birthdate { get; set; }

        public string Team{ get; set; }

        public string Country { get; set; }
    }
}
