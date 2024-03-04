using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("Register");
        }
    }
}
