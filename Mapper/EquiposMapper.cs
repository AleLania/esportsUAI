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


        public static List<EquiposEntity.EquiposTorneoEntity> equiposByPuntos(SqlDataReader reader)
        {
            List<EquiposEntity.EquiposTorneoEntity> equiposTorneoEntities = new List<EquiposTorneoEntity>();
            while (reader.Read())
            {
                EquiposEntity.EquiposTorneoEntity equipo = new EquiposEntity.EquiposTorneoEntity(
                    reader["NOMBRE"].ToString(),
                    Convert.ToInt32(reader["PG_TORNEO"]),
                    Convert.ToInt32(reader["PP_TORNEO"]),
                    Convert.ToInt32(reader["PE_TORNEO"]),
                    Convert.ToInt32(reader["PUNTOS"])
                );
                equiposTorneoEntities.Add(equipo);
            }
            return equiposTorneoEntities;
        }
    }
}
