using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class ResultadosBusiness
    {
        public static List<EquiposEntity.EquiposTorneoEntity> getResultados(int idDisciplina)
        {
            try
            {
                List<EquiposEntity> listOfEntities = ResultadoDAO.getPosiciones(idDisciplina);
                List<EquiposEntity.EquiposTorneoEntity> resultList = new List<EquiposEntity.EquiposTorneoEntity>();

                foreach (EquiposEntity equipo in listOfEntities)
                {
                    EquiposEntity.EquiposTorneoEntity equipoTorneo = new EquiposEntity.EquiposTorneoEntity(equipo);
                    resultList.Add(equipoTorneo);
                }

                return resultList;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public static List<BracketsEntity.BracketsLayer> getBrackets(int idDisciplina)
        {
            try
            {
                 List<BracketsEntity> listOfEntities = ResultadoDAO.getBrackets(idDisciplina);
                List<BracketsEntity.BracketsLayer> listOfLayers = new List<BracketsEntity.BracketsLayer>();

                foreach (BracketsEntity entity in listOfEntities)
                {
                    listOfLayers.Add(new BracketsEntity.BracketsLayer(entity));
                }

                return listOfLayers;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
