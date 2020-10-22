using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsCategories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {get; set;}

        [Required(ErrorMessage = "Please enter a Category Name")]
        [Display(Name = "Name")]
        public string CategoryName {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public List<Association> ProdsInCats {get; set;}
    }
}