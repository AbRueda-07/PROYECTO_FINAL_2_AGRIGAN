using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriGanAsistenteJutiapa.Models
{
    public class Cultivo
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Sintomas { get; set; }
        public string Tratamientos { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
