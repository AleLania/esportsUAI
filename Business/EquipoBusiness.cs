using Data;
using Entities;
using Mapper;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace Business
{
    public class EquipoBusiness
    {
        public static List<EquiposEntity> getEquipos()
        {
            return EquipoDAO.getEquipos();
        }

        public static List<EquiposEntity.EquiposTorneoEntity> getEquiposTorneo()
        {
            try
            {
                List<EquiposEntity.EquiposTorneoEntity> listOfEquipos = new List<EquiposEntity.EquiposTorneoEntity>();

                foreach (EquiposEntity equipo in EquipoDAO.getEquipos())
                {
                    EquiposEntity.EquiposTorneoEntity equipoTorneo = new EquiposEntity.EquiposTorneoEntity(equipo);
                    listOfEquipos.Add(equipoTorneo);
                }

                return listOfEquipos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EquiposEntity> getEquiposByDisciplina(int idDisciplina)
        {
            try
            {
                return EquipoDAO.getEquiposByDisciplina(idDisciplina);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener equipos por disciplina: " + ex.Message);
            }
        }

        public static void insertEquipo(string nombre, int idDisciplina)
        {
            try
            {
                EquiposEntity nuevoEquipo = new EquiposEntity(
                    nombre,
                    DisciplinaBusiness.getDisciplinaById(idDisciplina));

                validarEquipo(nuevoEquipo);

                int cantidadActual = EquipoDAO.countEquiposByDisciplina(idDisciplina);
                int cantidadMaxima = DisciplinaBusiness.getCantidadEquiposDisciplina(idDisciplina);

                using (var trx = new TransactionScope())
                {
                    EquipoDAO.insertEquipo(nuevoEquipo);

                    // Si con este equipo se completa el cupo, armamos los brackets
                    if (cantidadActual + 1 == cantidadMaxima)
                    {
                        BracketBusiness.armarBracketsCopa(idDisciplina);
                    }

                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void updateEquipo(string nombre, int id)
        {
            try
            {
                EquiposEntity equipoOriginal = EquipoDAO.getEquipoById(id);

                EquiposEntity equipoActualizado = new EquiposEntity(
                    nombre,
                    equipoOriginal.disciplina);

                equipoActualizado.id = id;

                validarEquipo(equipoActualizado, equipoOriginal);

                using (var trx = new TransactionScope())
                {
                    EquipoDAO.updateEquipo(equipoActualizado);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void validarEquipo(EquiposEntity equipo, EquiposEntity equipoOriginal = null)
        {
            if (string.IsNullOrWhiteSpace(equipo.nombre))
                throw new ArgumentException("El nombre del equipo no puede estar vacío.");

            if (EquipoDAO.existeNombre(equipo.nombre, equipo.id))
                throw new ArgumentException("Ya existe un equipo con ese nombre.");

            // Solo validar cantidad si es un alta o cambió de disciplina
            if (equipoOriginal == null || equipoOriginal.disciplina.id != equipo.disciplina.id)
            {
                int cantidadActual = EquipoDAO.countEquiposByDisciplina(equipo.disciplina.id);
                int cantidadMaxima = DisciplinaBusiness.getCantidadEquiposDisciplina(equipo.disciplina.id);

                if (cantidadActual >= cantidadMaxima)
                    throw new ArgumentException($"No se pueden agregar más de {cantidadMaxima} equipos a la disciplina.");
            }
        }

        public static EquiposEntity getEquipoById(int id)
        {
            try
            {
                return EquipoDAO.getEquipoById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el equipo por ID: " + ex.Message);
            }
        }

        public static void updateResultadosEquipos(PartidosEntity partido)
        {
            try
            {
                EquiposEntity ganador = partido.ganador;
                EquiposEntity perdedor;

                if (ganador.id == partido.equipo1.id)
                {
                    perdedor = partido.equipo2;
                }
                else
                {
                    perdedor = partido.equipo1;
                }

                ganador.PGTorneo++;
                ganador.puntos += 3;
                perdedor.PPTorneo++;

                EquipoDAO.updateEstadisticasEquipo(ganador);
                EquipoDAO.updateEstadisticasEquipo(perdedor);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron actualizar los resultados", ex);
            }
        }

        public static void deleteEquipoById(int id)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    EquiposEntity equipo = EquipoDAO.getEquipoById(id);

                    BracketDAO bracketDAO = new BracketDAO();

                    bracketDAO.limpiarEquiposDeBrackets(equipo.disciplina.id);
                    PartidoDAO.deletePartidosByEquipo(id);


                    JugadorDAO.deleteJugadoresByEquipo(id);

                    // borramos el equipo
                    EquipoDAO.deleteEquipoById(id);

                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el equipo: " + ex.Message);
            }
        }
    }
}