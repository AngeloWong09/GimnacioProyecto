using Proyecto1.Controlador;
using Proyecto1.Modelo;
using System;

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
                // Establecer el usuario logueado en la variable estática
                UsuarioLogueado = usuario;

                lblMensaje.Text = $"Bienvenido {usuario.NombreUsuario}";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito");

                // Abrir el formulario de usuario
                var nuevoForm = new formUsuario();
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
                    MessageBox.Show("Inicio de sesión exitoso como Entrenador.", "Éxito");

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
                        MessageBox.Show("Inicio de sesión exitoso como Administrador.", "Éxito");

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

        private void formInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
