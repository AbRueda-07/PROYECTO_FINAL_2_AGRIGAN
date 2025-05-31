using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriGanAsistenteJutiapa.Models
{
    public class FichaTecnica
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
