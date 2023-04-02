using Capa_datos.Conexion;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace Capa_datos.modelos
{
    public class ModificarRegistro
    {
        conexionDB c = new conexionDB();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool ModificarReg(int id, string nombre, string apellido, string fechaNacimiento, string direccion, string genero, string estadoCivil, string movil, string telefono, string correoElectronico)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "UPDATE Agenda SET Nombre=@Nombre, Apellido=@Apellido, FechaNacimiento=@FechaNacimiento, Direccion=@Direccion, Genero=@Genero, EstadoCivil=@EstadoCivil, Movil=@Movil, Telefono=@Telefono, CorreoElectronico=@CorreoElectronico WHERE Id=@Id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Apellido", apellido);
            cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@Genero", genero);
            cmd.Parameters.AddWithValue("@EstadoCivil", estadoCivil);
            cmd.Parameters.AddWithValue("@Movil", movil);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
            dr = cmd.ExecuteReader();

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