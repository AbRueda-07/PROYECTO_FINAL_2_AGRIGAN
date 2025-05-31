using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgriGanAsistenteJutiapa.Models;
using AgriGanAsistenteJutiapa.Services;
using AgriGanAsistenteJutiapa.UI;


namespace AgriGanAsistenteJutiapa.UI
{
    public partial class LoginForm : Form
    {
        private readonly UsuarioService usuarioService = new UsuarioService();

        public LoginForm()
        {
            InitializeComponent();
            Limpiar();
        }
        public void Limpiar()
        {
            txtCorreo.Text = string.Empty;
            txtContrasenia.Text = string.Empty;
        }
        private void GuardarCorreo(string correo)
        {
            File.WriteAllText("user_config.txt", correo);

        }

        private string LeerCorreo()
        {
            return File.Exists("user_config.txt") ? File.ReadAllText("user_config.txt") : "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarForm form = new RegistrarForm();
            form.ShowDialog();
        }
        private void btnLoginIn_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string contrasenia = txtContrasenia.Text;

            Usuario usuario = usuarioService.Login(correo, contrasenia);
            if (usuario != null)
            {
                MessageBox.Show($"¡Bienvenido, {usuario.Nombre}!");
                MenuPrincipalForm menu = new MenuPrincipalForm(usuario);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.");
            }


        }

        private void btnLoginn_Click(object sender, EventArgs e)
        {
            var correo = txtCorreo.Text.Trim();
            var contrasenia = txtContrasenia.Text;

            var usuarioService = new UsuarioService();
            Usuario usuario = usuarioService.ValidarCredenciales(correo, contrasenia);

            if (usuario != null)
            {
                this.Hide(); // Oculta el login
                MenuPrincipalForm menu = new MenuPrincipalForm(usuario);
                menu.ShowDialog();
                this.Show(); // Vuelve al login si se cierra el menú
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string ultimoCorreo = LeerCorreo();
            if (!string.IsNullOrEmpty(ultimoCorreo))
            {
                txtCorreo.Text = ultimoCorreo;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            RegistrarForm form = new RegistrarForm();
            form.ShowDialog();
        }

        private bool mostrandoClave = false;

        private void pbToggleClave_Click(object sender, EventArgs e)
        {
            mostrandoClave = !mostrandoClave;

            // Alternar visibilidad de contraseña
            txtContrasenia.UseSystemPasswordChar = !mostrandoClave;

            // Cambiar icono (reemplaza con tus recursos reales)
            pbToggleClave.Image = mostrandoClave
                ? Properties.Resources.eye
                : Properties.Resources.eye_off;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}