using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Miapp.Models;

namespace Miapp.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Persona personal=new Persona();
            personal.nombre="David";
            personal.apellido="Chicas";
            personal.edad=19;
            personal.correo="isaacdavid959@gmail.com";
            personal.telefono="7280-9747";
            personal.direccion="San Francisco Gotera, Morazan";

            return View(personal);
        }
    }
}