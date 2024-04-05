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
        }

        //Paciente
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Entr� como paciente");
        }

        //Iniciar sesi�n
        private void btnIniciarSesi�n_Click(object sender, EventArgs e)
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

                        break;

                    case "digitador":

                        break;
                }
            }
            else
            {
                MessageBox.Show("Contrase�a o Usuario incorrecto");
            }
        }

        //chequea si existe cuenta
        private bool UsuariosContrasenaExiste(string usuario, string contrasena)
        {
            bool existe = false;
            string consulta = "SELECT COUNT (*) FROM usuarios WHERE nombre = @nombre AND contrase�a = @contrasena";

            try
            {
                using (var conexion = new NpgsqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (var cmd = new NpgsqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", usuario);
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
            string permisos = string.Empty;
            string consulta = "SELECT permisos FROM usuarios WHERE nombre = @nombre AND contrase�a = @contrasena";

            try
            {
                using (var conexion = new NpgsqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (var cmd = new NpgsqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        // ExecuteScalar used here for simplicity; adjust if expecting multiple rows
                        var resultado = cmd.ExecuteScalar();
                        if (resultado != null)
                        {
                            permisos = Convert.ToString(resultado);
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
            return permisos; // Returns permissions as a string
        }
    }
}
