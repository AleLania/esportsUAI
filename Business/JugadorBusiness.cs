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
    }
}
