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

namespace DoctorAVL
{
    public partial class AgregarPaciente : Form
    {
        private string cadenaConexion = "Server=hansken.db.elephantsql.com;Port=5432;Database=ikegunyj;User Id=ikegunyj;Password=PjDjGMbve9rwF5eP4fMGm5M59yzCpExq;";
        private string nombreEditar;
        private string sangreEditar;
        private string presionEditar;
        private string generoEditar;
        private string doctorEditar;
        private Pacientes pacienteReference;
        public AgregarPaciente(Pacientes pacientes, string nombreEditar, string sangreEditar, string presionEditar, string generoEditar, string doctorEditar)
        {
            InitializeComponent();
            MostrarDoctores();

            this.nombreEditar = nombreEditar;
            this.sangreEditar = sangreEditar;
            this.presionEditar = presionEditar;
            this.generoEditar = generoEditar;
            this.doctorEditar = doctorEditar;
            pacienteReference = pacientes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string genero = cmbGenero.SelectedItem.ToString();
            string sangre = cmbSangre.SelectedItem.ToString();
            string presion = cmbPresion.SelectedItem.ToString();
            string doctor = (cmbDoctores.SelectedItem as ComboboxItem).Text;

            using (var conn = new NpgsqlConnection(cadenaConexion))
            {
                conn.Open();
                // Insertar nuevo paciente
                string insertPaciente = "INSERT INTO Pacientes (Nombre, Genero, TipoSangre, PresionArterial, Doctor) VALUES (@nombre, @genero, @sangre, @presion, @doctor);";
                using (var cmd = new NpgsqlCommand(insertPaciente, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@sangre", sangre);
                    cmd.Parameters.AddWithValue("@presion", presion);
                    cmd.Parameters.AddWithValue("@doctor", doctor);

                    int result = cmd.ExecuteNonQuery();
                    pacienteReference.LoadPacientesData();

                    if (result > 0)
                    {
                        MessageBox.Show("Paciente agregado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el paciente.");
                    }
                }
            }

        }

        private void MostrarDoctores()
        {
            using (var conn = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nombre FROM \"public\".\"usuarios\" WHERE permisos = 'doctor'";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string doctorNombre = reader["nombre"].ToString();
                                cmbDoctores.Items.Add(new ComboboxItem(doctorNombre));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }

            public ComboboxItem(string text)
            {
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        public enum PresionArterial
        {
            Alta,
            Media,
            Baja
        }

        public enum TipoSangre
        {
            A,
            B,
            AB,
            O
        }
        public enum GeneroPaciente
        {
            mujer,
            hombre
        }

        public class Paciente
        {
            public string Nombre { get; set; }
            public GeneroPaciente Genero { get; set; }
            public TipoSangre Sangre { get; set; }
            public PresionArterial Presion { get; set; }
            public string Doctor { get; set; }
        }
    }
}
