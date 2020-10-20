using System;
using System.ComponentModel.DataAnnotations;

namespace LoginRegister.Models
{
    public class LUser
    {
        [Required]
        [EmailAddress]
        public string LEmail {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string LPassword {get; set;}
    }
}