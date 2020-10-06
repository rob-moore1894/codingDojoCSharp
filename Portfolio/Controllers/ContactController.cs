using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        [Route("contact")]

        public string Contact()
        {
            return "This is my Contact!"; 
        }
    }
}