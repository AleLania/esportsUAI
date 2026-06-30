using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class DisciplinaBusiness
    {
        public static List<DisciplinasEntity> getDisciplinas()
        {
            return DisciplinasDAO.getDisciplinas();
        }
    }
}
