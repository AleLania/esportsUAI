using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class ResultadosBusiness
    {
        public static List<EquiposEntity> getResultados(int idDisciplina, int idCompetencia)
        {
            if(idCompetencia == 1) 
            {
                return EquipoDAO.getPosiciones(idDisciplina);
            }
            return null; //EquipoDAO.getBrackets(idDisciplina);
        }
    }
}
