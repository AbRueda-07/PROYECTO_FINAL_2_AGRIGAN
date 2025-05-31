using AgriGanAsistenteJutiapa.Models;
using AgriGanAsistenteJutiapa.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AsistentePredictivoService
{
    private readonly DatabaseManager db = new DatabaseManager();

    public bool GuardarRegistro(AsistentePredictivoIA registro)
    {
        using SqlConnection conn = db.GetConnection();
        string query = @"INSERT INTO AsistentePredictivoIA 
            (UsuarioId, Tipo, Nombre, EdadODiasSiembra, Clima, Observaciones, RespuestaIA, Fecha) 
            VALUES (@uid, @tipo, @nombre, @edad, @clima, @obs, @respuesta, @fecha)";

        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@uid", registro.UsuarioId);
        cmd.Parameters.AddWithValue("@tipo", registro.Tipo ?? "");
        cmd.Parameters.AddWithValue("@nombre", registro.Nombre);
        cmd.Parameters.AddWithValue("@edad", registro.EdadODiasSiembra); // ✅ Ahora es string
        cmd.Parameters.AddWithValue("@clima", registro.Clima ?? "");
        cmd.Parameters.AddWithValue("@obs", registro.Observaciones ?? "");
        cmd.Parameters.AddWithValue("@respuesta", registro.RespuestaIA ?? "");
        cmd.Parameters.AddWithValue("@fecha", registro.Fecha);

        try
        {
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar: " + ex.Message);
            return false;
        }
    }

    public List<AsistentePredictivoIA> ObtenerRegistros(int usuarioId)
    {
        var lista = new List<AsistentePredictivoIA>();
        using var conn = db.GetConnection();
        string query = "SELECT * FROM AsistentePredictivoIA WHERE UsuarioId = @uid ORDER BY Fecha DESC";
        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@uid", usuarioId);
        conn.Open();
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            lista.Add(new AsistentePredictivoIA
            {
                Id = reader.GetInt32(0),
                UsuarioId = reader.GetInt32(1),
                Tipo = reader.GetString(2),
                Nombre = reader.GetString(3),
                EdadODiasSiembra = reader.GetString(4),
                Clima = reader.GetString(5),
                Observaciones = reader.GetString(6),
                RespuestaIA = reader.GetString(7),
                Fecha = reader.GetDateTime(8)
            });
        }
        return lista;
    }

    public List<AsistentePredictivoIA> ObtenerTodos()
    {
        var lista = new List<AsistentePredictivoIA>();
        using var conn = db.GetConnection();
        string query = "SELECT * FROM AsistentePredictivoIA"; 
        using var cmd = new SqlCommand(query, conn);
        conn.Open();
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            lista.Add(new AsistentePredictivoIA
            {
                Id = reader.GetInt32(0),
                UsuarioId = reader.GetInt32(1),
                Tipo = reader.GetString(2),
                Nombre = reader.GetString(3),
                EdadODiasSiembra = reader.GetString(4),
                Clima = reader.GetString(5),
                Observaciones = reader.GetString(6),
                RespuestaIA = reader.GetString(7),
                Fecha = reader.GetDateTime(8)
            });
        }
        return lista;
    }


    public bool EliminarRegistro(int id)
    {
        using var conn = db.GetConnection();
        string query = "DELETE FROM AsistentePredictivoIA WHERE Id = @id";
        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }
}