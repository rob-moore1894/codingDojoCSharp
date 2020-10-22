using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsCategories.Models;
using Microsoft.EntityFrameworkCore; 

namespace ProductsCategories.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("products")]
        public IActionResult Products()
        {
            ViewBag.AllProducts = _context.Products.ToList();
            return View();
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction("products");
            } else {
                ViewBag.AllProducts = _context.Products.ToList();
                return View("products");
            }
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            ViewBag.AllCategories = _context.Categories.ToList();
            return View();
        }

        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(Category newCategory)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newCategory);
                _context.SaveChanges();
                return RedirectToAction("categories");
            } else {
                ViewBag.AllCategories = _context.Categories.ToList();
                return View("categories"); 
            }
        }

        [HttpGet("products/{ProductId}")]
        public IActionResult OneProduct(int ProductId)
        {
            ViewBag.OneProduct = _context.Products.Include(p => p.CatsOfProds).ThenInclude(c => c.Category).FirstOrDefault(a => a.ProductId == ProductId);
            ViewBag.AllCategories = _context.Categories.ToList();
            return View();
        }

        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Association addCat)
        {
            _context.Add(addCat);
            _context.SaveChanges();
            return Redirect($"products/{addCat.ProductId}");
        }

        [HttpGet("categories/{CategoryId}")]
        public IActionResult OneCategory(int CategoryId)
        {
            ViewBag.OneCategory = _context.Categories.Include(c => c.ProdsInCats).ThenInclude(p => p.Product).FirstOrDefault(a => a.CategoryId == CategoryId);
            ViewBag.AllProducts = _context.Products.ToList();
            return View();
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Association addProd)
        {
            _context.Add(addProd);
            _context.SaveChanges();
            return Redirect($"categories/{addProd.CategoryId}");
        }
    }
}
