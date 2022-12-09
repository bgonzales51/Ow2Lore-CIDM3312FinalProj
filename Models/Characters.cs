using System;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Lore
    {
        public int LoreID {get; set;} 

        [Display(Name = "Heroes Alias")]
        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string HeroName {get; set;} = string.Empty;

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Country {get; set;} = string.Empty;

        [Display(Name = "Hero Age")]
        [Range(1,1000)]
        [Required]
        public int HeroAge {get; set;}

        [Required]
        public char Gender {get; set;}

        [Required]
        public string Allegiance {get; set;} = string.Empty;
    
        

    }
}