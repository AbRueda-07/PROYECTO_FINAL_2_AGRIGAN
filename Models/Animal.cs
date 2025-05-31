using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriGanAsistenteJutiapa.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Enfermedades { get; set; }
        public string Tratamientos { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}

