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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DoctorAVL
{
    public partial class AgregarUsuario : Form
    {
        private string nombreEditar;
        private string contrasenaEditar;
        private string permisosEditar;
        private AdminView adminViewReference;
        string cadenaConexion = "Server=hansken.db.elephantsql.com;Port=5432;Database=ikegunyj;User Id=ikegunyj;Password=PjDjGMbve9rwF5eP4fMGm5M59yzCpExq;";
        public AgregarUsuario(AdminView adminView, string nombre, string contraseña, string permisos)
        {
            nombreEditar = nombre;
            contrasenaEditar = contraseña;
            permisosEditar = permisos;
            InitializeComponent();
            txtUsuario.Text = nombreEditar;
            txtContrasena.Text = contrasenaEditar;
            cmboxPermiso.SelectedItem = permisosEditar;
            adminViewReference = adminView;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarUsuario(txtUsuario.Text, txtContrasena.Text, cmboxPermiso.Text);
            this.Hide();
        }
        private void agregarUsuario(string usuario, string contrasena, string permisos)
        {
            string query = "INSERT INTO public.usuarios (nombre, contraseña, permisos) VALUES (@usuario, @contrasena, @permisos::permiso);";
            if (!string.IsNullOrEmpty(nombreEditar))
            {
                query = @"
                    UPDATE public.usuarios
                    SET nombre = @usuario, contraseña = @contrasena, permisos = @permisos::permiso
                    WHERE nombre = @nombreEditar;";
            }
            try
            {
                using (var conexion = new NpgsqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (var cmd = new NpgsqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@permisos", permisos);
                        cmd.Parameters.AddWithValue("@nombreEditar", nombreEditar);
                        cmd.ExecuteNonQuery();
                        adminViewReference.Cargar_usuarios();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Error de base de datos: {ex.Message}");
                MessageBox.Show($"Error de base de datos: {ex.Message} Permisos: {permisos}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error no esperado: {ex.Message}");
                MessageBox.Show($"Error no esperado: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
