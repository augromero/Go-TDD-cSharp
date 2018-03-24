using Modelos;

namespace Logica
{
    public interface IGrilla
    {
        void ConectarPuntos(TableroDTO grilla, PuntoDTO punto);
        TableroDTO CrearGrillaConTamaño(int tamaño);
        void CrearTableroDesdeGrilla(TableroDTO grilla);
        PuntoDTO ObtenerPuntoPorCoordenadas(TableroDTO grilla, int x, int y);
    }
}