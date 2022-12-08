using System;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class InGame
    {
        public int InGameId {get; set;}

        public string HeroRole {get; set;} = string.Empty;
        public string Weapon {get; set;} = string.Empty;
        public string BestAbility {get; set;} = string.Empty;
        public int Damage {get; set;} 
        public int Health {get; set;}

    }
}