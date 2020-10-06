using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet]
        [Route("projects")]

        public string Projects()
        {
            return "These are my projects"; 
        }
    }
}