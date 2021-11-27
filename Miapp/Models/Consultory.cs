using System;
using System.ComponentModel.DataAnnotations;

namespace Miapp.Models
{
    public class Consultory
    {
        [Key]

        public int IDPaciente{get; set;}

        [Required(ErrorMessage="¡El nombre es requerido!")]
        [Display(Name="Nombre:")]
        public string nombre {get;set;}

        [Required(ErrorMessage="¡El dato de la población es requerido!")]
        [Display(Name="Enfermedad:")]
        public string Enfermedad {get;set;}

        [Required(ErrorMessage="¡El valor de la latitud es requerido!")]
        [Display(Name="Medicina:")]
        public string Medicina {get;set;}

        
        
    }
}