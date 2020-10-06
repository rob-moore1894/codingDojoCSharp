using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet]
        [Route("projects")]

        public ViewResult Projects()
        {
            return View(); 
        }
    }
}