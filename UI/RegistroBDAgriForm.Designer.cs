
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AgriGanAsistenteJutiapa.Models;

namespace AgriGanAsistenteJutiapa.UI
{
    partial class RegistroBDAgriForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbRegistros;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbRegistros = new ComboBox();
            dgvRegistros = new DataGridView();
            btnEliminar = new Button();
            btnCerrar = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // cmbRegistros
            // 
            cmbRegistros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegistros.Font = new Font("PMingLiU-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRegistros.FormattingEnabled = true;
            cmbRegistros.Location = new Point(42, 77);
            cmbRegistros.Margin = new Padding(4, 5, 4, 5);
            cmbRegistros.Name = "cmbRegistros";
            cmbRegistros.Size = new Size(426, 25);
            cmbRegistros.TabIndex = 0;
            cmbRegistros.SelectedIndexChanged += cmbRegistros_SelectedIndexChanged;
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToDeleteRows = false;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistros.BackgroundColor = SystemColors.ControlLightLight;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(42, 138);
            dgvRegistros.Margin = new Padding(4, 5, 4, 5);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.Size = new Size(1600, 690);
            dgvRegistros.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnEliminar.Location = new Point(42, 859);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(171, 54);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold);
            btnCerrar.Location = new Point(258, 859);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(171, 54);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Cornsilk;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(38, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(349, 32);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Registros de la Base de Datos";
            // 
            // RegistroBDAgriForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_05_26_223207;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1686, 951);
            Controls.Add(lblTitulo);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvRegistros);
            Controls.Add(cmbRegistros);
            DoubleBuffered = true;
            Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegistroBDAgriForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroBDAgriForm";
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

