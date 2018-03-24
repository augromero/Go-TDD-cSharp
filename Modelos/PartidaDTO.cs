using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class PartidaDTO
    {
        public TableroDTO tablero { get; set; }
        public JugadorDTO jugadorNegro { get; set; }
        public JugadorDTO jugadorBlanco { get; set; }
        public List<JugadaDTO> jugadas { get; set; }
        public List<PiedraDTO> piedrasNegras { get; set; }
        public List<PiedraDTO> piedrasBlancas { get; set; }
    }
}
