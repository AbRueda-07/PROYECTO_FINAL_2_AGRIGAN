using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using AgriGanAsistenteJutiapa.Models;
using AgriGanAsistenteJutiapa.Data;
using System.IO;

namespace AgriGanAsistenteJutiapa.Services
{
    public class ConsultaService
    {
        private readonly DatabaseManager db = new DatabaseManager();

        public bool GuardarConsulta(int usuarioId, string tipo, string pregunta, string respuesta)
        {
            using SqlConnection conn = db.GetConnection();
            string query = "INSERT INTO ConsultasIA (UsuarioId, TipoConsulta, Pregunta, Respuesta) VALUES (@uid, @tipo, @preg, @resp)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@uid", usuarioId);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@preg", pregunta);
            cmd.Parameters.AddWithValue("@resp", respuesta);

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar consulta: {ex.Message}");
                return false;
            }
        }

        public List<Consulta> ObtenerHistorial(int usuarioId, string tipo)
        {
            var historial = new List<Consulta>();

            using SqlConnection conn = db.GetConnection();
            string query = "SELECT Pregunta, Respuesta, Fecha FROM ConsultasIA WHERE UsuarioId = @uid AND TipoConsulta = @tipo ORDER BY Fecha DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@uid", usuarioId);
            cmd.Parameters.AddWithValue("@tipo", tipo);

            try
            {
                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    historial.Add(new Consulta
                    {
                        Pregunta = reader.GetString(0),
                        Respuesta = reader.GetString(1),
                        Fecha = reader.GetDateTime(2),
                        TipoConsulta = tipo,
                        UsuarioId = usuarioId
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener historial: {ex.Message}");
            }

            return historial;
        }


        public List<Consulta> ObtenerTodas()
        {
            var lista = new List<Consulta>();
            using var conn = db.GetConnection();
            string query = "SELECT * FROM ConsultasIA";
            using var cmd = new SqlCommand(query, conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Consulta
                {
                    Id = reader.GetInt32(0),
                    UsuarioId = reader.GetInt32(1),
                    TipoConsulta = reader.GetString(2),
                    Pregunta = reader.GetString(3),
                    Respuesta = reader.GetString(4),
                    Fecha = reader.GetDateTime(5)
                });
            }
            return lista;
        }


        public bool EliminarConsulta(int id)
        {
            using var conn = db.GetConnection();
            string query = "DELETE FROM ConsultasIA WHERE Id = @id";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
        public List<Consulta> ObtenerConsultasPorTipoYUsuario(string tipo, int usuarioId)
        {
            var lista = new List<Consulta>();
            using SqlConnection conn = db.GetConnection();
            string query = "SELECT Id, UsuarioId, TipoConsulta, Pregunta, Respuesta, Fecha FROM ConsultasIA WHERE TipoConsulta = @tipo AND UsuarioId = @uid ORDER BY Fecha DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@uid", usuarioId);

            try
            {
                conn.Open();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Consulta
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        UsuarioId = reader.GetInt32(reader.GetOrdinal("UsuarioId")),
                        TipoConsulta = reader.GetString(reader.GetOrdinal("TipoConsulta")),
                        Pregunta = reader.GetString(reader.GetOrdinal("Pregunta")),
                        Respuesta = reader.GetString(reader.GetOrdinal("Respuesta")),
                        Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"))
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener consultas: {ex.Message}");
            }

            return lista;
        }

        public List<Consulta> BuscarConsultaPorPalabraClave(string palabraClave, int usuarioId)
        {
            if (string.IsNullOrWhiteSpace(palabraClave))
                return new List<Consulta>();

            var lista = new List<Consulta>();
            using SqlConnection conn = db.GetConnection();
            string query = @"
                SELECT Id, UsuarioId, TipoConsulta, Pregunta, Respuesta, Fecha 
                FROM ConsultasIA 
                WHERE UsuarioId = @uid 
                AND (Pregunta LIKE @clave OR Respuesta LIKE @clave)
                ORDER BY Fecha DESC";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@uid", usuarioId);
            cmd.Parameters.AddWithValue("@clave", $"%{palabraClave}%");

            try
            {
                conn.Open();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Consulta
                    {
                        Id = reader.GetInt32(0),
                        UsuarioId = reader.GetInt32(1),
                        TipoConsulta = reader.GetString(2),
                        Pregunta = reader.GetString(3),
                        Respuesta = reader.GetString(4),
                        Fecha = reader.GetDateTime(5)
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar consulta: {ex.Message}");
            }

            return lista;
        }

        public bool ActualizarRespuestaConsulta(int consultaId, string nuevaRespuesta)
        {
            if (string.IsNullOrWhiteSpace(nuevaRespuesta))
            {
                MessageBox.Show("La respuesta no puede estar vacía.");
                return false;
            }

            using SqlConnection conn = db.GetConnection();
            string query = "UPDATE ConsultasIA SET Respuesta = @resp WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@resp", nuevaRespuesta);
            cmd.Parameters.AddWithValue("@id", consultaId);

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar consulta: {ex.Message}");
                return false;
            }
        }
    }
}