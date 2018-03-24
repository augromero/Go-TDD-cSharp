using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class PuntoDTO
    {
        public string id { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public List<PuntoDTO> puntosConectados { get; set; }
    }
}
