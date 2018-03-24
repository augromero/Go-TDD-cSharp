using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Logica
{
    public class Movimiento
    {
        private IPartida _partida;
        private IJugada _jugada;
        private ITablero _tablero;
        private IPiedra _piedra;

        public Movimiento(IPartida partida, IJugada jugada, IPiedra piedra, ITablero tablero)
        {
            _partida = partida;
            _jugada = jugada;
            _piedra = piedra;
            _tablero = tablero;
        }

        public void Crear(PartidaDTO partidaDTO, string idPunto)
        {
            JugadorDTO jugadorActivo = _partida.ObtenerJugadorActivo(partidaDTO);
            Color colorJugadorActivo = jugadorActivo.color;

            PuntoDTO puntoJugado = _tablero.ObtenerPuntoPorId(partidaDTO.tablero, idPunto);

            partidaDTO.jugadas.Add(_jugada.CrearJugada(colorJugadorActivo, idPunto, jugadorActivo.turno));

            PiedraDTO piedraJugada = _piedra.JugarPiedra(puntoJugado, jugadorActivo.turno);

            if (colorJugadorActivo == Color.Negro)
                partidaDTO.piedrasNegras.Add(piedraJugada);
            else
                partidaDTO.piedrasBlancas.Add(piedraJugada);

            _partida.CambiarJugadorActivo(partidaDTO);

        }
    }
}
