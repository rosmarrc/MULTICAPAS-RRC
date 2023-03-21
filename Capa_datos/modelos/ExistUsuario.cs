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
using Capa_datos.Conexion;

namespace Capa_datos.modelos
{
    public class ExistUsuario
    {
        conexionDB c = new conexionDB();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        public bool ValidarUsuario(string usuario)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "SELECT * FROM Usuarios WHERE Nom_Usuario = @Usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@usuario", usuario);
            dr = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            if (dr.HasRows)
            {
                cmd.Connection = c.CloseConnection();
                return true;
            }
            else
            {
                cmd.Connection = c.CloseConnection();
                return false;
            }
        }
    }
}