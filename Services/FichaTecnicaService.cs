using AgriGanAsistenteJutiapa.Data;
using AgriGanAsistenteJutiapa.Models;
using AgriGanAsistenteJutiapa.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AgriGanAsistenteJutiapa.Services
{
    public class FichaTecnicaService
    {
        private readonly DatabaseManager db = new DatabaseManager();

        #region Generación de Ficha Técnica (simulada o con IA)

        /// <summary>
        /// Genera una ficha técnica usando un modelo local o IA como OpenAI.
        /// </summary>
        public string GenerarFichaTecnica(string categoria, string consulta)
        {
            switch (categoria.ToLower())
            {
                case "cultivos y forrajes":
                    return $@"{consulta}
Descripción: Cultivo ampliamente utilizado en zonas tropicales.
Síntomas: Puede mostrar marchitamiento temprano o manchas foliares.
Tratamiento: Manejo integrado de plagas y riego controlado.";

                case "ganado bovino":
                    return $@"{consulta}
Descripción: Enfermedad común en ganado bovino.
Síntomas: Pérdida de apetito, fiebre leve y tos seca.
Tratamiento: Administración de antibióticos y monitoreo constante.";

                case "equinos":
                    return $@"{consulta}
Descripción: Problema frecuente en caballos jóvenes.
Síntomas: Cojera leve, inflamación en patas.
Tratamiento: Reposo prolongado y suplementación vitamínica.";

                case "aves":
                    return $@"{consulta}
Descripción: Afección digestiva en aves comerciales.
Síntomas: Diarrea y pérdida de peso.
Tratamiento: Mejora en alimentación y desparasitación.";

                case "porcinos":
                    return $@"{consulta}
Descripción: Problema dermatológico común en cerdos jóvenes.
Síntomas: Lesiones cutáneas rojizas.
Tratamiento: Uso de insecticidas y mejora en condiciones de establo.";

                default:
                    return $@"{consulta}
Descripción: No hay información específica sobre esta enfermedad o cultivo.
Síntomas: Pendiente de análisis.
Tratamiento: Pendiente de diagnóstico detallado.";
            }
        }

        #endregion

        #region Guardar nueva ficha técnica

        /// <summary>
        /// Guarda una nueva ficha técnica en la base de datos.
        /// </summary>
        /// 
        public bool GuardarFicha(string categoria, string nombre, string contenido)
        {
            using var conn = db.GetConnection();
            string query = "INSERT INTO FichasTecnicas (Categoria, Nombre, Contenido) VALUES (@cat, @nom, @cont)";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cat", categoria);
            cmd.Parameters.AddWithValue("@nom", nombre);
            cmd.Parameters.AddWithValue("@cont", contenido);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
        public bool GuardarFichaTecnica(string categoria, string nombre, string contenido)
        {
            using var conn = db.GetConnection();
            conn.Open();

            string query = "IF EXISTS (SELECT 1 FROM FichasTecnicas WHERE Categoria = @cat AND Nombre = @nom) " +
                           "UPDATE FichasTecnicas SET Contenido = @cont WHERE Categoria = @cat AND Nombre = @nom " +
                           "ELSE INSERT INTO FichasTecnicas (Categoria, Nombre, Contenido) VALUES (@cat, @nom, @cont)";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cat", categoria);
            cmd.Parameters.AddWithValue("@nom", nombre);
            cmd.Parameters.AddWithValue("@cont", contenido);
            return cmd.ExecuteNonQuery() > 0;
        }

        #endregion

        #region Obtener todas las fichas técnicas

        /// <summary>
        /// Obtiene todas las fichas técnicas desde la base de datos.
        /// </summary>
         // Cargar todas las fichas técnicas desde la BD
    public Dictionary<string, Dictionary<string, string>> ObtenerTodasLasFichas()
    {
        var fichas = new Dictionary<string, Dictionary<string, string>>();

        using SqlConnection conn = db.GetConnection();
        string query = "SELECT Categoria, Nombre, Contenido FROM FichasTecnicas ORDER BY Categoria";

        SqlCommand cmd = new SqlCommand(query, conn);

        try
        {
            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string categoria = reader["Categoria"].ToString();
                string nombre = reader["Nombre"].ToString();
                string contenido = reader["Contenido"].ToString();

                if (!fichas.ContainsKey(categoria))
                {
                    fichas[categoria] = new Dictionary<string, string>();
                }

                if (!fichas[categoria].ContainsKey(nombre))
                {
                    fichas[categoria][nombre] = contenido;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener fichas técnicas: " + ex.Message);
        }

        return fichas;
    }

        public Dictionary<string, Dictionary<string, string>> ObtenerTodas()
        {
            var resultado = new Dictionary<string, Dictionary<string, string>>();
            using var conn = db.GetConnection();
            string query = "SELECT Categoria, Nombre, Contenido FROM FichasTecnicas";
            using var cmd = new SqlCommand(query, conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string cat = reader.GetString(0);
                string nom = reader.GetString(1);
                string cont = reader.GetString(2);

                if (!resultado.ContainsKey(cat))
                    resultado[cat] = new Dictionary<string, string>();

                resultado[cat][nom] = cont;
            }
            return resultado;
        }
        #endregion

        #region Obtener fichas por categoría

        /// <summary>
        /// Obtiene todas las fichas técnicas de una categoría específica.
        /// </summary>
        public List<FichaTecnica> ObtenerFichasPorCategoria(string categoria)
        {
            var lista = new List<FichaTecnica>();

            using SqlConnection conn = db.GetConnection();
            string query = "SELECT Id, Categoria, Nombre, Contenido FROM FichasTecnicas WHERE Categoria = @categoria";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@categoria", categoria);

            try
            {
                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new FichaTecnica
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        Categoria = reader.GetString(reader.GetOrdinal("Categoria")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Contenido = reader.GetString(reader.GetOrdinal("Contenido"))
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener fichas por categoría: {ex.Message}");
            }

            return lista;
        }

        #endregion

        #region Buscar fichas por palabra clave

        /// <summary>
        /// Busca fichas técnicas por palabra clave en Nombre o Contenido.
        /// </summary>
        public List<FichaTecnica> BuscarFichaPorPalabraClave(string palabraClave)
        {
            var lista = new List<FichaTecnica>();
            using SqlConnection conn = db.GetConnection();
            string query = @"SELECT Id, Categoria, Nombre, Contenido FROM FichasTecnicas 
                            WHERE Nombre LIKE @clave OR Contenido LIKE @clave";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@clave", $"%{palabraClave}%");

            try
            {
                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new FichaTecnica
                    {
                        Id = reader.GetInt32(0),
                        Categoria = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        Contenido = reader.GetString(3)
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar ficha técnica: {ex.Message}");
            }

            return lista;
        }

        #endregion

        #region Actualizar ficha técnica

        /// <summary>
        /// Actualiza una ficha técnica existente.
        /// </summary>
        public bool ActualizarFichaTecnica(string categoria, string nombre, string contenido)
        {
            using SqlConnection conn = db.GetConnection();
            string query = @"UPDATE FichasTecnicas SET Contenido = @contenido WHERE Categoria = @categoria AND Nombre = @nombre";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@contenido", contenido);

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar ficha técnica: " + ex.Message);
                return false;
            }
        }

        #endregion

        #region Eliminar ficha técnica

        /// <summary>
        /// Elimina una ficha técnica por su ID.
        /// </summary>
        /// 
       
        #endregion

        #region Cargar datos en diccionario (opcional)

        /// <summary>
        /// Carga todas las fichas técnicas y las organiza en un diccionario por categoría.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> CargarFichasEnDiccionario()
        {
            var fichas = new Dictionary<string, Dictionary<string, string>>();

            using SqlConnection conn = db.GetConnection();
            string query = "SELECT Categoria, Nombre, Contenido FROM FichasTecnicas";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string categoria = reader.GetString(reader.GetOrdinal("Categoria"));
                    string nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                    string contenido = reader.GetString(reader.GetOrdinal("Contenido"));

                    if (!fichas.ContainsKey(categoria))
                    {
                        fichas[categoria] = new Dictionary<string, string>();
                    }

                    fichas[categoria][nombre] = contenido;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar fichas: {ex.Message}");
            }

            return fichas;
        }
       

       

        public bool ActualizarFicha(string categoria, string nombre, string contenido)
        {
            using var conn = db.GetConnection();
            string query = "UPDATE FichasTecnicas SET Contenido = @cont WHERE Categoria = @cat AND Nombre = @nom";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cat", categoria);
            cmd.Parameters.AddWithValue("@nom", nombre);
            cmd.Parameters.AddWithValue("@cont", contenido);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        #endregion

        public void InsertarFichasPredeterminadas(Dictionary<string, Dictionary<string, string>> datos)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            foreach (var categoria in datos)
            {
                foreach (var ficha in categoria.Value)
                {
                    string query = "IF NOT EXISTS (SELECT 1 FROM FichasTecnicas WHERE Categoria = @cat AND Nombre = @nom) " +
                                   "INSERT INTO FichasTecnicas (Categoria, Nombre, Contenido) VALUES (@cat, @nom, @cont)";
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cat", categoria.Key);
                    cmd.Parameters.AddWithValue("@nom", ficha.Key);
                    cmd.Parameters.AddWithValue("@cont", ficha.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}