using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CitaController1 : ApiController
    {
        // POST api/<controller>
        public bool Post([FromBody] AgendarCita oCita)
        {
            return CitaData.RegistrarCita(oCita);
        }
    }
}