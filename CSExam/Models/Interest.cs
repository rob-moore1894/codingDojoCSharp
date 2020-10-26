using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSExam.Models
{
    public class Interest
    {
        [Key]
        public int InterestId {get; set;}

        [Required]
        public string Title {get; set;}
        
        public DateTime Date {get; set;}
        public int Duration {get; set;}

        [Required]
        public string Description {get; set;}
        
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public int UserId {get; set;}
        public User Coordinator {get; set;}

        public List<InterestHistory> InterestHistory {get; set;}
    }
}