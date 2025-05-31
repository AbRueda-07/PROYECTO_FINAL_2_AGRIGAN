namespace AgriGanAsistenteJutiapa.UI
{
    partial class BackupRestoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBackup = new GroupBox();
            btnSeleccionarRuta = new Button();
            txtRutaBackup = new TextBox();
            btnCrearBackup = new Button();
            grpRestore = new GroupBox();
            btnRestaurar = new Button();
            txtArchivoRestore = new TextBox();
            btnSeleccionarFile = new Button();
            folderDialog = new FolderBrowserDialog();
            FileDialog = new OpenFileDialog();
            grpBackup.SuspendLayout();
            grpRestore.SuspendLayout();
            SuspendLayout();
            // 
            // grpBackup
            // 
            grpBackup.BackColor = SystemColors.ActiveCaption;
            grpBackup.Controls.Add(btnSeleccionarRuta);
            grpBackup.Controls.Add(txtRutaBackup);
            grpBackup.Controls.Add(btnCrearBackup);
            grpBackup.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBackup.Location = new Point(41, 104);
            grpBackup.Name = "grpBackup";
            grpBackup.Size = new Size(460, 347);
            grpBackup.TabIndex = 0;
            grpBackup.TabStop = false;
            grpBackup.Text = "Crear Respaldo";
            // 
            // btnSeleccionarRuta
            // 
            btnSeleccionarRuta.Location = new Point(230, 244);
            btnSeleccionarRuta.Name = "btnSeleccionarRuta";
            btnSeleccionarRuta.Size = new Size(207, 58);
            btnSeleccionarRuta.TabIndex = 2;
            btnSeleccionarRuta.Text = "Elegir Carpeta Destino";
            btnSeleccionarRuta.UseVisualStyleBackColor = true;
            btnSeleccionarRuta.Click += btnSeleccionarRuta_Click;
            // 
            // txtRutaBackup
            // 
            txtRutaBackup.Location = new Point(19, 133);
            txtRutaBackup.Name = "txtRutaBackup";
            txtRutaBackup.ReadOnly = true;
            txtRutaBackup.Size = new Size(418, 28);
            txtRutaBackup.TabIndex = 1;
            // 
            // btnCrearBackup
            // 
            btnCrearBackup.Location = new Point(33, 244);
            btnCrearBackup.Name = "btnCrearBackup";
            btnCrearBackup.Size = new Size(191, 58);
            btnCrearBackup.TabIndex = 0;
            btnCrearBackup.Text = "Crear Respaldo ";
            btnCrearBackup.UseVisualStyleBackColor = true;
            btnCrearBackup.Click += btnCrearBackup_Click;
            // 
            // grpRestore
            // 
            grpRestore.BackColor = SystemColors.ActiveCaption;
            grpRestore.Controls.Add(btnRestaurar);
            grpRestore.Controls.Add(txtArchivoRestore);
            grpRestore.Controls.Add(btnSeleccionarFile);
            grpRestore.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpRestore.Location = new Point(530, 104);
            grpRestore.Name = "grpRestore";
            grpRestore.Size = new Size(460, 347);
            grpRestore.TabIndex = 1;
            grpRestore.TabStop = false;
            grpRestore.Text = "Restaurar Respaldo";
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(230, 244);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(207, 58);
            btnRestaurar.TabIndex = 5;
            btnRestaurar.Text = "Restaurar Respaldo";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // txtArchivoRestore
            // 
            txtArchivoRestore.Location = new Point(19, 133);
            txtArchivoRestore.Name = "txtArchivoRestore";
            txtArchivoRestore.ReadOnly = true;
            txtArchivoRestore.Size = new Size(418, 28);
            txtArchivoRestore.TabIndex = 4;
            // 
            // btnSeleccionarFile
            // 
            btnSeleccionarFile.Location = new Point(33, 244);
            btnSeleccionarFile.Name = "btnSeleccionarFile";
            btnSeleccionarFile.Size = new Size(191, 58);
            btnSeleccionarFile.TabIndex = 3;
            btnSeleccionarFile.Text = "Elegir Achivo .back";
            btnSeleccionarFile.UseVisualStyleBackColor = true;
            btnSeleccionarFile.Click += btnSeleccionarFile_Click;
            // 
            // FileDialog
            // 
            FileDialog.FileName = "openFileDialog1";
            // 
            // BackupRestoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1011, 500);
            Controls.Add(grpRestore);
            Controls.Add(grpBackup);
            Name = "BackupRestoreForm";
            Text = "BackupRestoreForm";
            grpBackup.ResumeLayout(false);
            grpBackup.PerformLayout();
            grpRestore.ResumeLayout(false);
            grpRestore.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBackup;
        private GroupBox grpRestore;
        private Button btnSeleccionarRuta;
        private TextBox txtRutaBackup;
        private Button btnCrearBackup;
        private Button btnRestaurar;
        private TextBox txtArchivoRestore;
        private Button btnSeleccionarFile;
        private FolderBrowserDialog folderDialog;
        private OpenFileDialog FileDialog;
    }
}