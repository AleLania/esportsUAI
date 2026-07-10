using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class DisciplinasMapper
    {
        public static DisciplinasEntity Map(SqlDataReader reader)
        {
            DisciplinasEntity disciplina = new DisciplinasEntity(
                Convert.ToInt32(reader["ID_DISCIPLINA"]),
                reader["DESCRIPCION"].ToString(),
                Convert.ToInt32(reader["CANTIDAD_JUGADORES_EQUIPO"])
            );

            return disciplina;
        }
    }
}
