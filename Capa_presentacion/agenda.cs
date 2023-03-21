using Capa_negocio.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class agenda : Form
    {
        public agenda()
        {
            InitializeComponent();
        }

        private void agenda_Load(object sender, EventArgs e)
        {
            lblwelcome.Text = $"Bienvenido: {AtributosUsuario.Nombre} {AtributosUsuario.Apellido}";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
