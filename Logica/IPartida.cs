using Modelos;

namespace Logica
{
    public interface IPartida
    {
        PartidaDTO Crear(int tamaño, string nombreJugadorNegro, string nombreJugadorBlanco);
        JugadorDTO ObtenerJugadorActivo(PartidaDTO partidaEnCurso);
        void CambiarJugadorActivo(PartidaDTO partidaEnCurso);
    }
}