using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using Rhino.Mocks;

namespace Logica.Test
{
    [TestClass]
    public class TableroUnitTest
    {
        private IGrilla _grilla;
        private Tablero _tablero;

        [TestInitialize]
        public void Inicializar()
        {
            _grilla = new Grilla(new Punto());
            _tablero = new Tablero(_grilla);
        }

        [TestMethod]
        public void CunadoIngresaTamañoRetornaTableroConPuntosConectados()
        {
            int tamaño = 9;

            TableroDTO tablero = _tablero.CrearTablero(tamaño);

            Assert.AreEqual(81, tablero.cantidadPuntos);
            Assert.IsTrue(tablero.puntos.TrueForAll(punto => punto.puntosConectados.Count >= 2 && punto.puntosConectados.Count <= 4));
        }

        [TestMethod]
        public void CuandoIngresaIdPuntoRetornaPuntoDTO()
        {
            string idPunto = "A1";

            TableroDTO tablero = _tablero.CrearTablero(9);

            PuntoDTO puntoObtenido = _tablero.ObtenerPuntoPorId(tablero, idPunto);

            Assert.AreEqual(idPunto, puntoObtenido.id);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "El punto no existe en el tablero.")]
        public void CuandoIngresaIdPuntoInexistenteRetornaError()
        {
            string idPunto = "Z100";

            TableroDTO tablero = _tablero.CrearTablero(9);

            PuntoDTO puntoObtenido = _tablero.ObtenerPuntoPorId(tablero, idPunto);
        }
    }
}
