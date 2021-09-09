using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Devbuild_LAB_9._2.Models;

namespace Devbuild_LAB_9._2.Controllers
{
    public class Mortgage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPage()
        {
            ViewData["FirstName"] = "Ella";
            ViewData["LastName"] = "Clooney";
            return View();
           
        }

        public IActionResult SignUpForm()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Thankyou(User user)
        {
            if (user.FirstName == null)
            {
                return null;
            }
            else
            {
                return View(user);
            }
            
        }

    }
}
