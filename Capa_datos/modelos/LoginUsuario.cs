using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Capa_negocio.Cache;
using Capa_datos.Conexion;

namespace Capa_datos.modelos
{
    public class LoginUsuario
    {
        conexionDB c = new conexionDB();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool Login(string usuario, string contrasenia)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "SELECT * FROM Usuarios WHERE Nom_Usuario = @usuario AND Contrasenia = @Contrasenia";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contrasenia", contrasenia);
            dr = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    AtributosUsuario.ID = dr.GetInt32(0);
                    AtributosUsuario.Nombre = dr.GetString(1);
                    AtributosUsuario.Apellido = dr.GetString(2);
                    AtributosUsuario.Nom_Ususario = dr.GetString(3);
                    AtributosUsuario.Contrasenia = dr.GetString(4);
                }
                cmd.Connection = c.CloseConnection();
                return true;
            }
            else cmd.Connection = c.CloseConnection();
            return false;
        }
    }
}