using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.Data.SqlClient;


namespace Mapper
{
    public static class JugadorMapper
    {
        public static JugadoresEntity Map(SqlDataReader reader)
        {
            DisciplinasEntity disciplina = new DisciplinasEntity(
                Convert.ToInt32(reader["ID_DISCIPLINA"]),
                reader["DESCRIPCION_DISCIPLINA"].ToString(),
                Convert.ToInt32(reader["CANTIDAD_JUGADORES_EQUIPO"]),
                Convert.ToInt32(reader["CANTIDAD_EQUIPOS"])
            );

            EquiposEntity equipo = new EquiposEntity(
                Convert.ToInt32(reader["ID_EQUIPO"]),
                reader["NOMBRE_EQUIPO"].ToString(),
                disciplina,
                reader["PG_TORNEO"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PG_TORNEO"]),
                reader["PP_TORNEO"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PP_TORNEO"]),
                reader["PUNTOS"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PUNTOS"])
            );

            return new JugadoresEntity(
                Convert.ToInt32(reader["ID_JUGADOR"]),
                reader["NOMBRE_APELLIDO"].ToString(),
                reader["NICK"].ToString(),
                equipo
            );
        }
    }
}
