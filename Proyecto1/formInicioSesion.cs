using Proyecto1.Controlador;
using Proyecto1.Modelo;
using System;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class formInicioSesion : Form
    {
        private controladorUsuario controlador;
        public formInicioSesion()
        {
            InitializeComponent();
            controlador = new controladorUsuario();// Inicializa el controlador
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Validar el inicio de sesión a través del controlador
            Usuario usuario = controlador.IniciarSesion(nombreUsuario, contraseña);

            if (usuario != null)
            {
                // Mostrar mensaje de bienvenida basado en el rol del usuario
                lblMensaje.Text = $"Bienvenido {usuario.NombreUsuario} - Rol: {usuario.Rol}";
                lblMensaje.ForeColor = System.Drawing.Color.Green;

                // Redirigir o manejar lógica adicional según el rol del usuario
                if (usuario.Rol == "Administrador")
                {
                    MessageBox.Show("Acceso concedido. Tienes permisos de administrador.", "Inicio de Sesión");
                    


                }
                else if (usuario.Rol == "Entrenador")
                {
                    MessageBox.Show("Acceso concedido como entrenador.", "Inicio de Sesión");

                    formEntrenador formEntrenador = new formEntrenador();
                    formEntrenador.Show();
                    this.Hide(); // Ocultar el formulario actual

                }
                else
                {
                    MessageBox.Show("Acceso concedido como usuario regular.", "Inicio de Sesión");
                    // Lógica para usuarios regulares
                }
            }
            else
            {
                // Mostrar mensaje de error
                lblMensaje.Text = "Nombre de usuario o contraseña incorrectos.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }



}