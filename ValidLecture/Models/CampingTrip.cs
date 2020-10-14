using System.ComponentModel.DataAnnotations;
using System; 

namespace ValidLecture.Models
{
    public class CampingTrip
    {
        [Required]
        [MinLength(3)] // Built in Validation
        public string Name {get; set;}

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "When does it start?")]
        [FutureDate]
        public DateTime StartDate {get; set;}

        [Required]
        [DataType(DataType.DateTime)]
        [FutureDate]
        public DateTime EndDate {get; set;}

        [Required]
        [MinLength(5, ErrorMessage = "You need at least 5 characters!")] // Custom Error Message
        public string Location {get; set;}
        public string BearProtection {get; set;}
    }

    // Custom Validation
    public class FutureDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value is DateTime){
                DateTime check = (DateTime) value; 

                if(check > DateTime.Now){
                    return ValidationResult.Success; 
                }
                else return new ValidationResult("Date must be in the future");
            }
            else 
            {
                return new ValidationResult("That is not a date!");
            }
            
        }
    }
}
