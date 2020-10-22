using System; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations;

namespace ManyToMany.Models
{
    public class Good
    {
        [Key]
        public int GoodId {get; set;}
        [Required(ErrorMessage = "Please provide a name")]
        public string GoodName {get; set;}

        [Required(ErrorMessage = "Calories are required")]
        [Range(1,int.MaxValue)]
        public int Calories {get; set;}

        [Required(ErrorMessage = "Please provide a picture")]
        public string Photo {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now; 
        public DateTime UpdatedAt {get; set;} = DateTime.Now; 
        public List<Inventory> ShopsSoldAt {get;set;} // List of SHOPS goods are sold at
    }
}