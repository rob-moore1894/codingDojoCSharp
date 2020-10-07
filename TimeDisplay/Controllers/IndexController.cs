using Microsoft.AspNetCore.Mvc;
using System; 

namespace TimeDisplay.Controllers
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