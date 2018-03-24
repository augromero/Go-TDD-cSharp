using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class TableroDTO
    {
        public int tamaño { get; set; }

        public List<PuntoDTO> puntos { get; set; }
        public int cantidadPuntos { get; set; }
    }
}
