using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace CoffeeShopRegistration.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CoffeeShopRegistration.Models; // Replace with your actual model namespace
    using Microsoft.AspNetCore.Mvc.ViewEngines;
   
    public class RegistrationController : Controller
    {
        // Display the registration form
        public IActionResult ShowRegistrationForm()
        {
            return View("views/home/Registration.cshtml");
        }

        // Process user registration
        [HttpPost]
        public IActionResult User()
        {
            User a = new User()
            {
                fname = "Test",
                lname = "Test",
                email = "Test",
                pass = "Test",
            }
        }

        public IActionResult Register(string fname, string lname, string email, string pass)
        {
           

            if (ModelState.IsValid)
            {
                // Process user registration here
                // You can save user data, perform validation, etc.

                // Assuming you have a UserRegistrationModel for the form fields
                // This model should match the form fields in your Registration.cshtml view

               

                // Redirect to the result page and pass the user's first name
                return View("/views/home/Result.cshtml", User);
            }
            else
            {
                // If there are validation errors, return to the registration form
                return View("/views/home/Registration.cshtml",User);
            }
        }
    }
}



