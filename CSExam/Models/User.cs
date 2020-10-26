using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSExam.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set;}

        [Required]
        [MinLength(2)]
        public string Name {get; set;}

        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*\d)(?=.*[^\da-zA-Z]).{8}$", ErrorMessage = "Password must meet requirements")]
        public string Password {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;

        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        // One to many -> All the Interests the coordinator made
        public List<Interest> coordInterest {get; set;}

        public List<InterestHistory> InterestHistory {get; set;}

        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm {get; set;}
    }
}