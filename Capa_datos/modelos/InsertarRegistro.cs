using Capa_datos.Conexion;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using Capa_negocio.Cache;

namespace Capa_datos.modelos
{
    public class InsertarRegistro
    {
        conexionDB c = new conexionDB();
        SqlCommand cmd = new SqlCommand();

        public bool InsertarReg(string nombre, string apellido, string fechaNacimiento, string direccion, string genero, string estadoCivil, string movil, string telefono, string correoElectronico)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "INSERT INTO Agenda (Nombre, Apellido, FechaNacimiento, Direccion, Genero, EstadoCivil, Movil, Telefono, CorreoElectronico) VALUES (@Nombre, @Apellido, @FechaNacimiento, @Direccion, @Genero, @EstadoCivil, @Movil, @Telefono, @CorreoElectronico)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Apellido", apellido);
            cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@Genero", genero);
            cmd.Parameters.AddWithValue("@EstadoCivil", estadoCivil);
            cmd.Parameters.AddWithValue("@Movil", movil);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);

           
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