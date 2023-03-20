using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;


namespace CapaNegocio
{
    public class N_usuarios
    {
        D_usuarios objeto = new D_usuarios();

        public DataTable N_listado()
        {
            return objeto.D_listado();
        }

        public bool N_AutenticarUsuario(string nombreUsuario, string contrasena)
        {
            E_usuario usuario = objeto.D_BuscarUsuarioPorNombre(nombreUsuario);
            if (usuario != null)
            {
                if (usuario.Contrasena == contrasena)
                {
                    // La autenticación es exitosa
                    return true;
                }
            }
            // La autenticación falló
            return false;
        }

        public E_usuario N_BuscarUsuarioPorNombre(string nombreUsuario)
        {
            return objeto.D_BuscarUsuarioPorNombre(nombreUsuario);
        }
    }
}