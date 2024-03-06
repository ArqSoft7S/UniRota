using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class RegisterController : Controller
    {

        private readonly ApplicationDbContext _context; 

        public RegisterController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("Register");
        }

        public async Task<IActionResult> RegistrarUsuario()
        {
            return View("~/Views/Login/Login.cshtml");
        }
    }
}
