using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriGanAsistenteJutiapa.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string ContraseniaHash { get; set; }
        public string Salt { get; set; }
        public DateTime FechaRegistro { get; set; }
    }

}

