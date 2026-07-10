using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using static Entities.EquiposEntity;

namespace Mapper
{
    public static class EquiposMapper
    {
        public static List<EquiposEntity> equiposByDisciplina(int idDisciplina,List<EquiposEntity> listOfEquipos)
        {
            return null;
        }


        public static EquiposEntity.EquiposTorneoEntity equiposByPuntos(SqlDataReader reader)
        {
            List<EquiposEntity.EquiposTorneoEntity> equiposTorneoEntities = new List<EquiposTorneoEntity>();
           
                EquiposEntity.EquiposTorneoEntity equipo = new EquiposEntity.EquiposTorneoEntity(
                    reader["NOMBRE"].ToString(),
                    Convert.ToInt32(reader["PG_TORNEO"]),
                    Convert.ToInt32(reader["PP_TORNEO"]),
                    Convert.ToInt32(reader["PE_TORNEO"]),
                    Convert.ToInt32(reader["PUNTOS"])
                );

            
            return equipo;
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
        public static EquiposEntity? MapBracket(SqlDataReader reader, int numeroEquipo)
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
