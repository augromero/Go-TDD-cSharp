using Modelos;

namespace Logica
{
    public interface IPiedra
    {
        PiedraDTO JugarPiedra(PuntoDTO punto, int turno);
    }
}