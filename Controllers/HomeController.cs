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
            string nome = "Giacomo";
            string cognome = "Leopoldi";
            ViewBag.nome = nome;
            ViewBag.cognome = cognome;

            int sommaNumeri(int numeroFinale)
            {               
                int somma = 0;
                while (numeroFinale > 0) { somma += numeroFinale; numeroFinale = numeroFinale - 1; };
                return somma;
            }

            int numeroMassimo = 10;
            ViewBag.numeroMassimo = numeroMassimo;  
            ViewBag.sommaDiNumeri = sommaNumeri(numeroMassimo);
         
            int numeroDiCaratteri(string frase, string carattere)
            {
                return frase.Length - frase.Replace(carattere, "").Length;
            }

            string frase = "Nel mezzo del cammin di nostra vita";
            ViewBag.frase = frase;
            ViewBag.numeroDiCarattereNellaFrase = numeroDiCaratteri(frase, "a");

            List<int> listaDiInteri = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                Random r = new Random();
                int randomInt = r.Next(1, 90);
                if(randomInt > 20 && randomInt < 70)
                {
                    listaDiInteri.Add(randomInt);
                }
            }

            ViewBag.listaDiInteri = listaDiInteri;

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