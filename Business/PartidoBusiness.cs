using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Business
{
    public class PartidoBusiness
    {
        public List<PartidosEntity> ObtenerPartidos()
        {
            try
            {
                PartidoDAO partidoDAO = new PartidoDAO();

                return partidoDAO.ObtenerPartidos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener partidos", ex);
            }

        }

        public PartidosEntity? ObtenerPartidoPorId(int idPartido)
        {
            try
            {
                PartidoDAO partidoDAO = new PartidoDAO();

                return partidoDAO.ObtenerPartidoPorId(idPartido);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener partido por id", ex);
            }
        }

        public void CargarPartido(PartidosEntity partido)
        {
            try
            {
                PartidoDAO partidoDAO = new PartidoDAO();
                BracketBusiness bracketBusiness = new BracketBusiness();
                using (var trx = new TransactionScope())
                {
                    //metodos de validacion
                    ValidarPartido(partido);
                    ValidarCantidadJugadores(partido.equipo1, partido.disciplina);
                    ValidarCantidadJugadores(partido.equipo2, partido.disciplina);

                    partidoDAO.CargarPartido(partido);

                    if (partido.competencia.id == 1)
                    {
                        EquipoBusiness.updateResultadosEquipos(partido);
                    }
                    else
                    {
                        bracketBusiness.ActualizarBracket(partido);
                    }

                    trx.Complete();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        //por ahora no se si se va a implementar
        public void ActualizarPartido(PartidosEntity partido, DisciplinasEntity idDisciplina)
        {
            try
            {
                //validacion
                ValidarPartido(partido);
                ValidarCantidadJugadores(partido.equipo1, idDisciplina);
                ValidarCantidadJugadores(partido.equipo2, idDisciplina);

                PartidoDAO partidoDAO = new PartidoDAO();

                partidoDAO.ActualizarPartido(partido);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el resultado del partido", ex);
            }

        }

        public void ValidarPartido(PartidosEntity partido)
        {
            //validacion minimo de equipos cargados
            //validar cantidad de jugadores por disciplina

            if (partido.equipo1 == null)
                throw new Exception("Debe seleccionar el equipo 1.");

            if (partido.equipo2 == null)
                throw new Exception("Debe seleccionar el equipo 2.");

            if (partido.ganador == null)
                throw new Exception("Debe seleccionar un ganador");

            if (partido.equipo1.id == partido.equipo2.id)
                throw new Exception("Un equipo no puede jugar contra sí mismo.");

            if (partido.ganador.id != partido.equipo1.id &&
                partido.ganador.id != partido.equipo2.id)
                throw new Exception("El ganador debe ser uno de los equipos que disputaron el partido.");
        }

        public static List<PartidosEntity.PartidosLayer> getPartidosByEquipoYCompetencia(int idEquipo, int idCompetencia)
        {
            try
            {
                PartidoDAO partidoDAO = new PartidoDAO();
                List<PartidosEntity> partidos = partidoDAO.getPartidosByEquipoYCompetencia(idEquipo, idCompetencia);
                List<PartidosEntity.PartidosLayer> partidosLayer = new List<PartidosEntity.PartidosLayer>();

                foreach (var p in partidos)
                {
                    partidosLayer.Add(new PartidosEntity.PartidosLayer(p));
                }

                return partidosLayer;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los partidos por equipo y competencia: " + ex.Message);
            }
        }

        public static List<PartidosEntity.PartidosLayer> getPartidos()
        {
            try
            {
                PartidoDAO partidoDAO = new PartidoDAO();
                List<PartidosEntity> partidos = partidoDAO.ObtenerPartidos();
                List<PartidosEntity.PartidosLayer> partidosLayer = new List<PartidosEntity.PartidosLayer>();

                foreach (var p in partidos)
                {
                    partidosLayer.Add(new PartidosEntity.PartidosLayer(p));
                }

                return partidosLayer;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los partidos: " + ex.Message);
            }
        }

        public void ValidarCantidadJugadores(EquiposEntity equipo, DisciplinasEntity disciplina)
        {
            int cantidadActual = JugadorDAO.getCantidadJugadores(equipo.id);
            int cantidadRequerida = DisciplinaBusiness.getCantidadJugadoresDisciplina(disciplina.id);

            if (cantidadActual < cantidadRequerida)
                throw new Exception("El equipo no cumple con la cantidad mínima de jugadores para la disciplina");
        }


    }
}
