using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurveyII.Models;

namespace DojoSurveyII.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("success")]
        public IActionResult Success(Info userInfo){
            return View("Success", userInfo);
        }

        [HttpPost("survey")]
        public IActionResult Survey(Info userInfo){
            if(ModelState.IsValid){
                ViewBag.Name = userInfo.Name;
                ViewBag.Location = userInfo.Location;
                ViewBag.Language = userInfo.Language;
                ViewBag.Comment = userInfo.Comment;
                return RedirectToAction("Success", userInfo);
            } else {
                return View("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
