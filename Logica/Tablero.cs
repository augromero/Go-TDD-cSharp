using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Logica
{
    public class Tablero : ITablero
    {
        private IGrilla _grilla;

        public Tablero(IGrilla grilla)
        {
            _grilla = grilla;
        }

        public TableroDTO CrearTablero(int tamaño)
        {
            TableroDTO tablero = _grilla.CrearGrillaConTamaño(tamaño);
            _grilla.CrearTableroDesdeGrilla(tablero);

            return tablero;
        }

        public PuntoDTO ObtenerPuntoPorId(TableroDTO tablero, string idPunto)
        {
            PuntoDTO puntoDTO = tablero.puntos
                .Where(punto => punto.id == idPunto)
                .FirstOrDefault();

            if (puntoDTO == null)
                throw new Exception("El punto no existe en el tablero.");

            return puntoDTO;
        }
    }
}
