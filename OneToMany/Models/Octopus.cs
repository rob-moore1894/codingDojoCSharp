using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; 

namespace OneToMany.Models
{
    public class Octopus
    {
        [Key]
        public int OctopusId {get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public string Hat {get; set;}
        [Required]
        public int Ink_Amount {get; set;}
        public List<Tentacle> Tentacles {get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}