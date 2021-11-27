using System;
using System.ComponentModel.DataAnnotations;

namespace primeraAplicacion.Models
{
    public class Perro
    {   
        //definir propiedades
        [Key]
        public int perroID{get; set;}

        [Required(ErrorMessage="name is requiered")]
        [Display(Name="name")]
        public string nama {get; set;}
        [Required(ErrorMessage="raza is requiered")]
        [Display(Name="raza")]
        public string raza {get; set;}
        [Required(ErrorMessage="age is requiered")]
        [Display(Name="age")]
        public int age {get; set;}
        [Required(ErrorMessage="vaccine is requiered")]
        [Display(Name="vaccine")]
        public string vaccine {get; set;}
        [Required(ErrorMessage="ownerName is requiered")]
        [Display(Name="ownerName")]
        public string ownerName {get; set;}
        [Required(ErrorMessage="telephone is requiered")]
        [Display(Name="telephone")]
        public string telephone {get; set;}

        //referencia para Owner
        [Required(ErrorMessage="Owner is requiered")]
        [Display(Name="Owner")]
        public int OwnerID {get; set;}
        public Owner Owner {get; set;}


        

    }
}