using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class PartidoMapper
    {
        public static PartidosEntity Map(SqlDataReader reader)
        {
            DisciplinasEntity disciplina = new DisciplinasEntity(
        Convert.ToInt32(reader["ID_DISCIPLINA"]),
        reader["DESCRIPCION_DISCIPLINA"].ToString(),
        Convert.ToInt32(reader["CANTIDAD_JUGADORES_EQUIPO"]),
        Convert.ToInt32(reader["CANTIDAD_EQUIPOS"])
    );
            CompetenciasEntity competencia = new CompetenciasEntity(
                Convert.ToInt32(reader["ID_COMPETENCIA"]),
                reader["DESCRIPCION_COMPETENCIA"].ToString()
            );

            EquiposEntity equipo1 = new EquiposEntity(
                Convert.ToInt32(reader["EQUIPO1"]),
                reader["NOMBRE_EQUIPO1"].ToString(),
                disciplina,
                reader["PG_EQUIPO1"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PG_EQUIPO1"]),
                reader["PP_EQUIPO1"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PP_EQUIPO1"]),
                reader["PUNTOS_EQUIPO1"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PUNTOS_EQUIPO1"])
            );

            EquiposEntity equipo2 = new EquiposEntity(
                Convert.ToInt32(reader["EQUIPO2"]),
                reader["NOMBRE_EQUIPO2"].ToString(),
                disciplina,
                reader["PG_EQUIPO2"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PG_EQUIPO2"]),
                reader["PP_EQUIPO2"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PP_EQUIPO2"]),
                reader["PUNTOS_EQUIPO2"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PUNTOS_EQUIPO2"])
            );

            EquiposEntity ganador = new EquiposEntity(
                Convert.ToInt32(reader["GANADOR"]),
                reader["NOMBRE_GANADOR"].ToString(),
                disciplina,
                0, 0, 0
            );

            return new PartidosEntity(equipo1, equipo2, ganador, competencia, disciplina);
        }
    }
}
