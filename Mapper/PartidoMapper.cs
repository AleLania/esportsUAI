using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public class PartidoMapper
    {
        public static PartidosEntity Map(SqlDataReader reader)
        {
            PartidosEntity partido = new PartidosEntity();

            partido.id = Convert.ToInt32(reader["ID_PARTIDO"]);
            partido.equipo1 = Convert.ToInt32(reader["EQUIPO1"]);
            partido.equipo2 = Convert.ToInt32(reader["EQUIPO2"]);
            partido.ganador = Convert.ToInt32(reader["EQUIPO2"]);
            partido.idCompetencia = Convert.ToInt32(reader["ID_COMPETENCIA"]);

            return partido;
        }
    }
}
