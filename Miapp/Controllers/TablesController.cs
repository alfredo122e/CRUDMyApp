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
    public class  TablesController : Controller
    {
        public IActionResult Tables()
        {
            return View();
        }
        
    }  
    
}