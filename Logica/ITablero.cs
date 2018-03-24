using Modelos;

namespace Logica
{
    public interface ITablero
    {
        TableroDTO CrearTablero(int tamaño);
        PuntoDTO ObtenerPuntoPorId(TableroDTO tablero, string idPunto);
    }
}