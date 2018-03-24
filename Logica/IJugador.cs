using Modelos;

namespace Logica
{
    public interface IJugador
    {
        JugadorDTO CrearJugador(string nombre, Color color);
    }
}