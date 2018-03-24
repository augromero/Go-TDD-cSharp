using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;

namespace Logica.Test
{
    [TestClass]
    public class MovimientoUnitTest
    {
        private IPartida _partida;
        private ITablero _tablero;
        private IJugada _jugada;
        private IPiedra _piedra;

        private Movimiento _movimiento;

        private PartidaDTO _partidaDTO;

        [TestInitialize]
        public void Inicializar()
        {
            _tablero = new Tablero(new Grilla(new Punto()));
            _partida = new Partida(_tablero, new Jugador());
            _jugada = new Jugada();
            _piedra = new Piedra();
           
            _movimiento = new Movimiento(_partida, _jugada, _piedra, _tablero);

            _partidaDTO = _partida.Crear(9, "negro", "blanco");
        }

        [TestMethod]
        public void CuandoSeRealizaPrimerMovimientoAfectaJugadasYPiedras()
        {
            string idPunto = "B2";
            _movimiento.Crear(_partidaDTO, idPunto);

            Assert.AreEqual(idPunto, _partidaDTO.jugadas[0].idPunto);
            Assert.AreEqual(idPunto, _partidaDTO.piedrasNegras[0].punto.id);
        }

        

    }
}
