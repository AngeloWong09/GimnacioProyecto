using Proyecto1.Controlador;
using Proyecto1.Modelo;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class formInicioSesion : Form
    {
        private controladorUsuario controlador;
        private controladorEntrenador controladorEntrenador;
        private controladorAdministrador controladorAdministrador;
        public static usuarioModelo UsuarioLogueado;

        public formInicioSesion()
        {
            InitializeComponent();
            controlador = new controladorUsuario();
            controladorEntrenador = new controladorEntrenador();
            controladorAdministrador = new controladorAdministrador();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Verificar el inicio de sesión del usuario común
            usuarioModelo usuario = controlador.IniciarSesion(nombreUsuario, contraseña);

            if (usuario != null)
            {
                lblMensaje.Text = $"Bienvenido {usuario.NombreUsuario}";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                

                // Leer el archivo Usuarios.csv para obtener el ID del usuario
                string idUsuario = ObtenerIdUsuario(nombreUsuario, contraseña);

                if (string.IsNullOrEmpty(idUsuario))
                {
                    MessageBox.Show("No se pudo obtener el ID del usuario. Verifique los datos.", "Error");
                    return;
                }

                // Convertir el ID de usuario de string a int
                var nuevoForm = new formUsuario(idUsuario); // Pasamos el ID del usuario
                nuevoForm.Show();
                this.Hide();
            }
            else
            {
                // Si no encuentra al usuario, verificar si es un entrenador
                entrenadorModelo entrenador = controladorEntrenador.IniciarSesion(nombreUsuario, contraseña);

                if (entrenador != null)
                {
                    lblMensaje.Text = $"Bienvenido {entrenador.NombreUsuario}";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    

                    // Abrir el formulario de entrenador
                    var formEntrenador = new formEntrenador();
                    formEntrenador.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    // Si tampoco es un entrenador, verificar si es un administrador
                    administradorModelo administrador = controladorAdministrador.IniciarSesion(nombreUsuario, contraseña);
                    if (administrador != null)
                    {
                        lblMensaje.Text = $"Bienvenido {administrador.NombreUsuario}";
                        lblMensaje.ForeColor = System.Drawing.Color.Green;
                       

                        // Abrir el formulario de administrador
                        var formAdministrador = new formAdministrador();
                        formAdministrador.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        // Si no es ninguno de los tres, mostrar mensaje de error
                        lblMensaje.Text = "Usuario o contraseña incorrectos.";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        // Función para obtener el ID del usuario desde el archivo Usuarios.csv
        private string ObtenerIdUsuario(string nombreUsuario, string contraseña)
        {
            string rutaUsuarios = Path.Combine(Application.StartupPath, "Assets", "Usuarios.csv");

            var lineas = File.ReadAllLines(rutaUsuarios);
            var usuario = lineas.Skip(1) // Omite el encabezado
                                .Select(line => line.Split(';'))
                                .FirstOrDefault(columns => columns[0].Trim() == nombreUsuario && columns[1].Trim() == contraseña);

            if (usuario != null && usuario.Length > 6)
            {
                return usuario[6].Trim(); // El ID está en la columna 6 (índice 5)
            }
            return null;

        }
            }
}
  


