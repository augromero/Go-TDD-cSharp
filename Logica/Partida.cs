using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Logica
{
    public class Partida : IPartida
    {
        private ITablero _tablero;
        private IJugador _jugador;

        public Partida(ITablero tablero, IJugador jugador)
        {
            _tablero = tablero;
            _jugador = jugador;
        }

        public PartidaDTO Crear(int tamaño, string nombreJugadorNegro, string nombreJugadorBlanco)
        {
            PartidaDTO partidaCreada = new PartidaDTO
            {
                tablero = _tablero.CrearTablero(tamaño),
                jugadorNegro = _jugador.CrearJugador(nombreJugadorNegro, Color.Negro),
                jugadorBlanco = _jugador.CrearJugador(nombreJugadorBlanco, Color.Blanco),
                jugadas = new List<JugadaDTO>(),
                piedrasNegras = new List<PiedraDTO>(),
                piedrasBlancas = new List<PiedraDTO>()
            };


            return partidaCreada;
        }

        public JugadorDTO ObtenerJugadorActivo(PartidaDTO partidaEnCurso)
        {
            if (partidaEnCurso.jugadorBlanco.activo)
                return partidaEnCurso.jugadorBlanco;

            return partidaEnCurso.jugadorNegro;

        }

        public void CambiarJugadorActivo(PartidaDTO partidaEnCurso)
        {
            if (partidaEnCurso.jugadorBlanco.activo)
            {
                partidaEnCurso.jugadorBlanco.activo = false;
                partidaEnCurso.jugadorNegro.activo = true;
            }
            else
            {
                partidaEnCurso.jugadorBlanco.activo = true;
                partidaEnCurso.jugadorNegro.activo = false;
            }
                
        }
    }
}
