using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;

namespace Logica.Test
{
    [TestClass]
    public class ColorExtensionesUnitTest
    {
        [TestMethod]
        public void CuandoEsNegroIniciaActivo()
        {
            Assert.IsTrue(Color.Negro.EsActivoAlIniciar());
        }

        [TestMethod]
        public void CuandoEsBlancoIniciaInactivo()
        {
            Assert.IsFalse(Color.Blanco.EsActivoAlIniciar());
        }
    }
}
