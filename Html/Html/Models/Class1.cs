using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace Html.Models
{
    public class Class1
    {
        [Required]
        public int cedula { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [Range(15,50, ErrorMessage = "no tiene la edad requerida")]
        public int edad { get; set; }

       public int telefono { get; set; }
        [EmailAddress]
        public string correo {get; set;}

        public Genero genero { get; set; }
        public Est estado { get; set; }
        public  Ho hobbys { get; set; }
    }

    public enum Genero
    {
        masqulino,
        femenino
    }
    public enum Est
    {
        casado,
        soltero,
        unionlibre,
        viudo
    }
   
    public enum Ho
    {
        videojuegos,
        leer,
        dormir,
        programar

    }


}