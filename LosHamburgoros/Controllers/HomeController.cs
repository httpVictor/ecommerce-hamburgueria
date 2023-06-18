using LosHamburgoros.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LosHamburgoros.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Cardapio()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult MinhaConta()
        {
            //Se não tiver ninguem logado, direcionar para a tela de login

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}