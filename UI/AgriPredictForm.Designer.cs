namespace AgriGanAsistenteJutiapa.UI
{
    partial class AgriPredictForm
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
            lblObservaciones = new Label();
            lblResultado = new Label();
            rtbResultado = new RichTextBox();
            lblDV = new Label();
            lblRuta = new Label();
            btnCerrar = new Button();
            btnAnalizar = new Button();
            cmbTipo = new ComboBox();
            txtNombre = new TextBox();
            txtClima = new TextBox();
            txtEdad = new TextBox();
            txtObservaciones = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnGenerarPDF = new Button();
            btnAbrirCarpetaPDF = new Button();
            SuspendLayout();
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.BackColor = Color.Snow;
            lblObservaciones.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservaciones.ForeColor = SystemColors.ActiveCaptionText;
            lblObservaciones.Location = new Point(69, 170);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(180, 17);
            lblObservaciones.TabIndex = 16;
            lblObservaciones.Text = "Seleccione una Opción:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Snow;
            lblResultado.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.ActiveCaptionText;
            lblResultado.Location = new Point(73, 506);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(85, 17);
            lblResultado.TabIndex = 14;
            lblResultado.Text = "Resultado:";
            // 
            // rtbResultado
            // 
            rtbResultado.BackColor = SystemColors.Info;
            rtbResultado.Location = new Point(73, 537);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.Size = new Size(686, 261);
            rtbResultado.TabIndex = 13;
            rtbResultado.Text = "";
            // 
            // lblDV
            // 
            lblDV.AutoSize = true;
            lblDV.BackColor = Color.Sienna;
            lblDV.Font = new Font("Perpetua Titling MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDV.ForeColor = SystemColors.ActiveCaptionText;
            lblDV.Location = new Point(128, 30);
            lblDV.Name = "lblDV";
            lblDV.Size = new Size(753, 44);
            lblDV.TabIndex = 11;
            lblDV.Text = "Asistente Inteligente Predictivo";
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.BackColor = Color.Transparent;
            lblRuta.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRuta.ForeColor = Color.LawnGreen;
            lblRuta.Location = new Point(787, 891);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(32, 17);
            lblRuta.TabIndex = 20;
            lblRuta.Text = "ㅤㅤ";
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(1002, 21);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(102, 53);
            btnCerrar.TabIndex = 19;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAnalizar
            // 
            btnAnalizar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalizar.Location = new Point(84, 849);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(149, 66);
            btnAnalizar.TabIndex = 18;
            btnAnalizar.Text = "Analizar con IA";
            btnAnalizar.UseVisualStyleBackColor = true;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Agricultura", "Ganaderia" });
            cmbTipo.Location = new Point(69, 204);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(218, 28);
            cmbTipo.TabIndex = 21;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 299);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(389, 27);
            txtNombre.TabIndex = 22;
            // 
            // txtClima
            // 
            txtClima.Location = new Point(583, 299);
            txtClima.Name = "txtClima";
            txtClima.PlaceholderText = "Clima (ej. cálido, lluvioso)";
            txtClima.Size = new Size(389, 27);
            txtClima.TabIndex = 23;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(69, 409);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(389, 27);
            txtEdad.TabIndex = 24;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(583, 409);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Observaciones (síntomas, cambios, etc)";
            txtObservaciones.Size = new Size(389, 27);
            txtObservaciones.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(69, 267);
            label1.Name = "label1";
            label1.Size = new Size(266, 17);
            label1.TabIndex = 26;
            label1.Text = "Raza del animal / Nombre Cultivo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Snow;
            label2.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(69, 379);
            label2.Name = "label2";
            label2.Size = new Size(305, 17);
            label2.TabIndex = 27;
            label2.Text = "Edad del animal o tiempo de siembra:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Snow;
            label3.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(583, 267);
            label3.Name = "label3";
            label3.Size = new Size(180, 17);
            label3.TabIndex = 28;
            label3.Text = "Condiciones climáticas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Snow;
            label4.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(583, 379);
            label4.Name = "label4";
            label4.Size = new Size(119, 17);
            label4.TabIndex = 29;
            label4.Text = "Observaciones:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(267, 849);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 66);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(642, 849);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(149, 66);
            btnLimpiar.TabIndex = 31;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarPDF.Location = new Point(457, 849);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(149, 66);
            btnGenerarPDF.TabIndex = 32;
            btnGenerarPDF.Text = "Generar pdf";
            btnGenerarPDF.UseVisualStyleBackColor = true;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // btnAbrirCarpetaPDF
            // 
            btnAbrirCarpetaPDF.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnAbrirCarpetaPDF.Location = new Point(875, 625);
            btnAbrirCarpetaPDF.Name = "btnAbrirCarpetaPDF";
            btnAbrirCarpetaPDF.Size = new Size(144, 59);
            btnAbrirCarpetaPDF.TabIndex = 33;
            btnAbrirCarpetaPDF.Text = "Abrir Carpeta";
            btnAbrirCarpetaPDF.UseVisualStyleBackColor = true;
            btnAbrirCarpetaPDF.Click += btnAbrirCarpetaPDF_Click;
            // 
            // AgriPredictForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_05_29_215100;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1116, 962);
            Controls.Add(btnAbrirCarpetaPDF);
            Controls.Add(btnGenerarPDF);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtObservaciones);
            Controls.Add(txtEdad);
            Controls.Add(txtClima);
            Controls.Add(txtNombre);
            Controls.Add(cmbTipo);
            Controls.Add(lblRuta);
            Controls.Add(btnCerrar);
            Controls.Add(btnAnalizar);
            Controls.Add(lblObservaciones);
            Controls.Add(lblResultado);
            Controls.Add(rtbResultado);
            Controls.Add(lblDV);
            DoubleBuffered = true;
            Name = "AgriPredictForm";
            Text = "AgriPredictForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblObservaciones;
        private Label lblResultado;
        private RichTextBox rtbResultado;
        private Label lblDV;
        private Label lblRuta;
        private Button btnCerrar;
        private Button btnAnalizar;
        private ComboBox cmbTipo;
        private TextBox txtNombre;
        private TextBox txtClima;
        private TextBox txtEdad;
        private TextBox txtObservaciones;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnGenerarPDF;
        private Button btnAbrirCarpetaPDF;
    }
}