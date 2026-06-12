using Data;
using Entities;

namespace Business
{
    public class JugadorBusiness
    {
        public List<JugadoresEntity> ObtenerJugadores()
        {
            JugadorDAO jugadorDAO = new JugadorDAO();

            return jugadorDAO.ObtenerJugadores();
        }

        public void ValidarJugador(JugadoresEntity jugador)
        {
            if (string.IsNullOrWhiteSpace(jugador.NombreApellido))
                throw new Exception("El nombre no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(jugador.Nick))
                throw new Exception("El nick no puede estar vacío.");
        }

        public void CargarJugador(JugadoresEntity jugador)
        {
            ValidarJugador(jugador);

            JugadorDAO jugadorDAO = new JugadorDAO();

            jugadorDAO.CargarJugador(jugador);
        }

        public void BorrarJugador(int idJugador)
        {
            JugadorDAO jugadorDAO = new JugadorDAO();

            jugadorDAO.BorrarJugador(idJugador);
        }
    }
}
