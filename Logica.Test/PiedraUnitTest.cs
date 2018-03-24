using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using Rhino.Mocks;

namespace Logica.Test
{
    [TestClass]
    public class PiedraUnitTest
    {
        private Piedra _piedra;


        [TestInitialize]
        public void Inicializar()
        {
            _piedra = new Piedra();
        }

        [TestMethod]
        public void CuandoJugadorUbicaPiedraCreaPiedraDTO()
        {
            PuntoDTO puntoRetornado = new PuntoDTO { id = "A1", x = 1, y = 1 };
            PiedraDTO piedraDTO = new PiedraDTO
            {
                turno = 1,
                punto = puntoRetornado
            };

            int turno = 1;
            PiedraDTO piedraJugada = _piedra.JugarPiedra(puntoRetornado, turno);

            Assert.AreEqual(puntoRetornado.id, piedraJugada.punto.id);
        }
    }
}
