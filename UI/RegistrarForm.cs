using AgriGanAsistenteJutiapa.Models;
using AgriGanAsistenteJutiapa.Services;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace AgriGanAsistenteJutiapa.UI
{
    public partial class RegistrarForm : Form
    {
        private readonly UsuarioService usuarioService = new UsuarioService();
        private readonly Usuario usuarioActivo;

        public RegistrarForm()
        {
            InitializeComponent();

        }


        private void Limpiar()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContrasenia.Clear();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                ContraseniaHash = txtContrasenia.Text
            };

            bool exito = usuarioService.RegistrarUsuario(nuevoUsuario);

            if (exito)
                MessageBox.Show("Registro exitoso.");
            else
                MessageBox.Show("Error: El correo ya está registrado o hubo un problema.");

            bool EsCorreoValido(string email)
            {
                var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }
            // Luego:
            if (!EsCorreoValido(txtCorreo.Text))
            {
                MessageBox.Show("Correo no válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegresarLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            // Mostrar el formulario de login
            loginForm.Show();

            // Ocultar o cerrar el formulario actual
            this.Hide();
            this.Close();
        }
    }
}
