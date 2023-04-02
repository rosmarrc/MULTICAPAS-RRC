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
using Capa_datos.modelos;
using System.Data.SqlClient;

namespace Capa_presentacion
{
    public partial class agenda : Form
    {
        public agenda()
        {
            InitializeComponent();

        }

        private void MostrarRegistros()
        {
            string connectionString = "Data Source=.;Initial Catalog=capadedatos;Integrated Security=True";
            string query = "SELECT * FROM Agenda";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvRegistros.DataSource = dataTable;
                }
            }
        }

        private void agenda_Load(object sender, EventArgs e)
        {
          
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarRegistros();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string fechaNacimiento = dtpFechaNacimiento.Value.ToString();
            string direccion = txtDireccion.Text;
            string genero = cmbGenero.SelectedItem.ToString();
            string estadoCivil = cmbEstadoCivil.SelectedItem.ToString();
            string movil = txtMovil.Text;
            string telefono = txtTelefono.Text;
            string correoElectronico = txtCorreoElectronico.Text;

            InsertarRegistro insertarRegistro = new InsertarRegistro();
            bool resultado = insertarRegistro.InsertarReg(nombre, apellido, fechaNacimiento, direccion, genero, estadoCivil, movil, telefono, correoElectronico);
            if (resultado)
            {
                MessageBox.Show("El registro se ha insertado correctamente.");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar insertar el registro.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            string connectionString = "Data Source=.;Initial Catalog=capadedatos;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Agenda WHERE Id=@Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtNombre.Text = reader["Nombre"].ToString();
                            txtApellido.Text = reader["Apellido"].ToString();
                            dtpFechaNacimiento.Value = Convert.ToDateTime(reader["FechaNacimiento"]);
                            txtDireccion.Text = reader["Direccion"].ToString();
                            cmbGenero.SelectedItem = reader["Genero"].ToString();
                            cmbEstadoCivil.SelectedItem = reader["EstadoCivil"].ToString();
                            txtMovil.Text = reader["Movil"].ToString();
                            txtTelefono.Text = reader["Telefono"].ToString();
                            txtCorreoElectronico.Text = reader["CorreoElectronico"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro con el Id especificado.");
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string fechaNacimiento = dtpFechaNacimiento.Value.ToString();
            string direccion = txtDireccion.Text;
            string genero = cmbGenero.SelectedItem.ToString();
            string estadoCivil = cmbEstadoCivil.SelectedItem.ToString();
            string movil = txtMovil.Text;
            string telefono = txtTelefono.Text;
            string correoElectronico = txtCorreoElectronico.Text;

            ModificarRegistro modificarRegistro = new ModificarRegistro();
            bool resultado2 = modificarRegistro.ModificarReg(id, nombre, apellido, fechaNacimiento, direccion, genero, estadoCivil, movil, telefono, correoElectronico);
            if(!resultado2)
            {
                MessageBox.Show("Registro modificado correctamente.");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al modificar el registro.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
           

            EliminarRegistro eliminarRegistro = new EliminarRegistro();
            bool resultado3 = eliminarRegistro.EliminarReg(id);
            if(resultado3)
            {
                MessageBox.Show("El registro ha sido eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró ningún registro con el Id especificado.");
            }
        }
    }
}
