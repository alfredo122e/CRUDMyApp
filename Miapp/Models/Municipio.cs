using System;
using System.ComponentModel.DataAnnotations;

namespace Miapp.Models
{
    public class Municipio
    {
        [Key]

        public int municipioID{get; set;}

        [Required(ErrorMessage="¡El nombre es requerido!")]
        [Display(Name="Nombre:")]
        public string nombre {get;set;}

        [Required(ErrorMessage="¡El dato de la población es requerido!")]
        [Display(Name="Población:")]
        public string poblacion {get;set;}

        [Required(ErrorMessage="¡El valor de la latitud es requerido!")]
        [Display(Name="Latitud:")]
        public string latitud {get;set;}

        [Required(ErrorMessage="¡El valor de la longitud es requerido!")]
        [Display(Name="Longitud:")]
        public string longitud {get;set;}
    }
}