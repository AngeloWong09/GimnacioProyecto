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

        /// <summary>
        /// Maneja el evento de clic en el botón de inicio de sesión. 
        /// Verifica el nombre de usuario y la contraseña, redirigiendo al formulario adecuado para cada tipo de usuario.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Intentar verificar el inicio de sesión de un usuario común
            usuarioModelo usuario = controlador.IniciarSesion(nombreUsuario, contraseña);

            if (usuario != null)
            {
                lblMensaje.Text = $"Bienvenido {usuario.NombreUsuario}";
                lblMensaje.ForeColor = System.Drawing.Color.Green;

                // Obtener el ID del usuario desde el archivo CSV
                string idUsuario = ObtenerIdUsuario(nombreUsuario, contraseña);

                if (string.IsNullOrEmpty(idUsuario))
                {
                    MessageBox.Show("No se pudo obtener el ID del usuario. Verifique los datos.", "Error");
                    return;
                }

                // Crear una nueva instancia del formulario de usuario pasando el ID
                var nuevoForm = new formUsuario(idUsuario);
                nuevoForm.Show();
                this.Hide();
            }
            else
            {
                // Si no es un usuario, verificar si es un entrenador
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
                    // Si no es un entrenador, verificar si es un administrador
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
                        // Si no es ninguno de los tres, mostrar un mensaje de error
                        lblMensaje.Text = "Usuario o contraseña incorrectos.";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }



        /// <summary>
        /// Obtiene el ID del usuario desde el archivo "Usuarios.csv" basado en el nombre de usuario y la contraseña proporcionados.
        /// </summary>
        private string ObtenerIdUsuario(string nombreUsuario, string contraseña)
        {
            string rutaUsuarios = Path.Combine(Application.StartupPath, "Assets", "Usuarios.csv");

            // Leer todas las líneas del archivo
            var lineas = File.ReadAllLines(rutaUsuarios);

            // Buscar al usuario en el archivo CSV
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

  


