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
        public AgregarPaciente()
        {
            InitializeComponent();
            MostrarDoctores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

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

    }
}
