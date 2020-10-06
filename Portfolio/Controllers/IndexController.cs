using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet]
        [Route("")]

        public ViewResult Index()
        {
            return View();
        }
    }
}