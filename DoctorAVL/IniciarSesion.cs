using Npgsql;
using System.Net.Http.Headers;

namespace DoctorAVL
{
    public partial class IniciarSesion : Form
    {
        string cadenaConexion = "Server=hansken.db.elephantsql.com;Port=5432;Database=ikegunyj;User Id=ikegunyj;Password=PjDjGMbve9rwF5eP4fMGm5M59yzCpExq;";
        public IniciarSesion()
        {
            InitializeComponent();
            this.FormClosing += TFormClosing;
        }

        //Paciente
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Entró como paciente");
        }

        //Iniciar sesión
        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            bool existe = UsuariosContrasenaExiste(usuario, contrasena);
            string permisos = ObtenerPermisosUsuario(usuario, contrasena);

            if (existe)
            {
                switch (permisos)
                {
                    case "administrador":
                        AdminView adminView = new AdminView(usuario, permisos);
                        this.Hide();
                        adminView.Show();
                        break;

                    case "doctor":
                        adminView = new AdminView(usuario, permisos);
                        this.Hide();
                        adminView.Show();
                        break;

                    case "digitador":
                        adminView = new AdminView(usuario, permisos);
                        this.Hide();
                        adminView.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario incorrecto");
            }
        }

        //chequea si existe cuenta
        private bool UsuariosContrasenaExiste(string usuario, string contrasena)
        {
            bool existe = false;
            string consulta = "SELECT COUNT (*) FROM usuarios WHERE usuario = @usuario AND contraseña = @contrasena";

            try
            {
                using (var conexion = new NpgsqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (var cmd = new NpgsqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena); 
                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                        existe = resultado > 0;
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
            return existe;
        }

        private string ObtenerPermisosUsuario(string usuario, string contrasena)
        {
            string? permisos = string.Empty;
            string consulta = "SELECT permisos FROM usuarios WHERE usuario = @usuario AND contraseña = @contrasena";

            try
            {
                using (var conexion = new NpgsqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (var cmd = new NpgsqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        var resultado = cmd.ExecuteScalar();
                        if (resultado != null)
                        {
                            permisos = resultado.ToString()!;
                        }
                        else
                        {
                            permisos = "valor predeterminado o lanzar una nueva InvalidOperationException(\"Se esperaba un resultado no nulo\")";
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
            return permisos; 
        }
        private void TFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
