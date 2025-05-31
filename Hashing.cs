using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;
using System.IO;
using AgriGanAsistenteJutiapa.Data;
using System;

namespace AgriGanAsistenteJutiapa.Services
{
    public static class Hashing
    {
        // Genera un salt aleatorio
        public static string GenerarSalt(int tamaño = 32)
        {
            var bytes = new byte[tamaño];
            using var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        // Crea el hash combinando la contraseña con el salt
        public static (string Salt, string Hash) CrearHash(string contrasenia)
        {
            string salt = GenerarSalt();
            string hash = CalcularHash(contrasenia, salt);
            return (salt, hash);
        }

        // Verifica si la contraseña ingresada genera el mismo hash
        public static bool VerificarHash(string contraseniaIngresada, string salt, string hashAlmacenado)
        {
            string nuevoHash = CalcularHash(contraseniaIngresada, salt);
            return nuevoHash == hashAlmacenado;
        }

        // Función privada que genera el hash SHA256
        private static string CalcularHash(string contrasenia, string salt)
        {
            using var sha = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(contrasenia + salt);
            byte[] hashBytes = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
