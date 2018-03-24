using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Logica
{
    public class Piedra : IPiedra
    {

        public PiedraDTO JugarPiedra(PuntoDTO punto, int turno)
        {
            PiedraDTO piedraDTO = new PiedraDTO
            {
                punto = punto,
                turno = turno
            };

            return piedraDTO;
        }
    }
}
