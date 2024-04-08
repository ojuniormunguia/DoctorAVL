using Npgsql;
using Npgsql.TypeMapping;
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
    public partial class ArbolView : Form
    {
        private string cadenaConexion = "Server=hansken.db.elephantsql.com;Port=5432;Database=ikegunyj;User Id=ikegunyj;Password=PjDjGMbve9rwF5eP4fMGm5M59yzCpExq;";
        private string usuario;
        private string permisos;
        public ArbolView(string usuarios, string permiso)
        {
            usuario = usuarios;
            permisos = permiso;
            InitializeComponent();

            LoadPacientesInTreeView();
            this.FormClosing += ArbolView_FormClosing;
        }

        private void LoadPacientesInTreeView()
        {
            using (var conn = new NpgsqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT nombre, genero, tiposangre, presionarterial FROM \"public\".\"pacientes\"";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        Dictionary<string, TreeNode> bloodTypeNodes = new Dictionary<string, TreeNode>();

                        while (reader.Read())
                        {
                            string nombre = reader["nombre"].ToString();
                            string genero = reader["genero"].ToString();
                            string tiposangre = reader["tiposangre"].ToString();
                            string presionarterial = reader["presionarterial"].ToString();

                            if (!bloodTypeNodes.ContainsKey(tiposangre))
                            {
                                TreeNode bloodNode = treePacientes.Nodes.Add(tiposangre, tiposangre);
                                bloodTypeNodes[tiposangre] = bloodNode;
                            }

                            TreeNode bloodTypeNode = bloodTypeNodes[tiposangre];
                            TreeNode[] pressureNodes = bloodTypeNode.Nodes.Find(presionarterial, false);
                            TreeNode pressureNode;
                            if (pressureNodes.Length == 0)
                            {
                                pressureNode = bloodTypeNode.Nodes.Add(presionarterial, presionarterial);
                            }
                            else
                            {
                                pressureNode = pressureNodes[0];
                            }

                            TreeNode[] genderNodes = pressureNode.Nodes.Find(genero, false);
                            TreeNode genderNode;
                            if (genderNodes.Length == 0)
                            {
                                genderNode = pressureNode.Nodes.Add(genero, genero);
                            }
                            else
                            {
                                genderNode = genderNodes[0];
                            }

                            genderNode.Nodes.Add(nombre, nombre);
                        }
                    }
                }
            }

            treePacientes.ExpandAll();
        }



        private void FetchAndDisplayTratamientos(string tiposangre, string presion, string genero, string nombre)
        {
            tiposangre = tiposangre.Trim();
            presion = presion.Trim();
            genero = genero.Trim();


            if (tiposangre == null || presion == null || genero == null)
            {
                MessageBox.Show("Seleccione un nodo de paciente válido.");
                return;
            }

            using (var conn = new NpgsqlConnection(cadenaConexion))
            {
                conn.Open();

                // Adjusted query to handle 'cualquiera' and NULL options
                string query = @"SELECT mensajeTratamiento FROM Tratamientos
                    WHERE (Sangre = @sangre::TipoSangre OR Sangre = 'cualquiera'::TipoSangre)
                    AND (presion = @presion::NivelPresion OR presion = 'cualquiera'::NivelPresion)
                    AND (genero = @genero::GeneroTipo OR genero = 'cualquiera'::GeneroTipo)
                    AND (paciente = @paciente OR paciente = 'cualquiera')";
                
                using (var cmd = new NpgsqlCommand(query, conn))
                {

                    cmd.Parameters.Add(new NpgsqlParameter("sangre", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = tiposangre.Trim() });
                    cmd.Parameters.Add(new NpgsqlParameter("presion", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = presion.Trim() });
                    cmd.Parameters.Add(new NpgsqlParameter("genero", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = genero.Trim() });

                    cmd.Parameters.Add(new NpgsqlParameter("paciente", nombre));
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string mensajeTratamiento = reader["mensajeTratamiento"].ToString();
                                listView1.Items.Clear();
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


        private void ArbolView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = new Pacientes(usuario, permisos);
            this.Hide();
            pacientes.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AdminView adminView = new AdminView(usuario, permisos);
            this.Hide();
            adminView.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treePacientes_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            string tiposangre = "cualquiera", presion = "cualquiera", genero = "cualquiera", nombre = "cualquiera";

            switch (selectedNode.Level)
            {
                case 0:  // Tipo de Sangre
                    tiposangre = selectedNode.Text;
                    break;
                case 1:  // Presión Arterial
                    presion = selectedNode.Text;
                    tiposangre = selectedNode.Parent.Text;
                    break;
                case 2:  // Género
                    genero = selectedNode.Text;
                    presion = selectedNode.Parent.Text;
                    tiposangre = selectedNode.Parent.Parent.Text;
                    break;
                case 3:  // Nombre
                    nombre = selectedNode.Text;
                    genero = selectedNode.Parent.Text;
                    presion = selectedNode.Parent.Parent.Text;
                    tiposangre = selectedNode.Parent.Parent.Parent.Text;
                    break;
            }

            FetchAndDisplayTratamientos(tiposangre, presion, genero, nombre);
        }


        private void treePacientes_Click(object sender, EventArgs e)
        {
        }
    }


}

