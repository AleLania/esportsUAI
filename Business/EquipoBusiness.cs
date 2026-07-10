using Data;
using Entities;
using Mapper;
using System;
using System.Collections.Generic;
using System.Text;
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
            List<EquiposEntity.EquiposTorneoEntity> listOfEquipos = new List<EquiposEntity.EquiposTorneoEntity>();
            foreach (EquiposEntity equipo in EquipoDAO.getEquipos())
            {
                EquiposEntity.EquiposTorneoEntity equipoTorneo = new EquiposEntity.EquiposTorneoEntity(
                    equipo.nombre, equipo.PGTorneo, equipo.PPTorneo, equipo.PETorneo, equipo.puntos);

                listOfEquipos.Add(equipoTorneo);
            }
            return listOfEquipos;

        }


        /* public static List<EquiposEntity> EquiposByDisciplina(int idDisciplina)
          {
              List<EquiposEntity> listOfEquipos = getEquipos();
              List<EquiposEntity> filteredList = new List<EquiposEntity>();

              foreach (var equipo in listOfEquipos)
              {
                  if (equipo.disciplina.id == idDisciplina)
                  {
                      filteredList.Add(equipo);
                  }
              }
              return filteredList; 
          }*/
        public static void insertEquipo(string nombre, int idDisciplina) 
        {
            try
            {
                EquiposEntity newEquipo = new EquiposEntity(
                nombre, idDisciplina);
                EquipoDAO.insertEquipo(newEquipo);
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
                EquiposEntity updatedEquipo = new EquiposEntity(
                nombre, id);

                EquipoDAO.updateEquipo(updatedEquipo);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

    }
}
