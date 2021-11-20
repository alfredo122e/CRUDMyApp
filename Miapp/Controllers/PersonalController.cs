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
            personal.nombre="Alfredo";
            personal.apellido="Lainez";
            personal.edad=18;
            personal.correo="Zelayalainea@gmail.com";
            personal.telefono="7689-3468";
            personal.direccion="Berlín, Usulután";

            return View(personal);
        }
    }
}