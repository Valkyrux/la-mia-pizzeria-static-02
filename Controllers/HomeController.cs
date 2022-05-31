using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Pizzeria pizzeria = new Pizzeria("Pizza Pazza");
            pizzeria.addPizza(new Pizza("Capricciosa", "Pizza molto buona, per tutti con funghi e altro", "capricciosa.jpg", 10.50));
            pizzeria.addPizza(new Pizza("4 formaggi", "Pizza molto buona, per tutti con 4 formaggi", "4form.webp", 7.80));
            pizzeria.addPizza(new Pizza("Diavola", "Pizza molto buona, piccante", "d1.jpg", 15.00));
            pizzeria.addPizza(new Pizza("Margherita", "La più semplice tra le pizze", "margh.jpg", 13.05));
            ViewData["nomePizzeria"] = pizzeria.Nome;
            ViewData["listaPizze"] = pizzeria.listaPizze;
            return View();
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