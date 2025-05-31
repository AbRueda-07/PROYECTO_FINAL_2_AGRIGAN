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
using AgriGanAsistenteJutiapa.Services;


namespace AgriGanAsistenteJutiapa.Data
{
    public class DatabaseManager
    {
        private readonly string connectionString = "Server=DESKTOP-T3ECS92\\SQLEXPRESS;Database=AgriGanDB;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}


