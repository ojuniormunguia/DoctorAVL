using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace DoctorAVL
{
    public partial class Pacientes : Form
    {
        private string cadenaConexion = "Server=hansken.db.elephantsql.com;Port=5432;Database=ikegunyj;User Id=ikegunyj;Password=PjDjGMbve9rwF5eP4fMGm5M59yzCpExq;";
        private string usuario;
        private string permisos;

        public Pacientes(string usuarios, string permiso)
        {
            usuario = usuarios;
            permisos = permiso;
            InitializeComponent();

            LoadPacientesData(); // Call the method to load data on form load
            this.FormClosing += Pacientes_FormClosing;
        }

        public void LoadPacientesData()
        {
            using (var conn = new NpgsqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT * FROM \"public\".\"pacientes\""; // Query to fetch data
                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt); // Fill DataTable with data
                    dataPacientes.DataSource = dt; // Bind DataTable to DataGridView
                }
            }
        }

        private void Pacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Ensure the application exits when form closes
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AdminView adminView = new AdminView(usuario, permisos);
            this.Hide();
            adminView.Show();
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            AgregarPaciente agregarPaciente = new AgregarPaciente(this, "", "", "", "", "");
            agregarPaciente.Show();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            ArbolView arbolView = new ArbolView(usuario, permisos);
            this.Hide();
            arbolView.Show();
        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
            if (dataPacientes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataPacientes.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataPacientes.Rows[selectedRowIndex];

                string pacienteId = selectedRow.Cells["pacienteid"].Value.ToString();
                string nombre = selectedRow.Cells["nombre"].Value.ToString();
                string genero = selectedRow.Cells["genero"].Value.ToString();
                string tipoSangre = selectedRow.Cells["tiposangre"].Value.ToString();
                string presionArterial = selectedRow.Cells["presionarterial"].Value.ToString();
                string doctor = selectedRow.Cells["doctor"].Value.ToString();

                AgregarPaciente agregarPaciente = new AgregarPaciente(this, nombre, tipoSangre, presionArterial, genero, doctor);
                agregarPaciente.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para editar.");
            }
        }

        private void btnBorrarP_Click(object sender, EventArgs e)
        {
            if (dataPacientes.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataPacientes.SelectedRows[0].Index;
                int pacienteId = Convert.ToInt32(dataPacientes.Rows[selectedRowIndex].Cells["pacienteid"].Value);

                using (var conn = new NpgsqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string query = "DELETE FROM \"public\".\"pacientes\" WHERE pacienteid = @pacienteId;";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pacienteId", pacienteId);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Paciente eliminado correctamente.");
                            LoadPacientesData(); // Reload data to reflect the deletion
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el paciente.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para eliminar.");
            }
        }
    }
}
