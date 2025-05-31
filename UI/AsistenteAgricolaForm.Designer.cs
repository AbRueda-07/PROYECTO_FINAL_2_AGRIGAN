namespace AgriGanAsistenteJutiapa.UI
{
    partial class AsistenteAgricolaForm
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
            btnCerrar = new Button();
            btnGuardarHistorial = new Button();
            lblRespuesta = new Label();
            lblPregunta = new Label();
            txtConsulta = new TextBox();
            btnConsultar = new Button();
            lblTituloR = new Label();
            rtbRespuesta = new RichTextBox();
            btnLimpiar = new Button();
            btnGenerarPDF = new Button();
            btnAbrirCarpetaPDF = new Button();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnCerrar.Location = new Point(941, 17);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 19;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnGuardarHistorial
            // 
            btnGuardarHistorial.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnGuardarHistorial.Location = new Point(319, 495);
            btnGuardarHistorial.Name = "btnGuardarHistorial";
            btnGuardarHistorial.Size = new Size(144, 59);
            btnGuardarHistorial.TabIndex = 18;
            btnGuardarHistorial.Text = "Guardar en historial\n\n";
            btnGuardarHistorial.UseVisualStyleBackColor = true;
            btnGuardarHistorial.Click += btnGuardarHistorial_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.BackColor = Color.PaleGoldenrod;
            lblRespuesta.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblRespuesta.Location = new Point(65, 203);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(116, 21);
            lblRespuesta.TabIndex = 14;
            lblRespuesta.Text = "Respuesta:";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.PaleGoldenrod;
            lblPregunta.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblPregunta.Location = new Point(29, 147);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(325, 21);
            lblPregunta.TabIndex = 13;
            lblPregunta.Text = "Escribe tu consulta agrícola:\n";
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(360, 141);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(486, 27);
            txtConsulta.TabIndex = 12;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnConsultar.Location = new Point(161, 495);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(131, 59);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblTituloR
            // 
            lblTituloR.AutoSize = true;
            lblTituloR.BackColor = Color.Khaki;
            lblTituloR.Font = new Font("Perpetua Titling MT", 22F, FontStyle.Bold);
            lblTituloR.Location = new Point(418, 17);
            lblTituloR.Name = "lblTituloR";
            lblTituloR.Size = new Size(448, 44);
            lblTituloR.TabIndex = 10;
            lblTituloR.Text = "ASISTENTE AGRÍCOLA";
            // 
            // rtbRespuesta
            // 
            rtbRespuesta.Location = new Point(65, 227);
            rtbRespuesta.Name = "rtbRespuesta";
            rtbRespuesta.Size = new Size(781, 228);
            rtbRespuesta.TabIndex = 20;
            rtbRespuesta.Text = "";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnLimpiar.Location = new Point(676, 495);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 59);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnGenerarPDF.Location = new Point(484, 495);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(144, 59);
            btnGenerarPDF.TabIndex = 22;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = true;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // btnAbrirCarpetaPDF
            // 
            btnAbrirCarpetaPDF.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnAbrirCarpetaPDF.Location = new Point(891, 323);
            btnAbrirCarpetaPDF.Name = "btnAbrirCarpetaPDF";
            btnAbrirCarpetaPDF.Size = new Size(144, 59);
            btnAbrirCarpetaPDF.TabIndex = 23;
            btnAbrirCarpetaPDF.Text = "Abrir Carpeta";
            btnAbrirCarpetaPDF.UseVisualStyleBackColor = true;
            btnAbrirCarpetaPDF.Click += btnAbrirCarpetaPDF_Click_1;
            // 
            // AsistenteAgricolaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_05_26_222850;
            ClientSize = new Size(1044, 611);
            Controls.Add(btnAbrirCarpetaPDF);
            Controls.Add(btnGenerarPDF);
            Controls.Add(btnLimpiar);
            Controls.Add(rtbRespuesta);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardarHistorial);
            Controls.Add(lblRespuesta);
            Controls.Add(lblPregunta);
            Controls.Add(txtConsulta);
            Controls.Add(btnConsultar);
            Controls.Add(lblTituloR);
            Name = "AsistenteAgricolaForm";
            Text = "AsistenteAgricolaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnGuardarHistorial;
        private Label lblRespuesta;
        private Label lblPregunta;
        private TextBox txtConsulta;
        private Button btnConsultar;
        private Label lblTituloR;
        private RichTextBox rtbRespuesta;
        private Button btnLimpiar;
        private Button btnGenerarPDF;
        private Button btnAbrirCarpetaPDF;
    }
}