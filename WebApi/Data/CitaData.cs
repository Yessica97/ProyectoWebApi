using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Data
{
    public class CitaData
    {
        public static bool RegistrarCita(AgendarCita oCita)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.CitaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_registrar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", oCita.Nombre);
                cmd.Parameters.AddWithValue("@NumeroDocumento", oCita.NumeroDocumento);
                cmd.Parameters.AddWithValue("@FechaNacimiento", oCita.FechaCita);
                cmd.Parameters.AddWithValue("@telefono", oCita.Telefono);
                cmd.Parameters.AddWithValue("@Tratamiento", oCita.Procedimiento);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }
}