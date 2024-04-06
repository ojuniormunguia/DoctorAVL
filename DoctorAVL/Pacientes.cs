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
            
            this.FormClosing += Pacientes_FormClosing;
        }

        private void Pacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AdminView adminView = new AdminView(usuario, permisos);
            this.Hide();
            adminView.Show();
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            AgregarPaciente agregarPaciente = new AgregarPaciente();
            agregarPaciente.Show();
        }

        
    }
}
