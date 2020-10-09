using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Message mess = new Message()
            {
                Stuff = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Optio dolorem aut dolorum! Officia illo suscipit quod blanditiis reiciendis nam saepe laborum repellat architecto in, rem dolores hic sapiente ipsam consequatur?"
            };

            return View(mess);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            Integers num1 = new Integers()
            {
                Digit = 1, 
            };
            return View(num1);
        }
        

        [HttpGet("user")]
        public IActionResult User()
        {
            User newUser = new User()
            {
                Name = "Moose Phillips"
            };
            return View(newUser);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User user1 = new User()
            { Name = "Moose Phillips"};
            User user2 = new User()
            { Name = "Sarah"};
            User user3 = new User()
            { Name = "Jerry"};
            User user4 = new User()
            { Name = "Rene Ricky"};
            User user5 = new User()
            { Name = "Barbarah"};

            List<User> userModel = new List<User>()
            {
                user1, user2, user3, user4, user5
            };

            return View(userModel); 
        }
    }
}
