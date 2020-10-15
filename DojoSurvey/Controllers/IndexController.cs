using System; 
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models; 

namespace DojoSurvey.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }

        [HttpGet("result")]
        public IActionResult Result()
        {
            return View(); 
        }

        [HttpPost("survey")]
        public IActionResult Submit(Survey yourSurvey)
        {
            if(ModelState.IsValid){
                ViewBag.Name = yourSurvey.Name;
                ViewBag.Location = yourSurvey.Location;                
                ViewBag.Language = yourSurvey.Language;                
                ViewBag.Comment = yourSurvey.Comment;                
                return RedirectToAction("Result", yourSurvey);
            } else {
                return View("Index"); 
            }
        }

        
    }
}