using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}

        [Required]
        [Display(Name = "Name of Dish")]
        public string Name{get; set;}

        [Required]
        [Display(Name = "# of Calories")]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive numbers allowed")]
        public int Calories {get; set;}

        [Required]
        [Range(1,6)]
        public int Tastiness {get; set;}
        [Required]
        public string Description {get; set;}

        [Required]
        [Display(Name = "Chef")]
        public int ChefId {get; set;} // Add the ChefID to the Dishes Table
        public Chef Owner {get; set;} // Create a Chef Instance to link the two tables
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}