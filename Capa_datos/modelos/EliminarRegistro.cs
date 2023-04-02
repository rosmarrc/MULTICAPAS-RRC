using Capa_datos.Conexion;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace Capa_datos.modelos
{
    public class EliminarRegistro
    {
        conexionDB c = new conexionDB();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool EliminarReg(int id)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "DELETE FROM Agenda WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", id);


            int result = cmd.ExecuteNonQuery();

            if (result > 0)
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