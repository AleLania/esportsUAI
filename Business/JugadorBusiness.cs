using Data;
using Entities;
using Microsoft.Data.SqlClient;
using System.Transactions;

namespace Business
{
    public class JugadorBusiness
    {
        public List<JugadoresEntity> getJugadores()
        {
            try
            {
                return JugadorDAO.getJugadores();

            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        public void cargarJugador(JugadoresEntity jugador)
        {
            try
            {
                validarJugador(jugador);
                using (var trx = new TransactionScope())
                {
                    JugadorDAO.CargarJugador(jugador);
                    trx.Complete();

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar el jugador: {ex.Message}");
            }
        }

        public JugadoresEntity obtenerJugadorPorId(int idJugador)
        {
            try
            {
                return JugadorDAO.getJugadorPorId(idJugador);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el jugador: {ex.Message}");
            }

        }

        public void actualizarJugador(JugadoresEntity jugador)
        {
            JugadoresEntity jugadorOriginal = JugadorDAO.getJugadorPorId(jugador.IdJugador);

            validarJugador(jugador, jugadorOriginal);

            using (var trx = new TransactionScope())
            {
                JugadorDAO.ActualizarJugador(jugador);
                trx.Complete();
            }
        }

        public void validarJugador(JugadoresEntity jugador, JugadoresEntity jugadorOriginal = null)
        {
            if (string.IsNullOrWhiteSpace(jugador.NombreApellido))
                throw new Exception("El nombre no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(jugador.Nick))
                throw new Exception("El nick no puede estar vacío.");

            if (jugadorOriginal == null || jugadorOriginal.equipo.id != jugador.equipo.id)
            {
                EquiposEntity equipoCompleto = EquipoBusiness.getEquipoById(jugador.equipo.id);

                if (JugadorDAO.getCantidadJugadores(jugador.equipo.id) >= equipoCompleto.disciplina.cantidadJugadores)
                    throw new Exception("El equipo ya tiene la cantidad máxima de jugadores.");
            }

            if (JugadorDAO.existeNick(jugador.Nick, jugador.IdJugador))
                throw new Exception("Ya existe un jugador con ese nick.");

            if (JugadorDAO.existeNombre(jugador.NombreApellido, jugador.IdJugador))
                throw new Exception("Ya existe un jugador con ese nombre.");
        }
    }
}
