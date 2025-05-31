namespace AgriGanAsistenteJutiapa.UI
{
    partial class FichasTecnicasForm
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
            lblFichas = new Label();
            cmbCategoria = new ComboBox();
            lstFichasDisponibles = new ListBox();
            btnCerrar = new Button();
            lblCategoria = new Label();
            lblContenidoF = new Label();
            lblLista = new Label();
            rtbContenidoFicha = new RichTextBox();
            txtConsulta = new TextBox();
            label1 = new Label();
            btnLimpiar = new Button();
            btnGuardarFicha = new Button();
            btnAnalizarIA = new Button();
            btnEliminarFichaTecnica = new Button();
            SuspendLayout();
            // 
            // lblFichas
            // 
            lblFichas.AutoSize = true;
            lblFichas.BackColor = Color.Khaki;
            lblFichas.Font = new Font("Perpetua Titling MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFichas.Location = new Point(483, 9);
            lblFichas.Name = "lblFichas";
            lblFichas.Size = new Size(369, 44);
            lblFichas.TabIndex = 0;
            lblFichas.Text = "FICHAS TÉCNICAS";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(57, 167);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(229, 26);
            cmbCategoria.TabIndex = 1;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // lstFichasDisponibles
            // 
            lstFichasDisponibles.BackColor = Color.BurlyWood;
            lstFichasDisponibles.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstFichasDisponibles.FormattingEnabled = true;
            lstFichasDisponibles.ItemHeight = 17;
            lstFichasDisponibles.Items.AddRange(new object[] { "Maíz", "Frijol", "Maicillo", "Milpa", "Arroz", "Caña de Azúcar", "Tomate", "Pepino", "Piña", "Ayote", "Papaya", "Limón", "Mango", "Plátano", "Guayaba", "Silo", "Heno", "Pasto(Kikuyo)", "Pasto(Estrella)", "Pasto(Pangola)", "Maíz Forrajero", "Maicillo Forrajero", "Sorgo Forrajero", "Fiebre Aftosa", "Brucelosis", "Tuberculosis Bovina", "Antrax", "Rabia Bovina", "Lengua Azul", "Cacho Hueco", "Leucosis Bovina", "Mastitis", "Peste Bovina", "Derregue", "Buhas", "Guzano Barrenador", "La vaca Loca", "Anemia Infecciosa Equina", "Rabia Equina", "Influenza Equina", "Tétanos", "Diarrea Vírica", "Estomatitis Vesicular", "Gripe Aviar", "Enfermedad de Newcastle", "Colibacilosis", "Viruela Aviar", "Coccidiosis", "Salmonelosis", "Micoplasmosis Aviar", "Coriza Infecciosa", "Peste Porcina Clásica", "Fiebre Aftosa", "Parvovirosis Porcina", "Erisipela Suína", "Colibacilosis Neonatal ", "Colibacilosis Postdestete", "Acariasis", "Cysticercosis" });
            lstFichasDisponibles.Location = new Point(942, 217);
            lstFichasDisponibles.Name = "lstFichasDisponibles";
            lstFichasDisponibles.Size = new Size(372, 531);
            lstFichasDisponibles.TabIndex = 3;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnCerrar.Location = new Point(1228, 17);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(108, 36);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Khaki;
            lblCategoria.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblCategoria.Location = new Point(55, 127);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(116, 21);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoría";
            // 
            // lblContenidoF
            // 
            lblContenidoF.AutoSize = true;
            lblContenidoF.BackColor = Color.Khaki;
            lblContenidoF.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblContenidoF.Location = new Point(57, 353);
            lblContenidoF.Name = "lblContenidoF";
            lblContenidoF.Size = new Size(247, 21);
            lblContenidoF.TabIndex = 6;
            lblContenidoF.Text = "Contenido de la Ficha:";
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.BackColor = Color.Khaki;
            lblLista.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            lblLista.Location = new Point(942, 183);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(287, 21);
            lblLista.TabIndex = 7;
            lblLista.Text = "Lista de Fichas Disponibles:";
            // 
            // rtbContenidoFicha
            // 
            rtbContenidoFicha.Location = new Point(57, 385);
            rtbContenidoFicha.Name = "rtbContenidoFicha";
            rtbContenidoFicha.Size = new Size(624, 340);
            rtbContenidoFicha.TabIndex = 8;
            rtbContenidoFicha.Text = "";
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(57, 274);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(624, 27);
            txtConsulta.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            label1.Location = new Point(57, 235);
            label1.Name = "label1";
            label1.Size = new Size(411, 21);
            label1.TabIndex = 10;
            label1.Text = "Escriba Enfermedad / Cultivo/Forraje: ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(732, 692);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(145, 56);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardarFicha
            // 
            btnGuardarFicha.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarFicha.Location = new Point(732, 524);
            btnGuardarFicha.Name = "btnGuardarFicha";
            btnGuardarFicha.Size = new Size(145, 56);
            btnGuardarFicha.TabIndex = 14;
            btnGuardarFicha.Text = "Guardar Ficha";
            btnGuardarFicha.UseVisualStyleBackColor = true;
            btnGuardarFicha.Click += btnGuardarFicha_Click;
            // 
            // btnAnalizarIA
            // 
            btnAnalizarIA.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalizarIA.Location = new Point(732, 441);
            btnAnalizarIA.Name = "btnAnalizarIA";
            btnAnalizarIA.Size = new Size(145, 56);
            btnAnalizarIA.TabIndex = 17;
            btnAnalizarIA.Text = "Analizar con IA";
            btnAnalizarIA.UseVisualStyleBackColor = true;
            btnAnalizarIA.Click += btnAnalizarIA_Click_1;
            // 
            // FichasTecnicasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_05_26_223832;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1348, 876);
            Controls.Add(btnEliminarFichaTecnica);
            Controls.Add(btnAnalizarIA);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardarFicha);
            Controls.Add(label1);
            Controls.Add(txtConsulta);
            Controls.Add(rtbContenidoFicha);
            Controls.Add(lblLista);
            Controls.Add(lblContenidoF);
            Controls.Add(lblCategoria);
            Controls.Add(btnCerrar);
            Controls.Add(lstFichasDisponibles);
            Controls.Add(cmbCategoria);
            Controls.Add(lblFichas);
            DoubleBuffered = true;
            Name = "FichasTecnicasForm";
            Text = "FichasTecnicasForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblFichas;
        private ComboBox cmbCategoria;
        private ListBox lstFichasDisponibles;
        private Button btnCerrar;
        private Label lblCategoria;
        private Label lblContenidoF;
        private Label lblLista;
        private RichTextBox rtbContenidoFicha;
        private TextBox txtConsulta;
        private Label label1;
        private Button btnLimpiar;
        private Button btnGuardarFicha;
        private Button btnAnalizarIA;
        private Button btnEliminarFichaTecnica;
    }
}