using Data;
using Entities;

namespace Business
{
    public class JugadorBusiness
    {
        public List<JugadoresEntity> obtenerJugadores()
        {
            JugadorDAO jugadorDAO = new JugadorDAO();

            return jugadorDAO.obtenerJugadores();
        }

        public void validarJugador(JugadoresEntity jugador)
        {
            if (string.IsNullOrWhiteSpace(jugador.NombreApellido))
                throw new Exception("El nombre no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(jugador.Nick))
                throw new Exception("El nick no puede estar vacío.");
        }

        public void cargarJugador(JugadoresEntity jugador)
        {
            validarJugador(jugador);

            JugadorDAO jugadorDAO = new JugadorDAO();

            jugadorDAO.cargarJugador(jugador);
        }

        //lo hice al pedo? creo que si
        public void borrarJugador(int idJugador)
        {
            JugadorDAO jugadorDAO = new JugadorDAO();

            jugadorDAO.borrarJugador(idJugador);
        }

        public JugadoresEntity? obtenerJugadorPorId(int idJugador)
        {
            JugadorDAO jugadorDAO = new JugadorDAO();

            return jugadorDAO.obtenerJugadorPorId(idJugador);
        }

        public void actualizarJugador(JugadoresEntity jugador)
        {
            JugadorDAO jugadorDAO = new JugadorDAO();

            jugadorDAO.actualizarJugador(jugador);
        }
    }
}
