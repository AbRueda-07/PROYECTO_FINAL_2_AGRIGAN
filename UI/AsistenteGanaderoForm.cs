using AgriGanAsistenteJutiapa.Models;
using AgriGanAsistenteJutiapa.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;

namespace AgriGanAsistenteJutiapa.UI
{
    public partial class AsistenteGanaderoForm : Form
    {
        private readonly Usuario usuarioActivo;
        private readonly OpenAIService openAIService = new OpenAIService();
        private readonly ConsultaService consultaService = new ConsultaService();
        private readonly string carpetaPDF = @"C:\PROYECTOS - PROGRAMACIÓN C#\PROYECTO_FINAL_2_AGRIGAN\AgriGanAsistenteJutiapa\AgriGanAsistenteJutiapa\PDF generados _ resultados";

        public AsistenteGanaderoForm(Usuario usuario)
        {
            InitializeComponent();
            usuarioActivo = usuario;
            Limpiar();

            if (!Directory.Exists(carpetaPDF))
            {
                Directory.CreateDirectory(carpetaPDF);
            }
        }

        public void Limpiar()
        {
            txtPregunta.Clear();
            rtbRespuesta.Clear();
            txtPregunta.Focus();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            string pregunta = txtPregunta.Text.Trim();

            if (string.IsNullOrWhiteSpace(pregunta))
            {
                MessageBox.Show("Por favor, escribe una consulta.");
                return;
            }

            rtbRespuesta.Text = "Consultando inteligencia artificial...";

            string prompt = "Eres un veterinario experto en ganadería. Responde con consejos técnicos claros y accesibles para pequeños ganaderos.";
            string respuesta = await openAIService.ConsultarIA(pregunta, prompt);

            rtbRespuesta.Text = respuesta;
        }

        private void btnGuardarHistorial_Click(object sender, EventArgs e)
        {
            bool exito = consultaService.GuardarConsulta(usuarioActivo.Id, "Ganadera", txtPregunta.Text, rtbRespuesta.Text);
            MessageBox.Show(exito ? "Consulta guardada correctamente." : "No se pudo guardar la consulta.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(PageSize.A4, 40, 40, 60, 40);
                string nombreArchivo = $"AsistenciaGanadera_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
                string rutaArchivo = Path.Combine(carpetaPDF, nombreArchivo);

                PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.Open();

                // Título
                iTextSharp.text.Font fontTitle = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
                Paragraph pTitulo = new Paragraph("ASISTENTE GANADERO", fontTitle)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(pTitulo);
                doc.Add(new Paragraph("\n"));

                // Contenido
                iTextSharp.text.Font fontNormal = iTextSharp.text.FontFactory.GetFont("Arial", 12);
                doc.Add(new Paragraph($"Consulta: {txtPregunta.Text}", fontNormal));
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
    }
}
    

