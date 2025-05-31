using AgriGanAsistenteJutiapa.Models;
using AgriGanAsistenteJutiapa.Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AgriGanAsistenteJutiapa.UI
{
    public partial class AgriPredictForm : Form
    {
        private readonly Usuario usuario;
        private readonly OpenAIService openAI = new OpenAIService();
        private readonly string carpetaPDF = @"C:\PROYECTOS - PROGRAMACIÓN C#\PROYECTO_FINAL_2_AGRIGAN\AgriGanAsistenteJutiapa\AgriGanAsistenteJutiapa\PDF_Guardados";

        public AgriPredictForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            LimpiarCampos();

            // Crear carpeta si no existe
            if (!Directory.Exists(carpetaPDF))
            {
                try
                {
                    Directory.CreateDirectory(carpetaPDF);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo crear la carpeta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnAnalizar_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipo.SelectedItem?.ToString();
            string nombre = txtNombre.Text.Trim();
            string edad = txtEdad.Text.Trim();
            string clima = txtClima.Text.Trim();
            string observaciones = txtObservaciones.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(edad))
            {
                MessageBox.Show("Por favor completa al menos el nombre y edad.",
                    "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rtbResultado.Text = "⏳ Analizando con IA...";

            string prompt = $@"Tipo: {tipo}
Nombre: {nombre}
Edad o días de siembra: {edad}
Clima: {clima}
Observaciones: {observaciones}

Con base en esta información, ¿qué problemas podrían presentarse y qué recomendaciones darías para prevenirlos o tratarlos?";

            string systemMessage = tipo == "Agricultura"
                ? "Eres un experto en cultivos. Analiza y brinda consejos según clima, edad y síntomas."
                : "Eres un veterinario experto. Analiza los síntomas y da recomendaciones.";

            string respuesta = await openAI.ConsultarIA(prompt, systemMessage);
            rtbResultado.Text = respuesta;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Opcional: puedes limpiar campos al cambiar de categoría
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtClima.Clear();
            txtObservaciones.Clear();
            rtbResultado.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipo.SelectedItem?.ToString();
            string nombre = txtNombre.Text.Trim();
            string edad = txtEdad.Text.Trim(); // ✅ Ahora puede contener "2 meses", "45 días", etc.
            string clima = txtClima.Text.Trim();
            string observaciones = txtObservaciones.Text.Trim();
            string resultadoIA = rtbResultado.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(edad))
            {
                MessageBox.Show("Por favor completa al menos los campos Nombre y Edad.",
                    "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var registro = new AsistentePredictivoIA
            {
                UsuarioId = usuario.Id,
                Tipo = tipo,
                Nombre = nombre,
                EdadODiasSiembra = edad, // ✅ Guardado como string
                Clima = clima,
                Observaciones = observaciones,
                RespuestaIA = resultadoIA,
                Fecha = DateTime.Now
            };

            var service = new AsistentePredictivoService();
            bool guardado = service.GuardarRegistro(registro);

            if (guardado)
            {
                MessageBox.Show("✅ Registro guardado correctamente.");
                
            }
            else
            {
                MessageBox.Show("❌ Error al guardar el registro.");
            }
        }
        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipo.SelectedItem?.ToString();
            string nombre = txtNombre.Text.Trim();
            string edad = txtEdad.Text.Trim();
            string clima = txtClima.Text.Trim();
            string observaciones = txtObservaciones.Text.Trim();
            string resultadoIA = rtbResultado.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(edad))
            {
                MessageBox.Show("Por favor completa los campos Nombre y Edad.",
                    "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Document doc = new Document(PageSize.A4, 40, 40, 60, 40);
                string nombreArchivo = $"PrediccionIA_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
                string rutaArchivo = Path.Combine(carpetaPDF, nombreArchivo);

                PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.Open();

                // Título
                iTextSharp.text.Font fontTitle = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
                Paragraph pTitulo = new Paragraph("ASISTENTE INTELIGENTE PREDICTIVO", fontTitle)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(pTitulo);
                doc.Add(new Paragraph("\n"));

                // Contenido
                iTextSharp.text.Font fontNormal = FontFactory.GetFont("Arial", 12);
                doc.Add(new Paragraph($"Nombre: {nombre}", fontNormal));
                doc.Add(new Paragraph($"Edad/Días desde siembra: {edad}", fontNormal));
                doc.Add(new Paragraph($"Clima: {clima}", fontNormal));
                doc.Add(new Paragraph($"Observaciones: {observaciones}\n", fontNormal));
                doc.Add(new Paragraph($"Resultado del Análisis:", fontNormal));
                doc.Add(new Paragraph(resultadoIA, fontNormal));

                doc.Close();

                MessageBox.Show("✅ PDF generado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al generar PDF: {ex.Message}");
            }
        }

        private void btnAbrirCarpetaPDF_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(carpetaPDF))
            {
                Process.Start("explorer.exe", carpetaPDF);
            }
            else
            {
                MessageBox.Show("La carpeta aún no existe. Primero genera un PDF.",
                    "Carpeta no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}