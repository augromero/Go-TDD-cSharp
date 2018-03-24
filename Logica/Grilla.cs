using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Logica
{
    public class Grilla : IGrilla
    {
        private IPunto _punto;

        public Grilla(IPunto punto)
        {
            _punto = punto;
        }

        public TableroDTO CrearGrillaConTamaño(int tamaño)
        {
            TableroDTO grilla = new TableroDTO();
            grilla.tamaño = tamaño;
            grilla.puntos = new List<PuntoDTO>();
            PuntoDTO puntoDTO = new PuntoDTO();
            for (int posicionX = 1; posicionX <= tamaño; posicionX++)
            {
                for (int posicionY = 1; posicionY <=tamaño; posicionY++)
                {
                    puntoDTO = _punto.CrearPunto(posicionX, posicionY);
                    grilla.puntos.Add(puntoDTO);
                }
            }
            grilla.cantidadPuntos = grilla.puntos.Count;
            return grilla;
        }

        public PuntoDTO ObtenerPuntoPorCoordenadas(TableroDTO grilla, int x, int y)
        {
            PuntoDTO puntoDTO = grilla.puntos.Where(punto => punto.x == x
                && punto.y == y)
                .FirstOrDefault();

            if (puntoDTO == null)
                throw new Exception("El punto no pertenece al tablero.");

            return puntoDTO;
        }

        public void CrearTableroDesdeGrilla(TableroDTO grilla)
        {
            grilla.puntos.ForEach(punto => ConectarPuntos(grilla, punto));
        }

        public void ConectarPuntos(TableroDTO grilla, PuntoDTO punto)
        {
            ObtenerPuntoIzquierda(grilla, punto);
            ObtenerPuntoDerecha(grilla, punto);
            ObtenerPuntoAbajo(grilla, punto);
            ObtenerPuntoArriba(grilla, punto);
        }

        private void ObtenerPuntoArriba(TableroDTO grilla, PuntoDTO punto)
        {
            try
            {
                PuntoDTO puntoArriba = ObtenerPuntoPorCoordenadas(grilla, punto.x, punto.y + 1);
                punto.puntosConectados.Add(puntoArriba);
            }
            catch (Exception) { }
        }

        private void ObtenerPuntoAbajo(TableroDTO grilla, PuntoDTO punto)
        {
            try
            {
                PuntoDTO puntoAbajo = ObtenerPuntoPorCoordenadas(grilla, punto.x, punto.y - 1);
                punto.puntosConectados.Add(puntoAbajo);
            }
            catch (Exception) { }
        }

        private void ObtenerPuntoDerecha(TableroDTO grilla, PuntoDTO punto)
        {
            try
            {
                PuntoDTO puntoDerecha = ObtenerPuntoPorCoordenadas(grilla, punto.x + 1, punto.y);
                punto.puntosConectados.Add(puntoDerecha);
            }
            catch (Exception) { }
        }

        private void ObtenerPuntoIzquierda(TableroDTO grilla, PuntoDTO punto)
        {
            try
            {
                PuntoDTO puntoIzquierda = ObtenerPuntoPorCoordenadas(grilla, punto.x - 1, punto.y);
                punto.puntosConectados.Add(puntoIzquierda);
            }
            catch (Exception){}
        }
    }


}
