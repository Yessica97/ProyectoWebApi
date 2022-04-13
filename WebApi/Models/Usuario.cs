using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public string Ocupacion { get; set; }
        public string NivelEscolaridad { get; set; }
        public string Correo { get; set; }
        public string EPS { get; set; }
        public string Telefono { get; set; }
        public string Tratamiento { get; set; }
    }
}