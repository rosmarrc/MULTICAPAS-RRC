using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Capa_datos.Conexion;
using Capa_negocio.Atributos;

namespace Capa_datos.Entidades
{
    public class Usuarios
    {
        conexionDB c = new conexionDB();
        SqlCommand cmd = new SqlCommand();

        public void CrearUsuario(AtributosUsuariosDB obj)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_CrearUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre1);
                cmd.Parameters.AddWithValue("@Apellido", obj.Apellido1);
                cmd.Parameters.AddWithValue("@Nom_Usuario", obj.Nom_Usuario1);
                cmd.Parameters.AddWithValue("@Contrasenia", obj.Contrasenia1);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch(Exception ex) {
            string msj = ex.ToString();
            }
            finally { 
            cmd.Connection = c.CloseConnection();
            }
        }
    }
}