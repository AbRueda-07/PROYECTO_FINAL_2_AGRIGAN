using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriGanAsistenteJutiapa.Models
{
    public class AsistentePredictivoIA
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }

        // ✅ Ahora permite texto con unidades: "3 meses", "45 días"
        public string EdadODiasSiembra { get; set; } = string.Empty;

        public string Clima { get; set; }
        public string Observaciones { get; set; }
        public string RespuestaIA { get; set; }
        public DateTime Fecha { get; set; }
    }
}
