using Microsoft.AspNetCore.Mvc;
using System.Web.Helpers;
using PortafolioWeb.Services;
using Org.BouncyCastle.Asn1.Ocsp;
using PortafolioWeb.Models;

namespace PortafolioWeb.Controllers
{
    public class CorreoController : Controller
    {
        private readonly IEmailService _emailService;
        public CorreoController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpGet]
        public IActionResult SendEmail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendEmail(EmailDTO request)
        {
            _emailService.SendEmail(request);
            ViewBag.msg = "El correo se envió correctamente, Gracias!";
            return View();
        }
    }
}
