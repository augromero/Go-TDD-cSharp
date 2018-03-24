using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;

namespace Logica.Test
{
    [TestClass]
    public class JugadorUnitTest
    {
        private Jugador _jugador;
        [TestInitialize]
        public void Inicializar()
        {
            _jugador = new Jugador();
        }

        [TestMethod]
        public void CuandoIngresaNombreJugadorSeCreaJugadorDTO()
        {
            string nombreEsperado = "Augusto";
            Color color = Color.Blanco;

            JugadorDTO jugador = _jugador.CrearJugador(nombreEsperado, color);

            Assert.AreEqual(nombreEsperado, jugador.nombre);
            Assert.AreEqual(color, jugador.color);
            Assert.AreEqual(1, jugador.turno);

        }
    }
}
