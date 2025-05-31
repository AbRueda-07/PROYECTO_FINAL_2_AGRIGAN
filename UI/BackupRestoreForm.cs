using AgriGanAsistenteJutiapa.Models;
using Microsoft.Data.SqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace AgriGanAsistenteJutiapa.UI
{
    public partial class BackupRestoreForm : Form
    {
        private readonly string masterConn = "Server=DESKTOP-T3ECS92\\SQLEXPRESS;Database=master;Integrated Security=True;TrustServerCertificate=True;";

        private readonly Usuario usuario;

        //Si en el futuro se quiere pasar el usuario para registrar quién hizo el backup o la restauración, se puede usar esta variable.
        public BackupRestoreForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }


        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
                txtRutaBackup.Text = folderDialog.SelectedPath;
        }

        private void btnCrearBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRutaBackup.Text))
            {
                MessageBox.Show("Selecciona una carpeta válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string destino = Path.Combine(txtRutaBackup.Text, "AgriGanDB.bak");

                string query = $@"
                BACKUP DATABASE AgriGanDB
                TO DISK = N'{destino}'
                WITH FORMAT, INIT, NAME = 'Respaldo AgriGanDB';";

                using var conn = new SqlConnection(masterConn);
                using var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show($"✅ Respaldo creado exitosamente:\n{destino}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al crear respaldo:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionarFile_Click(object sender, EventArgs e)
        {
            FileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
            if (FileDialog.ShowDialog() == DialogResult.OK)
                txtArchivoRestore.Text = FileDialog.FileName;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArchivoRestore.Text) || !File.Exists(txtArchivoRestore.Text))
            {
                MessageBox.Show("Selecciona un archivo .bak válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string archivo = txtArchivoRestore.Text;

                string query = $@"
                ALTER DATABASE AgriGanDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE AgriGanDB
                FROM DISK = N'{archivo}'
                WITH REPLACE;
                ALTER DATABASE AgriGanDB SET MULTI_USER;";

                using var conn = new SqlConnection(masterConn);
                using var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("✅ Base de datos restaurada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al restaurar:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
