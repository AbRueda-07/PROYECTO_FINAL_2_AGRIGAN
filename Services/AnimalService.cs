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
    public class AnimalService
    {
        private readonly DatabaseManager db = new DatabaseManager();

        public bool RegistrarAnimal(Animal animal)
        {
            using SqlConnection conn = db.GetConnection();
            string query = @"INSERT INTO Animales (UsuarioId, Especie, Raza, Edad, Enfermedades, Tratamientos, FechaRegistro)
                             VALUES (@uid, @esp, @raza, @edad, @enf, @trat, @fecha)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@uid", animal.UsuarioId);
            cmd.Parameters.AddWithValue("@esp", animal.Especie);
            cmd.Parameters.AddWithValue("@raza", animal.Raza);
            cmd.Parameters.AddWithValue("@edad", animal.Edad);
            cmd.Parameters.AddWithValue("@enf", animal.Enfermedades);
            cmd.Parameters.AddWithValue("@trat", animal.Tratamientos);
            cmd.Parameters.AddWithValue("@fecha", animal.FechaRegistro);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public List<Animal> ObtenerTodos()
        {
            var lista = new List<Animal>();
            using var conn = db.GetConnection();
            string query = "SELECT * FROM Animales";
            using var cmd = new SqlCommand(query, conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Animal
                {
                    Id = reader.GetInt32(0),
                    UsuarioId = reader.GetInt32(1),
                    Especie = reader.GetString(2),
                    Raza = reader.GetString(3),
                    Edad = reader.GetInt32(4),
                    Enfermedades = reader.GetString(5),
                    Tratamientos = reader.GetString(6),
                    FechaRegistro = reader.GetDateTime(7)
                });
            }
            return lista;
        }

        public bool Eliminar(int id)
        {
            using var conn = db.GetConnection();
            string query = "DELETE FROM Animales WHERE Id = @id";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

       

     
    
        public bool ActualizarAnimal(Animal animal)
        {
            using SqlConnection conn = db.GetConnection();
            string query = @"UPDATE Animales SET Especie = @esp, Raza = @raza, Edad = @edad,
                     Enfermedades = @enf, Tratamientos = @trat WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@esp", animal.Especie);
            cmd.Parameters.AddWithValue("@raza", animal.Raza);
            cmd.Parameters.AddWithValue("@edad", animal.Edad);
            cmd.Parameters.AddWithValue("@enf", animal.Enfermedades);
            cmd.Parameters.AddWithValue("@trat", animal.Tratamientos);
            cmd.Parameters.AddWithValue("@id", animal.Id);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

    }
}
