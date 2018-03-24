using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;

namespace Logica.Test
{
    [TestClass]
    public class MovimientoValidadorUnitTest
    {
        IPartida _partida;
        ITablero _tablero;

        private PartidaDTO _partidaDTO;

        MovimientoValidador _movimientoValidador;

        [TestInitialize]
        public void Inicializar()
        {
            _tablero = new Tablero(new Grilla(new Punto()));
            _partida = new Partida(_tablero, new Jugador());

            _movimientoValidador = new MovimientoValidador(_partida, _tablero);

            _partidaDTO = _partida.Crear(9, "negro", "blanco");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "El punto solicitado no existe en el tablero.")]
        public void CuandoIdPuntoNoExisteRetornaError()
        {
            string idPunto = "Z10";

            _movimientoValidador.LanzaExcepcionSiPuntoSolicitadoNoExiste(_partidaDTO, idPunto);
        }
    }
}
