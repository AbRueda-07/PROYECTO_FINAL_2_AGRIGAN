using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using AgriGanAsistenteJutiapa.UI;
using AgriGanAsistenteJutiapa.Data;
using AgriGanAsistenteJutiapa.Models;




namespace AgriGanAsistenteJutiapa.Services
{
    public class UsuarioService
    {
        private readonly DatabaseManager dbManager = new DatabaseManager();

        public bool RegistrarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = dbManager.GetConnection())
            {
                string query = "INSERT INTO Usuarios (Nombre, Correo, ContraseniaHash) VALUES (@Nombre, @Correo, @ContraseniaHash)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                cmd.Parameters.AddWithValue("@ContraseniaHash", usuario.ContraseniaHash); 

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
        public Usuario Login(string correo, string contrasenia)
        {
            using (SqlConnection conn = dbManager.GetConnection())
            {
                string query = "SELECT * FROM Usuarios WHERE Correo = @Correo AND ContraseniaHash = @Contrasenia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Usuario
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Correo = reader["Correo"].ToString()
                    };
                }
                return null;
            }
        }

        public bool EliminarCuenta(int usuarioId)
        {
            using SqlConnection conn = dbManager.GetConnection();
            conn.Open();

            var trans = conn.BeginTransaction();

            try
            {
                var tablas = new[] { "ConsultasIA", "Diagnosticos", "Cultivos", "Animales", "RegistrosDatos" }; // todas las que dependan
                foreach (var tabla in tablas)
                {
                    string eliminar = $"DELETE FROM {tabla} WHERE UsuarioId = @uid";
                    using var cmd = new SqlCommand(eliminar, conn, trans);
                    cmd.Parameters.AddWithValue("@uid", usuarioId);
                    cmd.ExecuteNonQuery();
                }

                // Finalmente, el usuario
                string deleteUser = "DELETE FROM Usuarios WHERE Id = @uid";
                using var deleteCmd = new SqlCommand(deleteUser, conn, trans);
                deleteCmd.Parameters.AddWithValue("@uid", usuarioId);
                deleteCmd.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch
            {
                trans.Rollback();
                return false;
            }
        }



        public Usuario ValidarCredenciales(string correo, string contraseniaIngresada)
        {
            using SqlConnection conn = dbManager.GetConnection();
            conn.Open();

            var query = "SELECT * FROM Usuarios WHERE Correo = @correo";
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@correo", correo);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string salt = reader["Salt"].ToString();
                string hashAlmacenado = reader["ContraseniaHash"].ToString();

                if (Hashing.VerificarHash(contraseniaIngresada, salt, hashAlmacenado))
                {
                    return new Usuario
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        ContraseniaHash = hashAlmacenado,
                        Salt = salt,
                        FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                    };
                }
            }

            return null; // Credenciales incorrectas
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            using SqlConnection conn = dbManager.GetConnection();
            conn.Open();
            var query = "SELECT * FROM Usuarios WHERE Id = @id";
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Usuario
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nombre = reader["Nombre"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    ContraseniaHash = reader["ContraseniaHash"].ToString(),
                    Salt = reader["Salt"].ToString(),
                    FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                };
            }
            return null; // Usuario no encontrado
        }


    }

}

