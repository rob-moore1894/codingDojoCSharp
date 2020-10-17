using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost("generate")]
        public IActionResult Generate()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = 14;
            string randomStr = "";
            var random = new Random(); 
            for (int i = 0; i < length; i++){
                int a = random.Next(chars.Length);
                randomStr += chars.ElementAt(a);
            }
            ViewBag.randomStr = randomStr; 
            Console.WriteLine(randomStr);
            return RedirectToAction("Index", randomStr); 
        }

    }
}
