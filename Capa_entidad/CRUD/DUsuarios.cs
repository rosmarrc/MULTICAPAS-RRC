using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text;
using Capa_negocio.Atributos;
using Capa_datos.Entidades;

namespace Capa_entidad.CRUD
{
    public class DUsuarios
    {
        Usuarios usuarios = new Usuarios();

        public void CrarUsuario(AtributosUsuariosDB obj)
        {
            usuarios.CrearUsuario(obj);
        }
    }
}