using System;
using System.ComponentModel.DataAnnotations;

namespace OneToMany.Models
{
    public class Tentacle 
    {
        [Key]
        public int TentacleId {get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public int Num_Suction_Cups {get; set;}
        [Required]
        public bool Has_Boxing_Glove {get; set;}
        [Required]
        public int Length {get; set;}
        [Required]
        [Display(Name = "Tentacle Owner")]
        public int OctopusId {get; set;} // This adds the OctopusId to the table
        public Octopus Owner {get; set;} // This instance of Octopus class variable name = Owner links the two tables
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}