using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;

namespace Logica.Test
{
    [TestClass]
    public class PuntoUnitTest
    {
        private Punto _punto;

        [TestInitialize]
        public void Inicializar()
        {
            _punto = new Punto();
        }

        [TestMethod]
        public void CuandoIngresaCoordenadas_2_1_CreaPuntoB1()
        {
            PuntoDTO puntoEsperado = new PuntoDTO()
            {
                id = "B1",
                x = 2,
                y = 1
            };

            int x = 2;
            int y = 1;

            PuntoDTO puntoActual = _punto.CrearPunto(x, y);

            Assert.AreEqual(puntoEsperado.id, puntoActual.id);
            Assert.AreEqual(puntoEsperado.x, puntoActual.x);
            Assert.AreEqual(puntoEsperado.y, puntoActual.y);
        }

        [TestMethod]
        public void CuandoIngresaPuntosConectadosRetornaSusPuntosConectados()
        {
            PuntoDTO punto = _punto.CrearPunto(1, 1);
            _punto.AdicionarPuntoConectado(punto, _punto.CrearPunto(2, 1));
            _punto.AdicionarPuntoConectado(punto, _punto.CrearPunto(1, 2));

            Assert.AreEqual(punto.puntosConectados[0].id, "B1");
            Assert.AreEqual(punto.puntosConectados[1].id, "A2");
        }
    }
}
