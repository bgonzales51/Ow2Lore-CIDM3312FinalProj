using System;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Lore
    {
        public int LoreID {get; set;} 
        public string HeroName {get; set;} = string.Empty;
        public string Country {get; set;} = string.Empty;
        public int HeroAge {get; set;}
        public char Gender {get; set;}
        public string Allegiance {get; set;} = string.Empty;
        

    }
}