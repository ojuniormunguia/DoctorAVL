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
using static DoctorAVL.AgregarPaciente;

namespace DoctorAVL
{
    public partial class Recomendaciones : Form
    {
        private string sangre;
        private string presion;
        private string genero;
        private string nombre;
        private string cadenaConexion = "Server=hansken.db.elephantsql.com;Port=5432;Database=ikegunyj;User Id=ikegunyj;Password=PjDjGMbve9rwF5eP4fMGm5M59yzCpExq;";
        public Recomendaciones(string sangre, string presion, string genero, string nombre)
        {
            InitializeComponent();
            CargarRecomendacion();
        }

        private void CargarRecomendacion()
        {
            using (var conn = new NpgsqlConnection(cadenaConexion))
            {
                conn.Open();

                string query = @"SELECT mensajeTratamiento FROM Tratamientos
                    WHERE (Sangre = @sangre::TipoSangre OR Sangre = 'cualquiera'::TipoSangre)
                    AND (presion = @presion::NivelPresion OR presion = 'cualquiera'::NivelPresion)
                    AND (genero = @genero::GeneroTipo OR genero = 'cualquiera'::GeneroTipo)
                    AND (paciente = @paciente OR paciente = 'cualquiera')";

                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    cmd.Parameters.Add(new NpgsqlParameter("sangre", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = this.sangre.Trim() });
                    cmd.Parameters.Add(new NpgsqlParameter("presion", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = this.presion.Trim() });
                    cmd.Parameters.Add(new NpgsqlParameter("genero", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = this.genero.Trim() });

                    cmd.Parameters.Add(new NpgsqlParameter("paciente", this.nombre));
                    using (var reader = cmd.ExecuteReader())
                    {
                        listView1.Items.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string mensajeTratamiento = reader["mensajeTratamiento"].ToString();
                                listView1.Items.Add(mensajeTratamiento);
                            }
                        }
                        else
                        {

                            listView1.Items.Add("No hay recomendaciones disponibles para esta selección.");
                        }
                    }
                }
            }
        }
    }
}
