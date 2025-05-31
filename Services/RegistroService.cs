using AgriGanAsistenteJutiapa.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AgriGanAsistenteJutiapa.Services
{
    public class RegistroService
    {
        private readonly string connectionString = "Server=DESKTOP-T3ECS92\\SQLEXPRESS;Database=AgriGanDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public DataTable ObtenerDatos(string tabla)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand($"SELECT * FROM {tabla}", conn);
            using SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool EliminarPorId(string tabla, int id)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand($"DELETE FROM {tabla} WHERE Id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool ExisteTabla(string tabla)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @tabla";
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tabla", tabla);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
    }
}
