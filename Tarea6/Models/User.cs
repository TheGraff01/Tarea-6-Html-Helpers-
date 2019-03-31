using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tarea6.Models
{
    public class User
    {
        [DisplayName("Cédula:")]
        [Required]
        public int Cedula { get; set; }

        [DisplayName("Nombre:")]
        [Required]
        public string Nombre { get; set; }

        [DisplayName("Apellido:")]
        [Required]
        public string Apellido { get; set; }

        [DisplayName("Edad:")]
        [Range(15, 120)]
        public int Edad { get; set; }

        [DisplayName("Teléfono:")]
        public int Telefono { get; set; }

        [DisplayName("Correo Electrónico:")]
        [EmailAddress]
        public string Correo { get; set; }

        [DisplayName("Género:")]
        public string Genero { get; set; }

        [DisplayName("Estado Civil:")]
        public string EstadoCivil { get; set; }

        [DisplayName("Hobbys:")]
        public string[] Hobbys { get; set; }



    }
}