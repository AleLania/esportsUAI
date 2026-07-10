using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class ResultadosBusiness
    {
        public static List<EquiposEntity.EquiposTorneoEntity> getResultados(int idDisciplina, int idCompetencia)
        {
            try
            {
                if (idCompetencia == 1)
                {
                    return EquipoDAO.getPosiciones(idDisciplina);
                }
                return EquipoDAO.getBrackets(idDisciplina);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}
