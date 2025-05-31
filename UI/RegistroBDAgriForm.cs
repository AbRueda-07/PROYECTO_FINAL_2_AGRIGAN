using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AgriGanAsistenteJutiapa.Services;
using AgriGanAsistenteJutiapa.Models;
using Microsoft.Data.SqlClient;

namespace AgriGanAsistenteJutiapa.UI
{
    public partial class RegistroBDAgriForm : Form
    {
        private readonly AnimalService animalService = new AnimalService();
        private readonly CultivoService cultivoService = new CultivoService();
        private readonly AsistentePredictivoService predictivoService = new AsistentePredictivoService();
        private readonly ConsultaService consultaService = new ConsultaService();
        private readonly FichaTecnicaService fichaService = new FichaTecnicaService();

        public RegistroBDAgriForm()
        {
            InitializeComponent();
            cmbRegistros.Items.AddRange(new[]
    {
        "Animales",
        "Cultivos",
        "AsistentePredictivoIA",
        "ConsultasIA",
    });

            // Solo establecer SelectedIndex si hay elementos
            if (cmbRegistros.Items.Count > 0)
                cmbRegistros.SelectedIndex = 0;

            CargarRegistros();
        }

        private void CargarRegistros()
        {
            dgvRegistros.DataSource = null;
            string tabla = cmbRegistros.SelectedItem?.ToString();

            try
            {
                switch (tabla)
                {
                    case "Animales":
                        dgvRegistros.DataSource = animalService.ObtenerTodos();
                        break;
                    case "Cultivos":
                        dgvRegistros.DataSource = cultivoService.ObtenerTodos();
                        break;
                    case "AsistentePredictivoIA":
                        dgvRegistros.DataSource = predictivoService.ObtenerTodos();
                        break;
                    case "ConsultasIA":
                        dgvRegistros.DataSource = consultaService.ObtenerTodas();
                        break;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar registros: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un registro para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Deseas eliminar el registro seleccionado?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                int id = Convert.ToInt32(dgvRegistros.SelectedRows[0].Cells["Id"].Value);
                string tabla = cmbRegistros.SelectedItem?.ToString();
                bool eliminado = false;

                switch (tabla)
                {
                    case "Animales":
                        eliminado = animalService.Eliminar(id);
                        break;
                    case "Cultivos":
                        eliminado = cultivoService.Eliminar(id);
                        break;
                    case "AsistentePredictivoIA":
                        eliminado = predictivoService.EliminarRegistro(id);
                        break;
                    case "ConsultasIA":
                        eliminado = consultaService.EliminarConsulta(id);
                        break;
                    
                }

                if (eliminado)
                {
                    MessageBox.Show("Registro eliminado correctamente.");
                    CargarRegistros();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarRegistros();

        }
    }
}
