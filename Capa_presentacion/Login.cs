using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_entidad.MODELS;

namespace Capa_presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
            registro.FormClosed += CloseForm;

        }

        private void CloseForm(object sender, FormClosedEventArgs e) { 
         this.Show();
            txtusuario.Focus();
            txtusuario.Text = "";
            txtclave.Text = "";
        
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text != "")
            {
                if(txtclave.Text != "")
                {
                    DloginUsuario usuariomodelo = new DloginUsuario();
                    var validar = usuariomodelo.Login(txtusuario.Text, txtclave.Text);
                    if (validar)
                    {
                        this.Hide();
                        agenda agenda = new agenda();
                        agenda.Show();
                        agenda.FormClosed += CloseForm;
                    } else MessageBox.Show("Datos Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }else MessageBox.Show("Contraseña Incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else MessageBox.Show("Usuario incorrecto!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
