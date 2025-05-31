using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace AgriGanAsistenteJutiapa.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string TipoConsulta { get; set; }  // "Agrícola" o "Ganadera"
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public DateTime Fecha { get; set; }
    }
}
