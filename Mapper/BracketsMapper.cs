using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class BracketsMapper
    {
        public static BracketsEntity map(SqlDataReader reader, EquiposEntity equipo1, EquiposEntity equipo2, DisciplinasEntity disciplina)
        {
            BracketsEntity bracket = new BracketsEntity(
                Convert.ToInt32(reader["ID_BRACKET"]),
                reader["INSTANCIA"].ToString(),
                disciplina,
                equipo1,
                equipo2
            );
            return bracket;
        }
    }
}
