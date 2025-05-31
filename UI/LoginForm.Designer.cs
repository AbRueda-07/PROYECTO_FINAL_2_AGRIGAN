namespace AgriGanAsistenteJutiapa.UI
{
    partial class LoginForm
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
            btnLimpiar = new Button();
            txtContrasenia = new TextBox();
            txtCorreo = new TextBox();
            lblContrasenia = new Label();
            lblCorreo = new Label();
            btnLoginIn = new Button();
            lblTituloR = new Label();
            btnRegistrarse = new Button();
            pbToggleClave = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbToggleClave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnCerrar.Location = new Point(573, 31);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 19;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnLimpiar.Location = new Point(443, 446);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 50);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(226, 260);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(229, 27);
            txtContrasenia.TabIndex = 17;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(187, 187);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(323, 27);
            txtCorreo.TabIndex = 16;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.BackColor = Color.AntiqueWhite;
            lblContrasenia.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblContrasenia.Location = new Point(80, 266);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(140, 21);
            lblContrasenia.TabIndex = 15;
            lblContrasenia.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.AntiqueWhite;
            lblCorreo.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblCorreo.Location = new Point(80, 193);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(90, 21);
            lblCorreo.TabIndex = 14;
            lblCorreo.Text = "Correo:";
            // 
            // btnLoginIn
            // 
            btnLoginIn.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnLoginIn.Location = new Point(123, 446);
            btnLoginIn.Name = "btnLoginIn";
            btnLoginIn.Size = new Size(135, 50);
            btnLoginIn.TabIndex = 11;
            btnLoginIn.Text = "Inicia Sesión";
            btnLoginIn.UseVisualStyleBackColor = true;
            btnLoginIn.Click += btnLoginIn_Click;
            // 
            // lblTituloR
            // 
            lblTituloR.AutoSize = true;
            lblTituloR.BackColor = Color.AntiqueWhite;
            lblTituloR.Font = new Font("Perpetua Titling MT", 22F, FontStyle.Bold);
            lblTituloR.Location = new Point(278, 31);
            lblTituloR.Name = "lblTituloR";
            lblTituloR.Size = new Size(146, 44);
            lblTituloR.TabIndex = 10;
            lblTituloR.Text = "LOGIN";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnRegistrarse.Location = new Point(278, 446);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(146, 50);
            btnRegistrarse.TabIndex = 20;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // pbToggleClave
            // 
            pbToggleClave.BackColor = Color.Transparent;
            pbToggleClave.BackgroundImage = Properties.Resources.eye_off;
            pbToggleClave.BackgroundImageLayout = ImageLayout.Stretch;
            pbToggleClave.Cursor = Cursors.Hand;
            pbToggleClave.Location = new Point(412, 266);
            pbToggleClave.Name = "pbToggleClave";
            pbToggleClave.Size = new Size(25, 18);
            pbToggleClave.SizeMode = PictureBoxSizeMode.StretchImage;
            pbToggleClave.TabIndex = 21;
            pbToggleClave.TabStop = false;
            pbToggleClave.Click += pbToggleClave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.eye;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(412, 266);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pbToggleClave_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_05_26_222424;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(699, 617);
            Controls.Add(pbToggleClave);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtContrasenia);
            Controls.Add(txtCorreo);
            Controls.Add(lblContrasenia);
            Controls.Add(lblCorreo);
            Controls.Add(btnLoginIn);
            Controls.Add(lblTituloR);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbToggleClave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnLimpiar;
        private TextBox txtContrasenia;
        private TextBox txtCorreo;
        private Label lblContrasenia;
        private Label lblCorreo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnLoginIn;
        private Label lblTituloR;
        private Button btnRegistrarse;
        private PictureBox pbToggleClave;
        private PictureBox pictureBox1;
    }
}