using Modelos;

namespace Logica
{
    public interface IJugada
    {
        JugadaDTO CrearJugada(Color color, string idPunto, int turno);
    }
}