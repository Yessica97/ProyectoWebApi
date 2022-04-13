using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Data
{
    public class UsuarioData
    {
        public static bool Registrar(Usuario oUsuario)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_registrar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", oUsuario.Nombres);
                cmd.Parameters.AddWithValue("@TipoIdentificacion", oUsuario.TipoIdentificacion);
                cmd.Parameters.AddWithValue("@NumeroDocumento", oUsuario.NumeroDocumento);
                cmd.Parameters.AddWithValue("@FechaNacimiento", oUsuario.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Genero", oUsuario.Genero);
                cmd.Parameters.AddWithValue("@EstadoCivil", oUsuario.EstadoCivil);
                cmd.Parameters.AddWithValue("@Direccion", oUsuario.Direccion);
                cmd.Parameters.AddWithValue("@Ocipacion", oUsuario.Ocupacion);
                cmd.Parameters.AddWithValue("@NivelEscolaridad", oUsuario.NivelEscolaridad);
                cmd.Parameters.AddWithValue("@correo", oUsuario.Correo);
                cmd.Parameters.AddWithValue("@EPS", oUsuario.EPS);
                cmd.Parameters.AddWithValue("@telefono", oUsuario.Telefono);
                cmd.Parameters.AddWithValue("@Tratamiento", oUsuario.Tratamiento);

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