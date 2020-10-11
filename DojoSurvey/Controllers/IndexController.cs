using System; 
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models; 

namespace DojoSurvey.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(); 
        }

        [HttpPost("survey")]
        public IActionResult Submission(Survey yourSurvey)
        {
            
            return View("Result", yourSurvey); 
        }
    }
}