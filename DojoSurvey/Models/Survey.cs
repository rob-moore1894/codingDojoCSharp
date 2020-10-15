using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        public string Name {get; set;}

        [Required]
        public string Location {get; set;}
        
        [Required]
        public string Language {get; set;}

        [MinLength(20, ErrorMessage = "Minimum of 20 characters needed")]
        public string Comment {get; set;}
    }
}