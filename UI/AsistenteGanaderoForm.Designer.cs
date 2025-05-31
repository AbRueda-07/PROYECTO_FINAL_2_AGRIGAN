namespace AgriGanAsistenteJutiapa.UI
{
    partial class AsistenteGanaderoForm
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
            btnLimpiar = new Button();
            rtbRespuesta = new RichTextBox();
            btnCerrar = new Button();
            btnGuardarHistorial = new Button();
            lblRespuesta = new Label();
            lblPregunta = new Label();
            txtPregunta = new TextBox();
            btnConsultar = new Button();
            lblTituloG = new Label();
            btnGenerarPDF = new Button();
            btnAbrirCarpetaPDF = new Button();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnLimpiar.Location = new Point(688, 555);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 59);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // rtbRespuesta
            // 
            rtbRespuesta.Location = new Point(81, 253);
            rtbRespuesta.Name = "rtbRespuesta";
            rtbRespuesta.Size = new Size(781, 228);
            rtbRespuesta.TabIndex = 29;
            rtbRespuesta.Text = "";
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnCerrar.Location = new Point(870, 29);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 28;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnGuardarHistorial
            // 
            btnGuardarHistorial.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnGuardarHistorial.Location = new Point(330, 555);
            btnGuardarHistorial.Name = "btnGuardarHistorial";
            btnGuardarHistorial.Size = new Size(144, 59);
            btnGuardarHistorial.TabIndex = 27;
            btnGuardarHistorial.Text = "Guardar en historial\n\n";
            btnGuardarHistorial.UseVisualStyleBackColor = true;
            btnGuardarHistorial.Click += btnGuardarHistorial_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.BackColor = Color.Peru;
            lblRespuesta.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblRespuesta.Location = new Point(81, 229);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(116, 21);
            lblRespuesta.TabIndex = 26;
            lblRespuesta.Text = "Respuesta:";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.Peru;
            lblPregunta.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblPregunta.Location = new Point(45, 173);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(325, 21);
            lblPregunta.TabIndex = 25;
            lblPregunta.Text = "Escribe tu consulta agrícola:\n";
            // 
            // txtPregunta
            // 
            txtPregunta.Location = new Point(376, 167);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(486, 27);
            txtPregunta.TabIndex = 24;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnConsultar.Location = new Point(172, 555);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(131, 59);
            btnConsultar.TabIndex = 23;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblTituloG
            // 
            lblTituloG.AutoSize = true;
            lblTituloG.BackColor = Color.Peru;
            lblTituloG.Font = new Font("Perpetua Titling MT", 22F, FontStyle.Bold);
            lblTituloG.Location = new Point(287, 29);
            lblTituloG.Name = "lblTituloG";
            lblTituloG.Size = new Size(470, 44);
            lblTituloG.TabIndex = 22;
            lblTituloG.Text = "ASISTENTE GANADERO";
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnGenerarPDF.Location = new Point(511, 555);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(144, 59);
            btnGenerarPDF.TabIndex = 31;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = true;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // btnAbrirCarpetaPDF
            // 
            btnAbrirCarpetaPDF.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnAbrirCarpetaPDF.Location = new Point(903, 352);
            btnAbrirCarpetaPDF.Name = "btnAbrirCarpetaPDF";
            btnAbrirCarpetaPDF.Size = new Size(144, 59);
            btnAbrirCarpetaPDF.TabIndex = 32;
            btnAbrirCarpetaPDF.Text = "Abrir Carpeta";
            btnAbrirCarpetaPDF.UseVisualStyleBackColor = true;
            btnAbrirCarpetaPDF.Click += btnAbrirCarpetaPDF_Click_1;
            // 
            // AsistenteGanaderoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_05_26_224419;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1075, 689);
            Controls.Add(btnAbrirCarpetaPDF);
            Controls.Add(btnGenerarPDF);
            Controls.Add(btnLimpiar);
            Controls.Add(rtbRespuesta);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardarHistorial);
            Controls.Add(lblRespuesta);
            Controls.Add(lblPregunta);
            Controls.Add(txtPregunta);
            Controls.Add(btnConsultar);
            Controls.Add(lblTituloG);
            DoubleBuffered = true;
            Name = "AsistenteGanaderoForm";
            Text = "AsistenteGanaderoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private RichTextBox rtbRespuesta;
        private Button btnCerrar;
        private Button btnGuardarHistorial;
        private Label lblRespuesta;
        private Label lblPregunta;
        private TextBox txtPregunta;
        private Button btnConsultar;
        private Label lblTituloG;
        private Button btnGenerarPDF;
        private Button btnAbrirCarpetaPDF;
    }
}