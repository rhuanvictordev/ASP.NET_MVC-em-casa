using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_MVC.Models;

namespace Projeto_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeModel model = new HomeModel();
            model.Nome = "Rhuan Victor";
            model.Email = "rhuan@email.com";
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
