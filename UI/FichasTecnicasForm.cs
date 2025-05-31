using AgriGanAsistenteJutiapa.Data;
using AgriGanAsistenteJutiapa.Models;
using AgriGanAsistenteJutiapa.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace AgriGanAsistenteJutiapa.UI
{
    public partial class FichasTecnicasForm : Form
    {
        private readonly DatabaseManager db = new DatabaseManager();
        private readonly FichaTecnicaService fichaTecnicaService = new FichaTecnicaService();
        private Dictionary<string, Dictionary<string, string>> fichasTecnicas;

        // Diccionario principal para almacenar todas las fichas técnicas organizadas por categoría
        private readonly Dictionary<string, Dictionary<string, string>> fichasTecnicasPorDefecto = new Dictionary<string, Dictionary<string, string>>()
        {
            ["Cultivos y Forrajes"] = new Dictionary<string, string>()
            {
                ["Maíz"] = "🌽 Ficha Técnica: Maíz\n\nDescripción: Cultivo básico muy importante en alimentación humana y animal.\nSíntomas comunes: Hojas amarillas por falta de nitrógeno.\nTratamiento: Aplicar fertilizantes ricos en nitrógeno",

                ["Frijol"] = "🌱 Ficha Técnica: Frijol\n\nDescripción: Fuente principal de proteínas vegetales.\nSíntomas: Plagas comunes: Trips, pulgones.\nTratamiento: Insecticida natural o químico según intensidad",

                ["Maicillo"] = "🌾 Ficha Técnica: Maicillo\n\nDescripción: Cultivo similar al maíz pero más pequeño y adaptable.\nSíntomas: Puede tener plagas similares al maíz.\nTratamiento: Manejo integrado de plagas",

                ["Milpa"] = "🌽🌾 Ficha Técnica: Milpa\n\nDescripción: Sistema tradicional de cultivo mixto (maíz, frijol, calabaza).\nSíntomas: Puede presentar plagas comunes de maíz.\nTratamiento: Manejo ecológico y rotación de cultivos",

                ["Arroz"] = "🍚 Ficha Técnica: Arroz\n\nDescripción: Cultivo base en muchas dietas, especialmente en zonas tropicales.\nSíntomas: Requiere zonas húmedas o con riego.\nTratamiento: Control de malezas y plagas específicas",

                ["Caña de Azúcar"] = "Ficha Técnica: Caña de Azúcar\n\nDescripción: Principalmente para azúcar y biocombustibles.\nSíntomas: Necesita climas cálidos y suelos fértiles.\nTratamiento: Manejo agronómico y control fitosanitario",

                ["Tomate"] = "🍅 Ficha Técnica: Tomate\n\nDescripción: Variedad ampliamente utilizada en la dieta humana.\nSíntomas: Riego irregular puede causar pudrición apical.\nTratamiento: Riego regular y control de enfermedades fúngicas",

                ["Pepino"] = "🥒 Ficha Técnica: Pepino\n\nDescripción: Cultivo de alto rendimiento en sistemas hidropónicos.\nSíntomas: Puede desarrollar mildiu y ácaros.\nTratamiento: Cultivo en invernadero y manejo integrado de plagas",

                ["Piña"] = "🍍 Ficha Técnica: Piña\n\nDescripción: Fruto tropical rico en vitaminas y antioxidantes.\nSíntomas: Susceptible a heladas y escarabajo de la piña.\nTratamiento: Protección contra heladas y control químico de insectos",

                ["Ayote"] = "🎃 Ficha Técnica: Ayote\n\nDescripción: Cultivo ideal para zonas templadas y de uso culinario.\nSíntomas: Puede afectarse por virus del mosaico.\nTratamiento: Rotación de cultivos y control de insectos vectores",

                ["Papaya"] = " Ficha Técnica: Papaya\n\nDescripción: Árbol frutal de rápido crecimiento.\nSíntomas: Pulgones y enfermedades fúngicas.\nTratamiento: Uso de repelentes naturales y fungicidas",

                ["Limón"] = "🍋 Ficha Técnica: Limón\n\nDescripción: Arbusto perenne utilizado en medicina y gastronomía.\nSíntomas: Requiere clima cálido y suelo ácido.\nTratamiento: Alto rendimiento, ideal para uso culinario y medicinal",

                ["Mango"] = "🥭 Ficha Técnica: Mango\n\nDescripción: Fruto tropical de alto valor nutricional.\nSíntomas: Gusano barrenador es una plaga común.\nTratamiento: Protección temprana y poda sanitaria",

                ["Plátano"] = "🍌 Ficha Técnica: Plátano\n\nDescripción: Similar al banano pero más grande y menos dulce.\nSíntomas: Susceptible a sigatoka negra y fusarium.\nTratamiento: Manejo integrado de enfermedades",

                ["Guayaba"] = " Ficha Técnica: Guayaba\n\nDescripción: Fruto rico en vitamina C y usado en productos naturales.\nSíntomas: Atacado por gusano de la guayaba.\nTratamiento: Manejo cultural y control biológico",

                ["Silo"] = " Ficha Técnica: Silo\n\nDescripción: Alimento conservado mediante fermentación anaeróbica.\nSíntomas: Mal procesamiento reduce calidad nutritiva.\nTratamiento: Secado y fermentación controlada",

                ["Heno"] = "Ficha Técnica: Heno\n\nDescripción: Alimento seco para ganado.\nSíntomas: Componente generalmente alfalfa o trébol.\nTratamiento: Almacenamiento seco y protección contra humedad",

                ["Pasto (Kikuyo)"] = "Ficha Técnica: Pasto (Kikuyo)\n\nDescripción: Resistente al pisoteo y apto para corrales.\nSíntomas: Adaptación a suelos pobres.\nTratamiento: Manejo de carga animal adecuado",

                ["Pasto (Estrella)"] = " Ficha Técnica: Pasto (Estrella)\n\nDescripción: Resiste altas temperaturas y sequías.\nSíntomas: Ideal para regiones secas.\nTratamiento: Siembra en suelos arenosos y poco fértiles",

                ["Pasto (Pangola)"] = " Ficha Técnica: Pasto (Pangola)\n\nDescripción: Alto rendimiento forrajero y tolerancia a pastoreo.\nSíntomas: Se adapta bien a suelos pobres.\nTratamiento: Manejo racional para evitar degradación del suelo",

                ["Maíz Forrajero"] = "🌾🌽 Ficha Técnica: Maíz Forrajero\n\nDescripción: Usado principalmente como alimento para ganado.\nSíntomas: Cortado antes de madurar para mayor contenido energético.\nTratamiento: Manejo integrado de plagas y enfermedades",

                ["Maicillo Forrajero"] = "🌾🌾 Ficha Técnica: Maicillo Forrajero\n\nDescripción: Menor tamaño que el maíz común.\nSíntomas: Usado para alimentación de animales pequeños.\nTratamiento: Manejo sencillo y bajo costo de producción",

                ["Sorgo Forrajero"] = "🌾🌾 Ficha Técnica: Sorgo Forrajero\n\nDescripción: Muy resistente a condiciones climáticas extremas.\nSíntomas: Alto rendimiento en climas cálidos.\nTratamiento: Adecuado para alimentación animal"
            },

            ["Ganado Bovino"] = new Dictionary<string, string>()
            {
                ["Fiebre Aftosa"] = "🐄 Ficha Técnica: Fiebre Aftosa\n\nDescripción: Enfermedad viral altamente contagiosa que afecta rumiantes.\nSíntomas: Ampollas en hocico, lengua y patas.\nTratamiento: Aislamiento del animal, vacuna preventiva",

                ["Brucelosis"] = "🐄 Ficha Técnica: Brucelosis\n\nDescripción: Enfermedad bacteriana grave que puede transmitirse al humano.\nSíntomas: Abortos frecuentes, debilidad.\nTratamiento: No tiene cura, se recomienda eliminación y vacunación del hato",

                ["Tuberculosis Bovina"] = "🐄 Ficha Técnica: Tuberculosis Bovina\n\nDescripción: Enfermedad bacteriana crónica que afecta principalmente los pulmones.\nSíntomas: Pérdida de peso, tos persistente.\nTratamiento: Esterilización y sacrificio de animales infectados",

                ["Antrax"] = "Ficha Técnica: Antrax\n\nDescripción: Enfermedad bacteriana aguda y mortal si no se detecta a tiempo.\nSíntomas: Lesiones cutáneas, fiebre alta.\nTratamiento: Antibióticos y vacunación preventiva",

                ["Rabia Bovina"] = " Ficha Técnica: Rabia Bovina\n\nDescripción: Transmitida por picaduras de murciélagos infectados.\nSíntomas: Comportamiento nervioso, salivación excesiva.\nTratamiento: No hay cura, prevención mediante vacunación",

                ["Lengua Azul"] = " Ficha Técnica: Lengua Azul\n\nDescripción: Enfermedad vírica que afecta bovinos y ovinos.\nSíntomas: Edema en lengua y labios.\nTratamiento: Control vectorial y vacunación",

                ["Cacho Hueco"] = " Ficha Técnica: Cacho Hueco\n\nDescripción: Enfermedad parasitaria que afecta cuernos.\nSíntomas: Lesiones internas en huesos de cuerno.\nTratamiento: Cirugía y antibióticos",

                ["Leucosis Bovina"] = " Ficha Técnica: Leucosis Bovina\n\nDescripción: Enfermedad viral crónica sin cura.\nSíntomas: Linfadenopatía y anemia.\nTratamiento: Control de movilización de ganado",

                ["Mastitis"] = " Ficha Técnica: Mastitis\n\nDescripción: Inflamación de la ubre causada por bacterias.\nSíntomas: Disminución en la producción de leche.\nTratamiento: Antibióticos y medidas higiénicas",

                ["Peste Bovina"] = " Ficha Técnica: Peste Bovina\n\nDescripción: Enfermedad viral erradicada mundialmente.\nSíntomas: Hemorragias internas y diarrea sangrienta.\nTratamiento: Erradicación inmediata del ganado infectado",

                ["Derregue"] = " Ficha Técnica: Derregue\n\nDescripción: Enfermedad digestiva relacionada con cambios bruscos de alimentación.\nSíntomas: Diarrea, pérdida de apetito.\nTratamiento: Suplementación nutricional y manejo de estrés",

                ["Buhas"] = " Ficha Técnica: Buhas\n\nDescripción: Parásitos externos que afectan piel y mucosas.\nSíntomas: Picazón, inflamación localizada.\nTratamiento: Insecticidas tópicos",

                ["Guzano Barrenador"] = " Ficha Técnica: Guzano Barrenador\n\nDescripción: Plaga que daña raíces y tallos de pastos.\nSíntomas: Daño severo en áreas de pastoreo.\nTratamiento: Control químico y biológico",

                ["La vaca Loca"] = " Ficha Técnica: La vaca Loca\n\nDescripción: Enfermedad neurológica degenerativa.\nSíntomas: Temblores, comportamiento agresivo.\nTratamiento: No hay cura, erradicación del ganado infectado"
            },

            ["Equinos"] = new Dictionary<string, string>()
            {
                ["Anemia Infecciosa Equina"] = "🐴 Ficha Técnica: Anemia Infecciosa Equina\n\nDescripción: Enfermedad viral que afecta a caballos y otros equinos.\nSíntomas: Fatiga, pérdida de peso.\nTratamiento: Vacunación preventiva",

                ["Rabia Equina"] = "🐴 Ficha Técnica: Rabia Equina\n\nDescripción: Enfermedad viral mortal transmitida por murciélagos.\nSíntomas: Convulsiones, hiperexcitabilidad.\nTratamiento: No hay cura, prevención mediante vacunación",

                ["Influenza Equina"] = "🐴 Ficha Técnica: Influenza Equina\n\nDescripción: Enfermedad respiratoria vírica contagiosa.\nSíntomas: Tos, fiebre, secreción nasal.\nTratamiento: Medicamentos antivirales",

                ["Tétanos"] = "🐴 Ficha Técnica: Tétanos\n\nDescripción: Enfermedad bacteriana causada por heridas contaminadas.\nSíntomas: Rigidez muscular, convulsiones.\nTratamiento: Vacunación preventiva",

                ["Diarrea Vírica"] = "🐴 Ficha Técnica: Diarrea Vírica\n\nDescripción: Enfermedad intestinal vírica que afecta potros.\nSíntomas: Diarrea severa.\nTratamiento: Rehidratación y soporte médico",

                ["Estomatitis Vesicular"] = "🐴 Ficha Técnica: Estomatitis Vesicular\n\nDescripción: Enfermedad vírica con síntomas vesiculares.\nSíntomas: Vesículas en boca.\nTratamiento: Aislamiento y tratamiento sintomático"
            },

            ["Aves"] = new Dictionary<string, string>()
            {
                ["Gripe Aviar"] = "🐔 Ficha Técnica: Gripe Aviar\n\nDescripción: Enfermedad vírica altamente contagiosa en aves.\nSíntomas: Fiebre, disnea, muerte súbita.\nTratamiento: Antivirales y bioseguridad",

                ["Enfermedad de Newcastle"] = "🐔 Ficha Técnica: Enfermedad de Newcastle\n\nDescripción: Virus neurotrópico que afecta sistema respiratorio y nervioso.\nSíntomas: Tos, diarrea, caída de postura.\nTratamiento: Vacunación preventiva",

                ["Colibacilosis"] = "🐔 Ficha Técnica: Colibacilosis\n\nDescripción: Enfermedad bacteriana causada por *E. coli*.\nSíntomas: Septicemia y muerte súbita.\nTratamiento: Antibióticos y mejora de condiciones de crianza",

                ["Viruela Aviar"] = "🐔 Ficha Técnica: Viruela Aviar\n\nDescripción: Enfermedad vírica que afecta piel y membranas mucosas.\nSíntomas: Vesículas en cabeza y patas.\nTratamiento: Vacunación preventiva",

                ["Coccidiosis"] = "🐔 Ficha Técnica: Coccidiosis\n\nDescripción: Enfermedad parasitaria intestinal.\nSíntomas: Diarrea hemorrágica.\nTratamiento: Antiparasitarios específicos",

                ["Salmonelosis"] = "🐔 Ficha Técnica: Salmonelosis\n\nDescripción: Enfermedad bacteriana que afecta gallinas y pollos.\nSíntomas: Diarrea, anorexia.\nTratamiento: Antibióticos y mejoras en higiene",

                ["Micoplasmosis Aviar"] = "🐔 Ficha Técnica: Micoplasmosis Aviar\n\nDescripción: Infección respiratoria crónica.\nSíntomas: Conjuntivitis, tos, descarga nasal.\nTratamiento: Antibióticos y medidas de bioseguridad",

                ["Coriza Infecciosa"] = "🐔 Ficha Técnica: Coriza Infecciosa\n\nDescripción: Enfermedad respiratoria bacteriana.\nSíntomas: Nariz inflamada, dificultad respiratoria.\nTratamiento: Antibióticos y desinfección constante"
            },

            ["Porcinos"] = new Dictionary<string, string>()
            {
                ["Peste Porcina Clásica"] = "🐖 Ficha Técnica: Peste Porcina Clásica\n\nDescripción: Enfermedad viral con alto índice de mortalidad.\nSíntomas: Fiebre alta, erupciones cutáneas.\nTratamiento: Vacunación preventiva",

                ["Fiebre Aftosa"] = "🐖 Ficha Técnica: Fiebre Aftosa\n\nDescripción: Enfermedad viral que afecta a todos los ungulados.\nSíntomas: Vesículas en boca y patas.\nTratamiento: Aislamiento y vacunación",

                ["Parvovirosis Porcina"] = "🐖 Ficha Técnica: Parvovirosis Porcina\n\nDescripción: Causa abortos y mortalidad neonatal.\nSíntomas: Reproducción afectada.\nTratamiento: Vacunación preventiva",

                ["Erisipela Suína"] = "🐖 Ficha Técnica: Erisipela Suína\n\nDescripción: Enfermedad bacteriana causada por *Erysipelothrix rhusiopathiae*.\nSíntomas: Erupciones cutáneas.\nTratamiento: Antibióticos y vacunación",

                ["Colibacilosis Neonatal"] = "🐖 Ficha Técnica: Colibacilosis Neonatal\n\nDescripción: Diarrea en lechones recién nacidos.\nSíntomas: Diarrea, debilidad.\nTratamiento: Antibióticos y calostro adecuado",

                ["Colibacilosis Postdestete"] = "🐖 Ficha Técnica: Colibacilosis Postdestete\n\nDescripción: Diarrea en lechones tras destete.\nSíntomas: Diarrea, fiebre.\nTratamiento: Mejora de condiciones de crianza",

                ["Acariasis"] = "🐖 Ficha Técnica: Acariasis\n\nDescripción: Infestación por ácaros.\nSíntomas: Picazón, lesiones cutáneas.\nTratamiento: Insecticidas tópicos",

                ["Cysticercosis"] = "🐖 Ficha Técnica: Cysticercosis\n\nDescripción: Enfermedad parasitaria que forma nódulos subcutáneos.\nSíntomas: Presencia de larvas en tejidos.\nTratamiento: Medicamentos antiparasitarios"
            }
        };


        public FichasTecnicasForm()
        {
            InitializeComponent();
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            lstFichasDisponibles.SelectedIndexChanged += lstFichasDisponibles_SelectedIndexChanged;
            fichaTecnicaService.InsertarFichasPredeterminadas(fichasTecnicasPorDefecto);
            fichasTecnicas = fichaTecnicaService.ObtenerTodasLasFichas();
            CargarCategorias();

        }

        private void CargarCategorias()
        {
            cmbCategoria.Items.Clear();
            foreach (var cat in fichasTecnicas.Keys)
                cmbCategoria.Items.Add(cat);
            if (cmbCategoria.Items.Count > 0)
                cmbCategoria.SelectedIndex = 0;
        }


        private void FichasTecnicasForm_Load(object sender, EventArgs e)
        {
            // Inserta solo si no existen
            fichaTecnicaService.InsertarFichasPredeterminadas(fichasTecnicasPorDefecto);

            // Luego carga todas las fichas (predeterminadas y personalizadas)
            fichasTecnicas = fichaTecnicaService.ObtenerTodasLasFichas();

            CargarCategorias();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListBox();
        }

        private void ActualizarListBox()
        {
            string categoria = cmbCategoria.SelectedItem?.ToString();
            lstFichasDisponibles.Items.Clear();
            if (!string.IsNullOrEmpty(categoria) && fichasTecnicas.ContainsKey(categoria))
            {
                foreach (var ficha in fichasTecnicas[categoria])
                    lstFichasDisponibles.Items.Add(ficha.Key);
            }
        }

        private void lstFichasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.SelectedItem?.ToString();
            string nombre = lstFichasDisponibles.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(categoria) && fichasTecnicas.ContainsKey(categoria)
                && fichasTecnicas[categoria].ContainsKey(nombre))
            {
                rtbContenidoFicha.Text = fichasTecnicas[categoria][nombre];
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnGenerarFicha_Click(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.SelectedItem?.ToString();
            string consulta = txtConsulta.Text.Trim();

            if (string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Seleccione una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(consulta))
            {
                MessageBox.Show("Escribe una enfermedad o cultivo/forraje para generar la ficha técnica.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Generar contenido desde servicio
                string contenido = fichaTecnicaService.GenerarFichaTecnica(categoria, consulta);

                // Dividir por saltos de línea
                string[] partes = contenido.Split(new string[] { "\nSíntomas:", "\nTratamiento:" }, StringSplitOptions.None);

                string descripcion = partes[0];
                string sintomas = partes.Length > 1 ? partes[1] : "No disponible";
                string tratamiento = partes.Length > 2 ? partes[2] : "No disponible";

                string fichaCompleta = $@"Ficha Técnica: {consulta}
Descripción: {descripcion}
Síntomas: {sintomas}
Tratamiento: {tratamiento}";

                // Mostrar resultado en RichTextBox
                rtbContenidoFicha.Text = fichaCompleta;

                // Agregar nombre a ListBox
                lstFichasDisponibles.Items.Add(consulta);

                // Guardar en base de datos
                bool guardado = fichaTecnicaService.GuardarFichaTecnica(categoria, consulta, fichaCompleta);

                if (guardado)
                {
                    MessageBox.Show("✅ Ficha técnica generada y guardada correctamente.");
                }
                else
                {
                    MessageBox.Show("⚠️ La ficha se mostró pero no se pudo guardar en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al generar ficha técnica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarFicha_Click(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.SelectedItem?.ToString();
            string nombre = txtConsulta.Text.Trim();
            string contenido = rtbContenidoFicha.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contenido))
            {
                MessageBox.Show("Nombre o contenido vacío.");
                return;
            }

            if (!fichasTecnicas.ContainsKey(categoria))
                fichasTecnicas[categoria] = new();

            fichasTecnicas[categoria][nombre] = contenido;
            fichaTecnicaService.GuardarFichaTecnica(categoria, nombre, contenido);

            ActualizarListBox();
            MessageBox.Show("Ficha guardada exitosamente.");
        }



        private void btnAnalizarIA_Click_1(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.SelectedItem?.ToString();
            string consulta = txtConsulta.Text.Trim();

            if (string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Por favor selecciona una categoría válida.", "Sin categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(consulta))
            {
                MessageBox.Show("Escribe una enfermedad o cultivo/forraje para analizar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rtbContenidoFicha.Text = "🧠 Analizando con IA...";

            try
            {
                // Simular análisis con IA
                string resultado = fichaTecnicaService.GenerarFichaTecnica(categoria, consulta);

                // Mostrar en RichTextBox
                rtbContenidoFicha.Text = $"📄 Ficha Técnica: {consulta}\n\n{resultado}";

                // Opcional: mensaje temporal
                MessageBox.Show("✅ Análisis completado. Usa 'Guardar' para agregar esta ficha a la lista.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al analizar con IA: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtConsulta.Clear();
            rtbContenidoFicha.Clear();
        }

     
        
    }
}

