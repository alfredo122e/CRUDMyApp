using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace firstApp.Models
{ public class Creador
    {
// definir propiedades

[Key]
public int creadorId{get; set;}

[Required(ErrorMessage ="Nombre es requerido")]
[Display(Name ="Nombre")]
public string Nombre {get; set;}

[Required(ErrorMessage ="Apellido es requerido")]
[Display(Name ="Apellido")]
public string Apellido {get; set;}

[Required(ErrorMessage ="Correo es requerido")]
[DataType(DataType.EmailAddress)]
[Display(Name ="Correo",  Prompt ="email@domain.com")]

public string Correo {get; set;}

[Required(ErrorMessage ="Genero es requerido")]
[Display(Name ="Genero")]
public string Genero {get; set;}


[StringLength(100)]
public string Direccion{get; set;}

public ICollection<Telefono> Telefonos {get; set;} = new List<Telefono>();

    }
}
