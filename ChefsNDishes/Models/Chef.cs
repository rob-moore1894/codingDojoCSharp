using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; 

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefID {get; set;}

        [Required]
        public string FirstName {get; set;}

        [Required]
        public string LastName {get; set;}

        [Required]
        [MinimumAge(18, ErrorMessage = "Chef must be over 18")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DoB {get; set;}
        public List<Dish> Dishes {get; set;} // Create a list of the many dishes for the chef
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }

    public class MinimumAgeAttribute : ValidationAttribute
    {
        int _minimumAge; 
        public MinimumAgeAttribute(int minimumAge)
        {
            _minimumAge = minimumAge; 
        }

        public override bool IsValid(object value)
        {
            DateTime date; 
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(_minimumAge) < DateTime.Now;
            }
            return false; 
        }
    }

}