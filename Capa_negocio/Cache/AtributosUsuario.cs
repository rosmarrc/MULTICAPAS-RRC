using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text;


namespace Capa_negocio.Cache
{
    public static class AtributosUsuario
    {
        public static int ID {  get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Nom_Ususario { get; set; }
        public static string Contrasenia { get; set; }
    }
}