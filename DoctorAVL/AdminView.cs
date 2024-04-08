using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DoctorAVL
{
    public partial class AdminView : Form
    {
        string cadenaConexion = "Server=hansken.db.elephantsql.com;Port=5432;Database=ikegunyj;User Id=ikegunyj;Password=PjDjGMbve9rwF5eP4fMGm5M59yzCpExq;";

        private string usuario;
        private string permisos;
        public AdminView(string usuarios, string permiso)
        {
            usuario = usuarios;
            permisos = permiso;
            InitializeComponent();
            Cargar_usuarios();
            this.FormClosing += AdminView_FormClosing;
        }
        private DataTable usuarioTable;
        public void Cargar_usuarios()
        {
            string query = "SELECT nombre, usuario, contraseña, permisos FROM public.usuarios";
            try
            {
                using (var conexion = new NpgsqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (var cmd = new NpgsqlCommand(query, conexion))
                    {
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable usuarioTable = new DataTable();
                            adapter.Fill(usuarioTable);
                            dataUsers.DataSource = usuarioTable;
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Error de base de datos: {ex.Message}");
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error no esperado: {ex.Message}");
                MessageBox.Show($"Error no esperado: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FilterUsuarios()
        {
            DataTable usuarioTable = (DataTable)dataUsers.DataSource;

            if (usuarioTable != null)
            {
                DataView view = new DataView(usuarioTable);
                string filterCondition = $"nombre LIKE '%{txtBusqueda.Text.Replace("'", "''")}%'";

                view.RowFilter = filterCondition;
                dataUsers.DataSource = view;

                txtBusqueda.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusqueda.Text))
            {
                FilterUsuarios();
            }
            else { Cargar_usuarios(); }
        }


        private void AdminView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (usuarioTable != null)
            {
                string filter = txtBusqueda.Text.Trim();
                if (!string.IsNullOrEmpty(filter))
                {
                    usuarioTable.DefaultView.RowFilter = $"nombre LIKE '%{filter}%'";
                }
                else
                {
                    usuarioTable.DefaultView.RowFilter = string.Empty;
                }

                dataUsers.DataSource = usuarioTable.DefaultView;
            }
        }

        private void btnAgregarP_Click_1(object sender, EventArgs e)
        {

            AgregarUsuario agregarUsuario = new AgregarUsuario(this, "", "", "", "");
            agregarUsuario.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataUsers.SelectedCells.Count > 0)
            {
                int indexFilaSeleccionada = dataUsers.SelectedCells[0].RowIndex;
                DataGridViewRow filaSeleccionada = dataUsers.Rows[indexFilaSeleccionada];

                string identificador = Convert.ToString(filaSeleccionada.Cells[0].Value);

                BorrarUsuario(identificador);
            }
        }

        private void BorrarUsuario(string identificador)
        {
            string queryBorrar = "DELETE FROM public.usuarios WHERE nombre = @identificador";
            try
            {
                using (var conexion = new NpgsqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (var cmd = new NpgsqlCommand(queryBorrar, conexion))
                    {
                        cmd.Parameters.AddWithValue("@identificador", identificador);

                        cmd.ExecuteNonQuery();
                        Cargar_usuarios();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Error de base de datos: {ex.Message}");
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error no esperado: {ex.Message}");
                MessageBox.Show($"Error no esperado: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv != null)
                {
                    string nombre = dgv.Rows[e.RowIndex].Cells["nombreColumnName"].Value.ToString();
                    string usuario = dgv.Rows[e.RowIndex].Cells["usuarioColumnName"].Value.ToString();
                    string contraseña = dgv.Rows[e.RowIndex].Cells["contraseñaColumnName"].Value.ToString();
                    string permisos = dgv.Rows[e.RowIndex].Cells["permisosColumnName"].Value.ToString();

                    // Open the AgregarUsuario form with the selected row's data
                    AgregarUsuario agregarUsuario = new AgregarUsuario(this, nombre, usuario, contraseña, permisos); // Assuming constructor is modified to accept these parameters
                    agregarUsuario.Show();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataUsers.SelectedCells.Count > 0)
            {
                int indexFilaSeleccionada = dataUsers.SelectedCells[0].RowIndex;
                DataGridViewRow filaSeleccionada = dataUsers.Rows[indexFilaSeleccionada];

                string nombreEditar = Convert.ToString(filaSeleccionada.Cells[0].Value);
                string usuarioEditar = Convert.ToString(filaSeleccionada.Cells[1].Value);
                string contrasenaEditar = Convert.ToString(filaSeleccionada.Cells[2].Value);
                string permisosEditar = Convert.ToString(filaSeleccionada.Cells[3].Value);

                AgregarUsuario agregarUsuario = new AgregarUsuario(this, nombreEditar, usuarioEditar, contrasenaEditar, permisosEditar);
                agregarUsuario.Show();
            }
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = new Pacientes(usuario, permisos);
            this.Hide();
            pacientes.Show();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            ArbolView arbolView = new ArbolView(usuario, permisos);
            this.Hide();
            arbolView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            this.Hide();
            iniciarSesion.Show();
        }
    }
}
