using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet]
        [Route("")]

        public ViewResult Index()
        {
            return View(); 
        }

        [HttpPost]
        [Route("result")]
        public IActionResult userInfo(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View("Result"); 
        }
    }
}