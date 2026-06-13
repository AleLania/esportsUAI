using Data;
using Entities;
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
