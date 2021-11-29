using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace firstApp.Models
{ public class Telefono
    
        {
[Key]
public int TelefonoId{get; set;}

[Required(ErrorMessage ="Nombre es requerido")]
[Display(Name ="Nombre")]
public string  nombre {get; set;}

[Required(ErrorMessage ="Marca es requerido")]
[Display(Name ="Marca")]
public string Marca {get; set;}

[Required(ErrorMessage ="Color es requerido")]
[Display(Name ="Color")]
public string Color {get; set;}


[Required(ErrorMessage ="NombreTelefono es requerido")]
[Display(Name ="NombreTelefono")]
public int CreadorID{get; set;}
        public object Creadores { get; internal set; }
    }
}