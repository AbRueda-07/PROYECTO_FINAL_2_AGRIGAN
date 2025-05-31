using AgriGanAsistenteJutiapa.Models;
using AgriGanAsistenteJutiapa.Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Diagnostics;
using System.IO;

namespace AgriGanAsistenteJutiapa.UI
{
    public partial class AsistenteAgricolaForm : Form
    {
        private readonly Usuario usuarioActivo;
        private readonly OpenAIService openAIService = new OpenAIService();
        private readonly ConsultaService consultaService = new ConsultaService();
        private readonly string carpetaPDF = @"C:\PROYECTOS - PROGRAMACIÓN C#\PROYECTO_FINAL_2_AGRIGAN\AgriGanAsistenteJutiapa\AgriGanAsistenteJutiapa\PDF generados _ resultados";

        public AsistenteAgricolaForm(Usuario usuario)
        {
            InitializeComponent();
            usuarioActivo = usuario;
            limpiarCampos();

            // Asegúrate de que la carpeta exista
            if (!Directory.Exists(carpetaPDF))
            {
                Directory.CreateDirectory(carpetaPDF);
            }
        }

        private void limpiarCampos()
        {
            txtConsulta.Clear();
            rtbRespuesta.Clear();
            txtConsulta.Focus();
        }


        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {

            try
            {
                Document doc = new Document(PageSize.A4, 40, 40, 60, 40);
                string nombreArchivo = $"AsistenciaAgricola_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
                string rutaArchivo = Path.Combine(carpetaPDF, nombreArchivo);

                PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.Open();

                // Título
                iTextSharp.text.Font fontTitle = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
                Paragraph pTitulo = new Paragraph("ASISTENTE AGRICOLA", fontTitle)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(pTitulo);
                doc.Add(new Paragraph("\n"));

                // Contenido
                iTextSharp.text.Font fontNormal = iTextSharp.text.FontFactory.GetFont("Arial", 12);
                doc.Add(new Paragraph($"Consulta: {txtConsulta.Text}", fontNormal));
                doc.Add(new Paragraph($"Respuesta:", fontNormal));
                doc.Add(new Paragraph(rtbRespuesta.Text, fontNormal));

                doc.Close();
                MessageBox.Show("✅ PDF generado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al generar PDF: {ex.Message}");
            }
        }
           

        private void btnAbrirCarpetaPDF_Click_1(object sender, EventArgs e)
        {
            string carpetaDestino = @"C:\PROYECTOS - PROGRAMACIÓN C#\PROYECTO_FINAL_2_AGRIGAN\AgriGanAsistenteJutiapa\AgriGanAsistenteJutiapa\PDF generados _ resultados";

            if (Directory.Exists(carpetaDestino))
            {
                Process.Start("explorer.exe", carpetaDestino);
            }
            else
            {
                MessageBox.Show("No hay PDFs generados aún.", "Carpeta vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

             private void btnGuardarHistorial_Click(object sender, EventArgs e)
              {
            bool exito = consultaService.GuardarConsulta(usuarioActivo.Id, "Agrícola", txtConsulta.Text, rtbRespuesta.Text);
            MessageBox.Show(exito ? "Consulta guardada correctamente." : "No se pudo guardar la consulta.");
        
             }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            string pregunta = txtConsulta.Text.Trim();

            if (string.IsNullOrWhiteSpace(pregunta))
            {
                MessageBox.Show("Por favor, escribe una consulta válida.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rtbRespuesta.Text = "🧠 Analizando con IA...";

            try
            {
                string systemMessage = "Eres un experto en cultivos. Proporciona respuestas técnicas claras.";
                string respuesta = await openAIService.ConsultarIA(pregunta, systemMessage);

                if (string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show("⚠️ La IA no devolvió resultados. Inténtalo nuevamente.");
                    return;
                }

                rtbRespuesta.Text = respuesta;
            }
            catch (Exception ex)
            {
                rtbRespuesta.Text = "Hubo un error al consultar con IA.";
                MessageBox.Show($"❌ Error al analizar con IA: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}