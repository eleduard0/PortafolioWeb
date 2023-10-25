using Microsoft.AspNetCore.Mvc;
using PortafolioWeb.Datos;
using PortafolioWeb.Models;

namespace PortafolioWeb.Controllers
{
    public class TecnologiasController : Controller
    {
        TecnologiasDatos tecnologiasDatos = new TecnologiasDatos();
        public IActionResult Listar()
        {
            var lista = tecnologiasDatos.Listar();
            return View(lista);

        }
    }
}
