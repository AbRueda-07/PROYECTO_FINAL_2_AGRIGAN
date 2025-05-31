namespace AgriGanAsistenteJutiapa.UI
{
    partial class RegistrarForm
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
            lblTituloR = new Label();
            btnRegistrar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblCorreo = new Label();
            lblContrasenia = new Label();
            txtCorreo = new TextBox();
            txtContrasenia = new TextBox();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            btnRegresarLogin = new Button();
            SuspendLayout();
            // 
            // lblTituloR
            // 
            lblTituloR.AutoSize = true;
            lblTituloR.BackColor = Color.Gainsboro;
            lblTituloR.Font = new Font("Perpetua Titling MT", 22F, FontStyle.Bold);
            lblTituloR.Location = new Point(292, 60);
            lblTituloR.Name = "lblTituloR";
            lblTituloR.Size = new Size(229, 44);
            lblTituloR.TabIndex = 0;
            lblTituloR.Text = "REGISTRO ";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnRegistrar.Location = new Point(189, 430);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(125, 53);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(253, 170);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(323, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ButtonFace;
            lblNombre.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblNombre.Location = new Point(146, 176);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(95, 21);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = SystemColors.ButtonFace;
            lblCorreo.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblCorreo.Location = new Point(146, 254);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(90, 21);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.BackColor = SystemColors.ButtonFace;
            lblContrasenia.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblContrasenia.Location = new Point(146, 327);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(140, 21);
            lblContrasenia.TabIndex = 5;
            lblContrasenia.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(253, 248);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(323, 27);
            txtCorreo.TabIndex = 6;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(292, 321);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(180, 27);
            txtContrasenia.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnLimpiar.Location = new Point(512, 430);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(125, 53);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnCerrar.Location = new Point(659, 27);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRegresarLogin
            // 
            btnRegresarLogin.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnRegresarLogin.Location = new Point(347, 430);
            btnRegresarLogin.Name = "btnRegresarLogin";
            btnRegresarLogin.Size = new Size(125, 53);
            btnRegresarLogin.TabIndex = 10;
            btnRegresarLogin.Text = "Regresar a Login";
            btnRegresarLogin.UseVisualStyleBackColor = true;
            btnRegresarLogin.Click += btnRegresarLogin_Click;
            // 
            // RegistrarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources._11;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(765, 520);
            Controls.Add(btnRegresarLogin);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtContrasenia);
            Controls.Add(txtCorreo);
            Controls.Add(lblContrasenia);
            Controls.Add(lblCorreo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnRegistrar);
            Controls.Add(lblTituloR);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Name = "RegistrarForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloR;
        private Button btnRegistrar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblCorreo;
        private Label lblContrasenia;
        private TextBox txtCorreo;
        private TextBox txtContrasenia;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Button btnRegresarLogin;
    }
}