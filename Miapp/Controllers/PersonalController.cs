using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using primeraAplicacion.Models;

namespace primeraAplicacion.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Persona personal=new Persona();
            personal.nombre="Edwin";
            personal.apellido="Ulloa";
            personal.edad=24;
            personal.correo="adonyulloa@gmail.com";
            personal.telefono="7721-9272";
            personal.direccion="San Miguel, san Miguel";

            return View(personal);
        }
    }
}