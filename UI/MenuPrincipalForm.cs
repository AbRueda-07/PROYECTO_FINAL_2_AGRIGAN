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
using Microsoft.Data.Sql; 
using Microsoft.Data.SqlClient;



namespace AgriGanAsistenteJutiapa.UI
{
    public partial class MenuPrincipalForm : Form
    {
        private readonly Usuario usuario;



        public MenuPrincipalForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }


        private void btnAsistenteAgricola_Click(object sender, EventArgs e)
        {
            AsistenteAgricolaForm form = new AsistenteAgricolaForm(usuario);
            form.Show();
        }

        private void btnAsistenteGanadero_Click(object sender, EventArgs e)
        {
            AsistenteGanaderoForm form = new AsistenteGanaderoForm(usuario);
            form.Show();
        }

        private void btnFichasTecnicas_Click(object sender, EventArgs e)
        {
            FichasTecnicasForm form = new FichasTecnicasForm();
            form.Show();
        }

        private void btnHistorialConsultas_Click(object sender, EventArgs e)
        {
          RegistroBDAgriForm form = new RegistroBDAgriForm();
            form.Show();
        }

        private void btnRegistroDatos_Click(object sender, EventArgs e)
        {
            RegistrarForm form = new RegistrarForm();
            form.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "¿Estás seguro de eliminar tu cuenta y TODOS tus datos?\nEsta acción es irreversible.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            var service = new UsuarioService();
            bool exito = service.EliminarCuenta(usuario.Id); // Asegúrate que usuario.Id sea válido

            if (exito)
            {
                MessageBox.Show("Tu cuenta ha sido eliminada correctamente. Cerrando sesión.", "Cuenta eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Application.Restart();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar tu cuenta. Puede que haya datos dependientes o un error interno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresarLoginn_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {
            string v= $"¡Bienvenido, {this.usuario.Nombre}!";

        }

        private void btnAgriPredict_Click(object sender, EventArgs e)
        {
            AgriPredictForm form = new AgriPredictForm(usuario);
            form.Show();
        }

        private void btnRegistroD_Click(object sender, EventArgs e)
        {
            RegistrosDatosForm form = new RegistrosDatosForm(usuario);
            form.Show();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            BackupRestoreForm form = new BackupRestoreForm(usuario);
            form.Show();
        }

    }
}
