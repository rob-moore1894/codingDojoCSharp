using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
    public class Task
    {
        [Key]
        public int TaskId {get; set;}

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

        public List<ActivityHistory> ActivityHistory {get; set;}
    }
}