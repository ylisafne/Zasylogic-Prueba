using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using Zasylogic_Prueba.Models;

namespace Zasylogic_Prueba.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Formulario> lst = new List<Formulario>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            lst.Add(new Formulario()
            {
                Nombre = "Erick",
                Apellido = "Silverio",
                Celular = "923401513",
                Email = "ylisafne@live.com",
                Sexo = "Hombre",
                Motivo = "Incidencia",
                FechaAlta = DateTime.Now
            });

            return View(lst);
        }

        public IActionResult Create()
        {
            
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