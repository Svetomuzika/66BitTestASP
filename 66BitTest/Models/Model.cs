using System.Collections.Generic;

namespace _66BitTest.Models
{
    public class Model
    {
        public static readonly List<string> Countries = new() { "Россия", "США", "Италия" };

        public static Gender Sex { get; set; }

        public enum Gender
        {
            Мужской,
            Женский
        }
    }
}
