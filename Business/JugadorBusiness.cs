using Data;
using Entities;
using Microsoft.Data.SqlClient;
using System.Transactions;

namespace Business
{
    public class JugadorBusiness
    {
        public List<JugadoresEntity> obtenerJugadores()
        {
            JugadorDAO jugadorDAO = new JugadorDAO();

            return jugadorDAO.ObtenerJugadores();
        }

        public void validarJugador(JugadoresEntity jugador)
        {
            if (string.IsNullOrWhiteSpace(jugador.NombreApellido))
                throw new Exception("El nombre no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(jugador.Nick))
                throw new Exception("El nick no puede estar vacío.");

            EquiposEntity equipoCompleto = EquipoBusiness.getEquipoById(jugador.equipo.id);

            if (JugadorDAO.getCantidadJugadores(jugador.equipo.id) >= equipoCompleto.disciplina.cantidadJugadores)
                throw new Exception("El equipo ya tiene la cantidad máxima de jugadores.");
        }

        public void cargarJugador(JugadoresEntity jugador)
        {
            try
            {
                validarJugador(jugador);
                using (var trx = new TransactionScope())
                {
                    JugadorDAO jugadorDAO = new JugadorDAO();

                    jugadorDAO.CargarJugador(jugador);
                    trx.Complete();

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar el jugador: {ex.Message}");
            }
        }

        //lo hice al pedo? creo que si
        public void borrarJugador(int idJugador)
        {
            JugadorDAO jugadorDAO = new JugadorDAO();

            jugadorDAO.BorrarJugador(idJugador);
        }

        public JugadoresEntity? obtenerJugadorPorId(int idJugador)
        {
            JugadorDAO jugadorDAO = new JugadorDAO();

            return jugadorDAO.ObtenerJugadorPorId(idJugador);
        }

        public void actualizarJugador(JugadoresEntity jugador)
        {
            validarJugador(jugador);
            using (var trx = new TransactionScope())
            {
                JugadorDAO jugadorDAO = new JugadorDAO();

                jugadorDAO.ActualizarJugador(jugador);
                trx.Complete();
            }
        }
    }
}
