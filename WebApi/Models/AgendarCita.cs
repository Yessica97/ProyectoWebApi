using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class AgendarCita
    {
        public int IdAgendarCita { get; set; }
        public string Nombre { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCita { get; set; }
        public string Procedimiento { get; set; }
    }
}