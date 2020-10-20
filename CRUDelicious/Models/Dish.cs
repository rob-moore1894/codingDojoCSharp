using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}
        [Required]
        [Display(Name = "Dish Name")]
        public string Name {get; set;}
        [Required]
        public string Chef {get; set;}
        [Required]
        [Range(0,6)]
        public int Tastiness {get; set;}
        [Required]
        [Range(0,9999, ErrorMessage = "Must be a positive number")]
        public int Calories {get; set;}
        [Required]
        public string Description {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now; 
    }
}