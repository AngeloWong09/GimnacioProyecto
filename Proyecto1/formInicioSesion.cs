﻿using Proyecto1.Controlador;
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
            controlador = new controladorUsuario(); // Inicializa el controlador
            controladorEntrenador = new controladorEntrenador();
            controladorAdministrador = new controladorAdministrador();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Validar el inicio de sesión
            usuarioModelo usuario = controlador.IniciarSesion(nombreUsuario, contraseña);

            if (usuario != null)
            {
                lblMensaje.Text = $"Bienvenido {usuario.NombreUsuario}";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito");

                // Guardar el usuario logueado
                UsuarioLogueado = usuario;

                // Redirigir al formulario de usuario
                var nuevoForm = new formUsuario(); // Formulario para el usuario
                nuevoForm.Show();
                this.Hide();
            }


            // Intentar iniciar sesión como Entrenador
            entrenadorModelo entrenador = controladorEntrenador.IniciarSesion(nombreUsuario, contraseña);

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

            // Intentar iniciar sesión como Administrador
            administradorModelo administrador = controladorAdministrador.IniciarSesion(nombreUsuario, contraseña);
            if (administrador != null)
            {
                lblMensaje.Text = $"Bienvenido {administrador.NombreUsuario}";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show("Inicio de sesión exitoso como Administrador.", "Éxito");

                var formAdministrador = new formAdministrador(); // Formulario para administradores
                formAdministrador.Show();
                this.Hide();
                return;
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
