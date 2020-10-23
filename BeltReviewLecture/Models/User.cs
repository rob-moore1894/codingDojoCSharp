using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeltReviewLecture.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set;}

        [Required]
        public string RealName {get; set;}

        [Required]
        public string UserName {get; set;}

        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [MinimumAge(18, ErrorMessage = "Must be over 18")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DoB {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;

        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        //My one to many -> orders my user has to complete
        public List<Gig> Commissions {get;set;}
        // My many to many
        public List<OrderHistory> OrderHistory {get;set;}

        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm {get; set;}
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