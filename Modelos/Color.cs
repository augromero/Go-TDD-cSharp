using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public enum Color
    {
        Blanco = 'B',
        Negro = 'N'
    }

    public static class ColorExtensiones
    {
        public static bool EsActivoAlIniciar(this Color color)
        {
            if (color == Color.Negro)
                return true;

            return false;
        }
    }
}
