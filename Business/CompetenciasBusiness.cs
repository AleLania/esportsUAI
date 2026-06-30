using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class CompetenciasBusiness
    {

        public static List<Entities.CompetenciasEntity> getCompetencias()
        {
            return Data.CompetenciasDAO.getCompetencias();
        }
    }
}
