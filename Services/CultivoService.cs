using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriGanAsistenteJutiapa.Data;
using AgriGanAsistenteJutiapa.Models;
using Microsoft.Data.SqlClient;

namespace AgriGanAsistenteJutiapa.Services
{
    public class CultivoService
    {
        private readonly DatabaseManager db = new DatabaseManager();

        public bool RegistrarCultivo(Cultivo cultivo)
        {
            using SqlConnection conn = db.GetConnection();
            string query = @"INSERT INTO Cultivos (UsuarioId, Nombre, Tipo, Sintomas, Tratamientos, FechaRegistro)
                             VALUES (@uid, @nom, @tipo, @sint, @trat, @fecha)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@uid", cultivo.UsuarioId);
            cmd.Parameters.AddWithValue("@nom", cultivo.Nombre);
            cmd.Parameters.AddWithValue("@tipo", cultivo.Tipo);
            cmd.Parameters.AddWithValue("@sint", cultivo.Sintomas);
            cmd.Parameters.AddWithValue("@trat", cultivo.Tratamientos);
            cmd.Parameters.AddWithValue("@fecha", cultivo.FechaRegistro);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public List<Cultivo> ObtenerTodos()
        {
            var lista = new List<Cultivo>();
            using var conn = db.GetConnection();
            string query = "SELECT * FROM Cultivos";
            using var cmd = new SqlCommand(query, conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Cultivo
                {
                    Id = reader.GetInt32(0),
                    UsuarioId = reader.GetInt32(1),
                    Nombre = reader.GetString(2),
                    Tipo = reader.GetString(3),
                    Sintomas = reader.GetString(4),
                    Tratamientos = reader.GetString(5),
                    FechaRegistro = reader.GetDateTime(6)
                });
            }
            return lista;
        }

        public bool Eliminar(int id)
        {
            using var conn = db.GetConnection();
            string query = "DELETE FROM Cultivos WHERE Id = @id";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }



        public bool ActualizarCultivo(Cultivo cultivo)
        {
            using SqlConnection conn = db.GetConnection();
            string query = @"UPDATE Cultivos SET Nombre = @nom, Tipo = @tipo, Sintomas = @sint, Tratamientos = @trat 
                     WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nom", cultivo.Nombre);
            cmd.Parameters.AddWithValue("@tipo", cultivo.Tipo);
            cmd.Parameters.AddWithValue("@sint", cultivo.Sintomas);
            cmd.Parameters.AddWithValue("@trat", cultivo.Tratamientos);
            cmd.Parameters.AddWithValue("@id", cultivo.Id);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }


    }
}
