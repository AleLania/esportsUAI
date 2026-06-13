using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class EquipoBusiness
    {

        public List<EquiposEntity> getEquipos()
        {
            return EquipoDAO.getEquipos();
            
        }

       // public List<EquiposEntity> insertEquipo(equipo) { }

    }
}
