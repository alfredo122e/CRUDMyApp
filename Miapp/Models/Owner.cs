using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace primeraAplicacion.Models
{
    public class Owner
    {   
        //definir propiedades 
        [Key]
        public int OwnerID {get; set;}
        [Required(ErrorMessage="Firname is requiered")]
        [Display(Name="Fisrname")]
         public string firsName {get; set;}
         [Required(ErrorMessage="LastName is requiered")]
         [Display(Name="Lastname")]
         
         public string lastName {get; set;}
         [Required(ErrorMessage="Email is requiered")]
         [DataType(DataType.EmailAddress)]
         [Display(Name="Email",Prompt ="email@domain.com")]
         public string email {get; set;}
         [Required(ErrorMessage="gender is requiered")]
         [Display(Name="Gender")]
         public string gender {get; set;}
         [Required(ErrorMessage="address is requiered")]
         [Display(Name="Address")]
         [StringLength(150)]
         public string address {get; set;}


         public ICollection<Perro> Perros {get; set;} = new List<Perro>();
         
    }
}