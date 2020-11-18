using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View(new AddUserViewModel());
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Username = newUser.Username,
                    Email = newUser.Email,
                    Password = newUser.Password,
                    PreferredService = newUser.PreferredService
                };

                return View("Index", user);
            }

            return View("Add", newUser);
        }
    }
}
