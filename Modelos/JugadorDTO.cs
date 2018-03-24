using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class JugadorDTO
    {
        public string nombre { get; set; }
        public Color color { get; set; }
        public bool activo { get; set; }
        public int turno { get; set; }
    }
}
