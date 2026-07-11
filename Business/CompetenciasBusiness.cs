using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Business
{
    public static class CompetenciasBusiness
    {

        public static List<CompetenciasEntity> getCompetencias()
        {
            return Data.CompetenciasDAO.getCompetencias();
        }
    }
}
