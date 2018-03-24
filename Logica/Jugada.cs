using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Logica
{
    public class Jugada : IJugada
    {
        public JugadaDTO CrearJugada(Color color, string idPunto, int turno)
        {
            JugadaDTO jugada = new JugadaDTO
            {
                color = color,
                idPunto = idPunto,
                turno = turno
            };

            return jugada;
        }
    }
}
