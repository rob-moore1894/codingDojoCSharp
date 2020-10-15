using System.ComponentModel.DataAnnotations;
using System;

namespace DojoSurveyII.Models
{
    public class Info
    {
        [Required]
        [MinLength(2, ErrorMessage = "Name must have at least 2 characters")]
        public string Name {get; set;}

        [Required]
        public string Location {get; set;}
        
        [Required]
        public string Language {get; set;}

        [MinLength(20, ErrorMessage = "Minimum of 20 characters needed")]
        public string Comment {get; set;}
    }
}