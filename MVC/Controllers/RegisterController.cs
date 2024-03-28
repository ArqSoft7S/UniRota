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

        [HttpPost]
        public IActionResult RegistrarUsuario(string InputEmail, string InputPassword, string InputPasswordConfirm,
            string InputCellPhone, string InputCep, string InputRua, string InputNumber, string InputComplement,
            string inputNeighborhood, bool Check)
        {
            if(!Check)
            {
                ViewBag.ErrorMessage = "É necessário concordar com os termos de uso para se cadastrar no sistema.";
                return View("Register");
            }
            
            if (_context.Usuarios.Where(w => w.Email == InputEmail).Any()){
                ViewBag.ErrorMessage = "Email já cadastrado. Por favor utilize um email válido.";
                return View("Register");
            }

            if (!String.Equals(InputPassword, InputPasswordConfirm))
            {
                ViewBag.ErrorMessage = "Senhas incorretas, por favor verifique se elas são iguais.";
                return View("Register");
            }

            _context.Usuarios.Add(new UsuarioModel
            {
                Email = InputEmail,
                Senha = InputPassword,
                NumeroCelular = InputCellPhone,
                CEP = InputCep,
                Rua = InputRua,
                Numero = int.Parse(InputNumber),
                Complemento = InputComplement,
                Bairro = inputNeighborhood
            });
            _context.SaveChanges();
            return View("~/Views/Login/Login.cshtml");

        }
    }
}
