using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using static Entities.EquiposEntity;

namespace Mapper
{
    public static class EquiposMapper
    {

        public static EquiposEntity equiposByPuntos(SqlDataReader reader, DisciplinasEntity disciplina)
        {
            return new EquiposEntity(
                Convert.ToInt32(reader["ID_EQUIPO"]),
                reader["NOMBRE"].ToString(),
                disciplina,
                reader["PG_TORNEO"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PG_TORNEO"]),
                reader["PP_TORNEO"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PP_TORNEO"]),
                reader["PE_TORNEO"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PE_TORNEO"]),
                reader["PUNTOS"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PUNTOS"])
            );
        }

        public static EquiposEntity mapEquipo(SqlDataReader reader, DisciplinasEntity disciplina, string sufijo)
        {
            if (reader["ID_EQUIPO" + sufijo] == DBNull.Value) return null;

            return new EquiposEntity(
                Convert.ToInt32(reader["ID_EQUIPO" + sufijo]),
                reader["NOMBRE_EQUIPO" + sufijo]?.ToString() ?? string.Empty,
                disciplina,
                Convert.ToInt32(reader["PG_EQUIPO" + sufijo]),
                Convert.ToInt32(reader["PP_EQUIPO" + sufijo]),
                Convert.ToInt32(reader["PE_EQUIPO" + sufijo]),
                Convert.ToInt32(reader["PUNTOS_EQUIPO" + sufijo])
            );
        }


        //mapper para que funcione el bracketmapper
        public static EquiposEntity MapBracket(SqlDataReader reader, int numeroEquipo)
        {
            //if porque el left join puede devolver null si leo una instancia de copa que no tiene resultado
            if (reader[$"ID_EQUIPO{numeroEquipo}"] == DBNull.Value)
                return null;

            EquiposEntity equipo = new EquiposEntity();

            equipo.id = Convert.ToInt32(reader[$"ID_EQUIPO{numeroEquipo}"]);
            equipo.nombre = reader[$"NOMBRE_EQUIPO{numeroEquipo}"].ToString();

            return equipo;
        }
    }
}
