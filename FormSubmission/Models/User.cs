using System;
using System.ComponentModel.DataAnnotations; 

namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [Display(Name = "First Name")]
        [MinLength(4, ErrorMessage = "First name must contain at least 4 letters")]
        public string FirstName {get; set;}

        [Required]
        [MinLength(4, ErrorMessage = "Last name must contain at least 4 letters")]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        [Required]
        [Range(0, 150, ErrorMessage = "Must have be a positive number")]
        public string Age {get; set;}

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        public string Password {get; set;}
    }
}