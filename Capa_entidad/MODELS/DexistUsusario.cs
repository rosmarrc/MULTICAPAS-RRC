using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text;
using Capa_datos.modelos;

namespace Capa_entidad.MODELS
{
    public class DexistUsusario
    {
        ExistUsuario exist = new ExistUsuario();
        public bool ValidarUsuario(string usuario)
        {
            return exist.ValidarUsuario(usuario);
        }
    }
}