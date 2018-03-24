using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Logica
{
    public class Jugador : IJugador
    {
        public JugadorDTO CrearJugador(string nombre, Color color)
        {
            JugadorDTO jugador = new JugadorDTO()
            {
                nombre = nombre,
                color = color,
                turno = 1,
                activo = color.EsActivoAlIniciar()
            };

            return jugador;
        }
    }
}
