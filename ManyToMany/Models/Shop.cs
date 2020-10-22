using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManyToMany.Models
{
    public class Shop
    {
        [Key]
        public int ShopId {get; set;}
        [Required(ErrorMessage = "Shop must have a name")]
        public string ShopName {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public List<Inventory> GoodsSold {get;set;} // List of INVENTORY ITEMS sold in the shop
    }
}