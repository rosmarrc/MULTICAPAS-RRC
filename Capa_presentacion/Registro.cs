using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_entidad.CRUD;
using Capa_entidad.MODELS;
using Capa_negocio.Atributos;

namespace Capa_presentacion
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        DUsuarios usuarios = new DUsuarios();
        AtributosUsuariosDB atributos = new AtributosUsuariosDB();
        DexistUsusario existUsuario = new DexistUsusario();

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txtapellidoREG.Text == "" || txtnombreREG.Text == "" || txtusuarioREG.Text == "" || txtCONT.Text == "")
            {
                MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                atributos.Nombre1 = txtnombreREG.Text;
                atributos.Apellido1 = txtapellidoREG.Text;
                atributos.Nom_Usuario1 = txtusuarioREG.Text;
                atributos.Contrasenia1 = txtCONT.Text;
                var exist = existUsuario.ValidarUsuario(txtusuarioREG.Text);
                if (exist) MessageBox.Show("Este usuario esta en uso!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    usuarios.CrarUsuario(atributos);
                    MessageBox.Show("Este usuario se registro exitosamente!", "REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnombreREG.Text = "";
                    txtapellidoREG.Text = "";
                    txtusuarioREG.Text = "";
                    txtCONT.Text = "";
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ATRAS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
