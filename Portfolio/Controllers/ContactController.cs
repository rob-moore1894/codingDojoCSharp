using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        [Route("contact")]

        public ViewResult Contact()
        {
            return View(); 
        }
    }
}