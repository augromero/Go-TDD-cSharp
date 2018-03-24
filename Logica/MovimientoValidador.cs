using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MovimientoValidador
    {
        private IPartida _partida;
        private ITablero _tablero;

        public MovimientoValidador(IPartida partida, ITablero tablero)
        {
            _partida = partida;
            _tablero = tablero;
        }

        public void LanzaExcepcionSiPuntoSolicitadoNoExiste(PartidaDTO partidaEnJuego, string idPunto)
        {
            _tablero.ObtenerPuntoPorId(partidaEnJuego.tablero, idPunto);
        }
    }
}
