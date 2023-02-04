using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using Zasylogic_Prueba.Models;

namespace Zasylogic_Prueba.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            List<Formulario> lst = new List<Formulario>();



            lst.Add(new Formulario() {Nombre ="Erick", Apellido = "Silverio", Celular="923401513", 
                Email = "ylisafne@live.com", Sexo = "Hombre", Motivo="Incidencia", FechaAlta= DateTime.Now });

            return View(lst);
        }
    }
}
