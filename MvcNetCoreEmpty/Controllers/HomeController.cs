using Microsoft.AspNetCore.Mvc;
using MvcNetCoreEmpty.Models;

namespace MvcNetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contenido()
        {
            return View();
        }

        public IActionResult VistaPersona()
        {
            Persona persona=new Persona();
            persona.Email = "cj@gmail.com";
            persona.Edad = 52;
            persona.Nombre = "Cristopher";
            return View(persona);
        }
    }
}
