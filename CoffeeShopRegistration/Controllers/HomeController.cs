using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopRegistration.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(UserModel user)
        {
            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Registration()
        {            
            return View();
        }

    }
}