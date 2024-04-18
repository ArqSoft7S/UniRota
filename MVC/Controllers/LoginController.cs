using Microsoft.AspNetCore.Mvc;
using MVC.Data;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {

        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult LogarUsuario(string InputEmail, string InputPassword)
        {
            var user = _context.Usuarios.Where(w => w.Email == InputEmail && w.Senha == InputPassword).FirstOrDefault();
            if (user is not null)
            {
                return View("~/Views/Home/Index.cshtml");
            }
            return View("Login");
        }
    }
}
