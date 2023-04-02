using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocio.Atributos
{
    public class AtributosUsuariosDB
    {
        private string Nombre;
        private string Apellido;
        private string Nom_Usuario;
        private string Contrasenia;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Nom_Usuario1 { get => Nom_Usuario; set => Nom_Usuario = value; }
        public string Contrasenia1 { get => Contrasenia; set => Contrasenia = value; }
    }
}
