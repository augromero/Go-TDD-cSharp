using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;

namespace Logica.Test
{
    [TestClass]
    public class JugadaUnitTest
    {
        private Jugada _jugada;

        [TestInitialize]
        public void Inicializar()
        {
            _jugada = new Jugada();
        }

        [TestMethod]
        public void CuandoIngresaColorTurnoIdPuntoRegistraJugadaDTO()
        {
            Color color = Color.Negro;
            string idPunto = "B2";
            int turno = 1;

            JugadaDTO jugadaDTO = _jugada.CrearJugada(color, idPunto, turno);

            Assert.AreEqual(color, jugadaDTO.color);
            Assert.AreEqual(idPunto, jugadaDTO.idPunto);
            Assert.AreEqual(turno, jugadaDTO.turno);

        }
    }
}
