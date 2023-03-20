using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Configuration;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class D_Usuarios
    {
        SqlConnection conn =
            new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        public bool Autenticar(string usuario, string contrasena)
        {
            SqlCommand cmd = new SqlCommand("sp_autenticar_usuario", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contrasena", contrasena);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return (count == 1);
        }
    }
}