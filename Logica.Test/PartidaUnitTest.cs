using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;

namespace Logica.Test
{
    [TestClass]
    public class PartidaUnitTest
    {
        private ITablero _tablero;
        private IJugador _jugador;

        private Partida _partida;

        private PartidaDTO _partidaEnCurso;

        [TestInitialize]
        public void Inicializar()
        {
            _tablero = new Tablero(new Grilla(new Punto()));
            _jugador = new Jugador();
            _partida = new Partida(_tablero, _jugador);

            _partidaEnCurso = _partida.Crear(9, "negro", "blanco");
        }


        [TestMethod]
        public void CunadoSeCreaPartidaSeDeterminaTamañoYSeCreanJugadores()
        {
            int tamaño = 9;
            string nombreJugadorNegro = "negro";
            string nombreJugadorBlanco = "blanco";

            PartidaDTO partidaCreada = _partida.Crear(tamaño, nombreJugadorNegro, nombreJugadorBlanco);

            Assert.AreEqual(9, partidaCreada.tablero.tamaño);
            Assert.AreEqual("negro", partidaCreada.jugadorNegro.nombre);
            Assert.AreEqual("blanco", partidaCreada.jugadorBlanco.nombre);
            Assert.AreEqual(0, partidaCreada.jugadas.Count);
            Assert.AreEqual(0, partidaCreada.piedrasNegras.Count);
            Assert.AreEqual(0, partidaCreada.piedrasBlancas.Count);
        }

        [TestMethod]
        public void CuandoIngresaPartidaRetornaJugadorActivo()
        {
            JugadorDTO jugadorActivo = _partida.ObtenerJugadorActivo(_partidaEnCurso);

            Assert.AreEqual("negro", jugadorActivo.nombre);
        }

        [TestMethod]
        public void CuandoIngresaPartidaConNegroActivoCambiaNegroInactivo()
        {
            _partida.CambiarJugadorActivo(_partidaEnCurso);

            JugadorDTO jugadorActivo = _partida.ObtenerJugadorActivo(_partidaEnCurso);

            Assert.AreEqual("blanco", jugadorActivo.nombre);
        }

        [TestMethod]
        public void CuandoIngresaPartidaConBlancoActivoCambiaBlancoInactivo()
        {
            _partida.CambiarJugadorActivo(_partidaEnCurso);
            _partida.CambiarJugadorActivo(_partidaEnCurso);

            JugadorDTO jugadorActivo = _partida.ObtenerJugadorActivo(_partidaEnCurso);

            Assert.AreEqual("negro", jugadorActivo.nombre);
        }


    }
}
