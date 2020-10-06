using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet]
        [Route("")]

        public string Index()
        {
            return "This is my Index!"; 
        }
    }
}