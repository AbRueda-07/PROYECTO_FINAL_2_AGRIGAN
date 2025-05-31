using AgriGanAsistenteJutiapa.Models;
using AgriGanAsistenteJutiapa.Services;
using System;
using System.Windows.Forms;

namespace AgriGanAsistenteJutiapa.UI
{
    public partial class RegistrosDatosForm : Form
    {
        private readonly Usuario usuarioActivo;
        private readonly CultivoService cultivoService = new CultivoService();
        private readonly AnimalService animalService = new AnimalService();

        public RegistrosDatosForm(Usuario usuario)
        {
            InitializeComponent();
            usuarioActivo = usuario;

            cmbTipoRegistro.Items.AddRange(new[] { "Cultivo", "Animal" });
            cmbTipoRegistro.SelectedIndex = 0;

            // Configurar visibilidad inicial
            MostrarPanelSeleccionado();
        }

        private void MostrarPanelSeleccionado()
        {
            pnCultivo.Visible = cmbTipoRegistro.SelectedItem.ToString() == "Cultivo";
            pnAnimal.Visible = cmbTipoRegistro.SelectedItem.ToString() == "Animal";
        }

        private void RegistrosDatosForm_Load(object sender, EventArgs e)
        {
            // Inicialización adicional si es necesario
        }

        private void cmbTipoRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarPanelSeleccionado();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoSeleccionado = cmbTipoRegistro.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(tipoSeleccionado))
                {
                    MessageBox.Show("Seleccione un tipo de registro válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tipoSeleccionado == "Cultivo")
                {
                    // Validar campos obligatorios
                    if (string.IsNullOrWhiteSpace(txtNombreCult.Text) ||
                        string.IsNullOrWhiteSpace(txtTipoCult.Text) ||
                        string.IsNullOrWhiteSpace(txtSintomas.Text) ||
                        string.IsNullOrWhiteSpace(txtTratamiento.Text))
                    {
                        MessageBox.Show("Por favor complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var cultivo = new Cultivo
                    {
                        UsuarioId = usuarioActivo.Id,
                        Nombre = txtNombreCult.Text.Trim(),
                        Tipo = txtTipoCult.Text.Trim(),
                        Sintomas = txtSintomas.Text.Trim(),
                        Tratamientos = txtTratamiento.Text.Trim()
                    };

                    bool registrado = cultivoService.RegistrarCultivo(cultivo);

                    if (registrado)
                    {
                        MessageBox.Show("Cultivo guardado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el cultivo.");
                    }
                }
                else if (tipoSeleccionado == "Animal")
                {
                    // Validar campos obligatorios
                    if (string.IsNullOrWhiteSpace(txtEspecie.Text) ||
                        string.IsNullOrWhiteSpace(txtRaza.Text) ||
                        string.IsNullOrWhiteSpace(txtEnfermedad.Text) ||
                        string.IsNullOrWhiteSpace(txtTratAnimal.Text))
                    {
                        MessageBox.Show("Por favor complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var animal = new Animal
                    {
                        UsuarioId = usuarioActivo.Id,
                        Especie = txtEspecie.Text.Trim(),
                        Raza = txtRaza.Text.Trim(),
                        Edad = (int)nudEdad.Value,
                        Enfermedades = txtEnfermedad.Text.Trim(),
                        Tratamientos = txtTratAnimal.Text.Trim()
                    };

                    bool registrado = animalService.RegistrarAnimal(animal);

                    if (registrado)
                    {
                        MessageBox.Show("Animal guardado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el animal.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}