using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Logica
{
    public class Punto : IPunto
    {
        private const int BaseAsciiLetras = 64;

        public PuntoDTO CrearPunto(int x, int y)
        {
            string letra = Convert.ToChar(BaseAsciiLetras + x).ToString();
            string id = letra + y;

            PuntoDTO punto = new PuntoDTO()
            {
                id = id,
                x = x,
                y = y,
                puntosConectados = new List<PuntoDTO>()
            };

            return punto;
        }

        public void AdicionarPuntoConectado(PuntoDTO punto, PuntoDTO puntoConectado)
        {
            punto.puntosConectados.Add(puntoConectado);
        }
    }
}
