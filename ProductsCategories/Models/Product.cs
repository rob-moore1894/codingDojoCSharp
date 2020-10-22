using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get; set;}

        [Required(ErrorMessage = "Please enter a Product Name")]
        [Display(Name = "Name")]
        public string ProductName {get; set;}

        public string Description {get; set;}
        public decimal Price {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public List<Association> CatsOfProds {get; set;}
    }
}