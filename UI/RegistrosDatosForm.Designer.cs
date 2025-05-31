namespace AgriGanAsistenteJutiapa.UI
{
    partial class RegistrosDatosForm
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
            cmbTipoRegistro = new ComboBox();
            lblRDatos = new Label();
            pnCultivo = new Panel();
            label4 = new Label();
            txtTratamiento = new TextBox();
            label3 = new Label();
            txtSintomas = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTipoCult = new TextBox();
            txtNombreCult = new TextBox();
            btnGuardar = new Button();
            lblSOpcion = new Label();
            btnCerrar = new Button();
            pnAnimal = new Panel();
            nudEdad = new NumericUpDown();
            label9 = new Label();
            txtTratAnimal = new TextBox();
            label8 = new Label();
            label5 = new Label();
            txtEnfermedad = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtRaza = new TextBox();
            txtEspecie = new TextBox();
            label10 = new Label();
            label11 = new Label();
            pnCultivo.SuspendLayout();
            pnAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoRegistro
            // 
            cmbTipoRegistro.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTipoRegistro.FormattingEnabled = true;
            cmbTipoRegistro.Items.AddRange(new object[] { "Cultivo", "Animal" });
            cmbTipoRegistro.Location = new Point(70, 176);
            cmbTipoRegistro.Name = "cmbTipoRegistro";
            cmbTipoRegistro.Size = new Size(249, 29);
            cmbTipoRegistro.TabIndex = 0;
            cmbTipoRegistro.SelectedIndexChanged += cmbTipoRegistro_SelectedIndexChanged;
            // 
            // lblRDatos
            // 
            lblRDatos.AutoSize = true;
            lblRDatos.BackColor = Color.DarkKhaki;
            lblRDatos.Font = new Font("Perpetua Titling MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRDatos.Location = new Point(371, 24);
            lblRDatos.Name = "lblRDatos";
            lblRDatos.Size = new Size(429, 44);
            lblRDatos.TabIndex = 1;
            lblRDatos.Text = "Registro de Datos";
            // 
            // pnCultivo
            // 
            pnCultivo.Controls.Add(label4);
            pnCultivo.Controls.Add(txtTratamiento);
            pnCultivo.Controls.Add(label3);
            pnCultivo.Controls.Add(txtSintomas);
            pnCultivo.Controls.Add(label2);
            pnCultivo.Controls.Add(label1);
            pnCultivo.Controls.Add(txtTipoCult);
            pnCultivo.Controls.Add(txtNombreCult);
            pnCultivo.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            pnCultivo.Location = new Point(679, 341);
            pnCultivo.Name = "pnCultivo";
            pnCultivo.Size = new Size(574, 461);
            pnCultivo.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 333);
            label4.Name = "label4";
            label4.Size = new Size(250, 21);
            label4.TabIndex = 12;
            label4.Text = "Tratamiento Aplicado:";
            // 
            // txtTratamiento
            // 
            txtTratamiento.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold);
            txtTratamiento.Location = new Point(3, 369);
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(522, 28);
            txtTratamiento.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 226);
            label3.Name = "label3";
            label3.Size = new Size(236, 21);
            label3.TabIndex = 10;
            label3.Text = "Sintomas Observados:";
            // 
            // txtSintomas
            // 
            txtSintomas.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold);
            txtSintomas.Location = new Point(6, 262);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(522, 28);
            txtSintomas.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 133);
            label2.Name = "label2";
            label2.Size = new Size(433, 21);
            label2.TabIndex = 8;
            label2.Text = "Tipo de Cultivo(Grani, fruta, pasto, etc.)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 50);
            label1.Name = "label1";
            label1.Size = new Size(223, 21);
            label1.TabIndex = 7;
            label1.Text = "Nombre del Cultivo:";
            // 
            // txtTipoCult
            // 
            txtTipoCult.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold);
            txtTipoCult.Location = new Point(3, 169);
            txtTipoCult.Name = "txtTipoCult";
            txtTipoCult.Size = new Size(522, 28);
            txtTipoCult.TabIndex = 1;
            // 
            // txtNombreCult
            // 
            txtNombreCult.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold);
            txtNombreCult.Location = new Point(3, 88);
            txtNombreCult.Name = "txtNombreCult";
            txtNombreCult.Size = new Size(522, 28);
            txtNombreCult.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnGuardar.Location = new Point(517, 859);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(188, 58);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guaradar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblSOpcion
            // 
            lblSOpcion.AutoSize = true;
            lblSOpcion.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSOpcion.Location = new Point(70, 133);
            lblSOpcion.Name = "lblSOpcion";
            lblSOpcion.Size = new Size(249, 21);
            lblSOpcion.TabIndex = 5;
            lblSOpcion.Text = "Seleccione una Opción:";
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnCerrar.Location = new Point(1135, 24);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnAnimal
            // 
            pnAnimal.Controls.Add(nudEdad);
            pnAnimal.Controls.Add(label9);
            pnAnimal.Controls.Add(txtTratAnimal);
            pnAnimal.Controls.Add(label8);
            pnAnimal.Controls.Add(label5);
            pnAnimal.Controls.Add(txtEnfermedad);
            pnAnimal.Controls.Add(label6);
            pnAnimal.Controls.Add(label7);
            pnAnimal.Controls.Add(txtRaza);
            pnAnimal.Controls.Add(txtEspecie);
            pnAnimal.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            pnAnimal.Location = new Point(23, 341);
            pnAnimal.Name = "pnAnimal";
            pnAnimal.Size = new Size(574, 461);
            pnAnimal.TabIndex = 13;
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(252, 204);
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(166, 28);
            nudEdad.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 361);
            label9.Name = "label9";
            label9.Size = new Size(250, 21);
            label9.TabIndex = 15;
            label9.Text = "Tratamiento Aplicado:";
            // 
            // txtTratAnimal
            // 
            txtTratAnimal.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold);
            txtTratAnimal.Location = new Point(0, 397);
            txtTratAnimal.Name = "txtTratAnimal";
            txtTratAnimal.Size = new Size(522, 28);
            txtTratAnimal.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 9);
            label8.Name = "label8";
            label8.Size = new Size(202, 21);
            label8.TabIndex = 13;
            label8.Text = "Especie del Animal:";
            label8.TextAlign = ContentAlignment.BottomRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 273);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 12;
            label5.Text = "Enfermedad:";
            // 
            // txtEnfermedad
            // 
            txtEnfermedad.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold);
            txtEnfermedad.Location = new Point(0, 309);
            txtEnfermedad.Name = "txtEnfermedad";
            txtEnfermedad.Size = new Size(522, 28);
            txtEnfermedad.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 206);
            label6.Name = "label6";
            label6.Size = new Size(243, 21);
            label6.TabIndex = 10;
            label6.Text = "Edad (Años, meses, etc):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 92);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 8;
            label7.Text = "Raza:";
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold);
            txtRaza.Location = new Point(0, 128);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(522, 28);
            txtRaza.TabIndex = 1;
            // 
            // txtEspecie
            // 
            txtEspecie.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold);
            txtEspecie.Location = new Point(0, 47);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(522, 28);
            txtEspecie.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Cornsilk;
            label10.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label10.Location = new Point(853, 291);
            label10.Name = "label10";
            label10.Size = new Size(183, 24);
            label10.TabIndex = 13;
            label10.Text = "Para Cultivos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.CornflowerBlue;
            label11.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label11.Location = new Point(173, 291);
            label11.Name = "label11";
            label11.Size = new Size(188, 24);
            label11.TabIndex = 14;
            label11.Text = "Para Animales";
            // 
            // RegistrosDatosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_05_27_221117;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1304, 940);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(pnAnimal);
            Controls.Add(btnCerrar);
            Controls.Add(lblSOpcion);
            Controls.Add(btnGuardar);
            Controls.Add(pnCultivo);
            Controls.Add(lblRDatos);
            Controls.Add(cmbTipoRegistro);
            DoubleBuffered = true;
            Name = "RegistrosDatosForm";
            Text = "RegistrosDatosForm";
            Load += RegistrosDatosForm_Load;
            pnCultivo.ResumeLayout(false);
            pnCultivo.PerformLayout();
            pnAnimal.ResumeLayout(false);
            pnAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoRegistro;
        private Label lblRDatos;
        private Panel pnCultivo;
        private Button btnGuardar;
        private Label lblSOpcion;
        private Button btnCerrar;
        private Label label4;
        private TextBox txtTratamiento;
        private Label label3;
        private TextBox txtSintomas;
        private Label label2;
        private Label label1;
        private TextBox txtTipoCult;
        private TextBox txtNombreCult;
        private Panel pnAnimal;
        private Label label9;
        private TextBox txtTratAnimal;
        private Label label8;
        private Label label5;
        private TextBox txtEnfermedad;
        private Label label6;
        private Label label7;
        private TextBox txtRaza;
        private TextBox txtEspecie;
        private Label label10;
        private Label label11;
        private NumericUpDown nudEdad;
    }
}