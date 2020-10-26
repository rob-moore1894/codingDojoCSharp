using System;
using System.ComponentModel.DataAnnotations;

namespace CSExam.Models
{
    public class InterestHistory
    {
        [Key]
        public int IntHistId {get; set;}
        // User that joins the activity
        public int UserId {get; set;}
        // Activity joined
        public int InterestId {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public User Participant {get; set;}
        public Interest Interest {get; set;}

    }
}