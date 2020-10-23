using System;
using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
    public class TaskHistory
    {
        [Key]
        public int ActivityHistoryId {get; set;}
        // User that joins the activity
        public int UserId {get; set;}
        // Activity joined
        public int ActivityId {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public User Participant {get; set;}
        public Task Task {get; set;}

    }
}