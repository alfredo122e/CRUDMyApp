using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstApp.Models;

namespace firstApp.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.Nombres = "Saul Oswaldo ";
            personal.Apellidos = "Lopez Hernandez";
            personal.Edad = 20;
            personal.CorreoElectronico = "saul1xyz@gmail.com ";
            personal.Telefono = 77777777;
            personal.Direccion = " SanMiguel ";
            
            return View(personal);
        }
    }
}