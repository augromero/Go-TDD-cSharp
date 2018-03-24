using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using Rhino.Mocks;

namespace Logica.Test
{
    [TestClass]
    public class GrillaUnitTest
    {
        private IPunto _punto;
        private Grilla _grilla;
        [TestInitialize]
        public void Inicializar()
        {
            _punto = new Punto();
            _grilla = new Grilla(_punto);
        }

        [TestMethod]
        public void CuandoIngresaTamaño3CreaGrillaCon9Puntos()
        {
            int tamaño = 3;

            TableroDTO grilla3x3 = _grilla.CrearGrillaConTamaño(tamaño);

            Assert.AreEqual(9, grilla3x3.cantidadPuntos);
            Assert.AreEqual("C3", grilla3x3.puntos.Last().id);
            Assert.AreEqual(tamaño, grilla3x3.tamaño);
        }

        [TestMethod]
        public void CuandoIngresaGrillaRetornaTableroConPuntosRelacionados()
        {
            TableroDTO grilla3x3 = _grilla.CrearGrillaConTamaño(3);
            _grilla.CrearTableroDesdeGrilla(grilla3x3);

            Assert.AreEqual(2, grilla3x3.puntos[0].puntosConectados.Count);
        }

        [TestMethod]
        public void CuandoIngresaGrillaRetornaSusPuntosConectados()
        {
            TableroDTO grilla3x3 = _grilla.CrearGrillaConTamaño(3);

            PuntoDTO puntoA1 = _grilla.ObtenerPuntoPorCoordenadas(grilla3x3, 1, 1);
            PuntoDTO puntoB2 = _grilla.ObtenerPuntoPorCoordenadas(grilla3x3, 2, 2);

            _grilla.CrearTableroDesdeGrilla(grilla3x3);

            Assert.AreEqual(2, puntoA1.puntosConectados.Count);
            Assert.IsTrue(puntoA1.puntosConectados.Any(punto => punto.id == "A2"));
            Assert.IsTrue(puntoA1.puntosConectados.Any(punto => punto.id == "B1"));

            Assert.AreEqual(4, puntoB2.puntosConectados.Count);
            Assert.IsTrue(puntoB2.puntosConectados.Any(punto => punto.id == "B1"));
            Assert.IsTrue(puntoB2.puntosConectados.Any(punto => punto.id == "B3"));
            Assert.IsTrue(puntoB2.puntosConectados.Any(punto => punto.id == "A2"));
            Assert.IsTrue(puntoB2.puntosConectados.Any(punto => punto.id == "C2"));
        }

        [TestMethod]
        public void CuandoIngresaPuntoRetornaPuntosConectados()
        {
            TableroDTO grilla3x3 = _grilla.CrearGrillaConTamaño(3);

            PuntoDTO puntoA1 = _grilla.ObtenerPuntoPorCoordenadas(grilla3x3, 1, 1);

            _grilla.ConectarPuntos(grilla3x3, puntoA1);

            Assert.AreEqual(2, puntoA1.puntosConectados.Count);
            Assert.IsTrue(puntoA1.puntosConectados.Any(punto => punto.id == "A2"));
            Assert.IsTrue(puntoA1.puntosConectados.Any(punto => punto.id == "B1"));
        }

        [TestMethod]
        public void CuandoIngresaCoordenadasDelPuntoRetornaPuntoDTO()
        {
            TableroDTO grilla3x3 = _grilla.CrearGrillaConTamaño(3);

            int x = 1;
            int y = 2;

            PuntoDTO puntoRetornado = _grilla.ObtenerPuntoPorCoordenadas(grilla3x3, x, y);

            Assert.AreEqual("A2", puntoRetornado.id);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "El punto no pertenece al tablero.")]
        public void CuandoIngresaCoordenadasDePuntoInexistenteRetornaError()
        {
            TableroDTO grilla3x3 = _grilla.CrearGrillaConTamaño(3);

            int x = 4;
            int y = 4;

            PuntoDTO puntoRetornado = _grilla.ObtenerPuntoPorCoordenadas(grilla3x3, x, y);
        }
    }
}
