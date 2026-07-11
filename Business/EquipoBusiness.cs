using Data;
using Entities;
using Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                    EquiposEntity.EquiposTorneoEntity equipoTorneo = new EquiposEntity.EquiposTorneoEntity(
                        equipo);

                    listOfEquipos.Add(equipoTorneo);
                }
                return listOfEquipos;
            }
            catch (Exception ex)
            {
                throw;

            }
        }


        public static List<EquiposEntity> getEquiposByDisciplina(int idDisciplina)
        {
            try
            {
                List<EquiposEntity> listOfEquipos = EquipoDAO.getEquiposByDisciplina(idDisciplina);

                return listOfEquipos;
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

                if (string.IsNullOrEmpty(nombre))
                {
                    throw new ArgumentException("El nombre del equipo no puede estar vacío.");
                }
                if (idDisciplina == null)
                {
                    throw new ArgumentException("La disciplina no debe estar vacia");
                }
                if (EquipoDAO.getEquipos().Exists(e => e.nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException("Ya existe un equipo con ese nombre.");
                }
                if (EquipoDAO.countEquiposByDisciplina(idDisciplina) == DisciplinaBusiness.getCantidadEquiposDisciplina(idDisciplina))
                {
                    throw new ArgumentException("No se pueden agregar más de 8 equipos a la disciplina.");
                }
                using (var trx = new TransactionScope())
                {
                    EquiposEntity newEquipo = new EquiposEntity(
                nombre, DisciplinaBusiness.getDisciplinaById(idDisciplina));
                    EquipoDAO.insertEquipo(newEquipo);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void updateEquipo(string nombre, int id)
        {
            try
            {
                if (string.IsNullOrEmpty(nombre))
                {
                    throw new ArgumentException("El nombre del equipo no puede estar vacío.");
                }
                using (var trx = new TransactionScope())
                {
                    EquiposEntity updatedEquipo = new EquiposEntity(
                    nombre, id);

                    EquipoDAO.updateEquipo(updatedEquipo);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
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

                if(ganador.id == partido.equipo1.id)
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
    }
}
