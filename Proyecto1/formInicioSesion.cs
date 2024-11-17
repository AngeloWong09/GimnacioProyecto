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
        public formInicioSesion()
        {
            InitializeComponent();
            controlador = new controladorUsuario(); // Inicializa el controlador
            controladorEntrenador = new controladorEntrenador();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Validar el inicio de sesión
            Usuario usuario = controlador.IniciarSesion(nombreUsuario, contraseña);

            if (usuario != null)
            {
                lblMensaje.Text = $"Bienvenido {usuario.NombreUsuario}";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito");

                // Redirigir a otro formulario
                var nuevoForm = new formUsuario(); // Reemplazar con el formulario adecuado
                nuevoForm.Show();
                this.Hide();
            }


            // Intentar iniciar sesión como Entrenador
            Entrenador entrenador = controladorEntrenador.IniciarSesion(nombreUsuario, contraseña);

            if (entrenador != null)
            {
                lblMensaje.Text = $"Bienvenido {entrenador.NombreUsuario}";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show("Inicio de sesión exitoso como Entrenador.", "Éxito");

                var formEntrenador = new formEntrenador(); // Formulario para entrenadores
                formEntrenador.Show();
                this.Hide();
                return;
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrectos.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }



        }

        private void formInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
