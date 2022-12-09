using System;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class InGame
    {
        public int InGameId {get; set;}

        
        public string HeroRole {get; set;} = string.Empty;
        public string Weapon {get; set;} = string.Empty;
        

    }
}