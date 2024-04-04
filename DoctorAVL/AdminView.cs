using Npgsql;
using System;
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
        public AdminView(string usuario, string permisos)
        {
            InitializeComponent();
            Cargar_usuarios();
            this.FormClosing += AdminView_FormClosing;
        }
        private DataTable usuarioTable;
        private void Cargar_usuarios()
        {
            string query = "SELECT * FROM public.usuarios";
            try
            {
                using (var conexion = new NpgsqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (var cmd = new NpgsqlCommand(query, conexion))
                    {
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            usuarioTable = new DataTable();
                            adapter.Fill(usuarioTable);
                            dataUsers.DataSource = usuarioTable;
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Error de base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error no esperado: {ex.Message}");
            }
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
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show();
        }
    }
}
