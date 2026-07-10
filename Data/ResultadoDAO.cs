using Entities;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Data
{
    public static class ResultadoDAO
    {
        public static List<EquiposEntity.EquiposTorneoEntity> getPosiciones(int idDisciplina)
        {
            List<EquiposEntity.EquiposTorneoEntity> equiposByPuntos = new List<EquiposEntity.EquiposTorneoEntity>();
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                using (conexion)
                {
                    conexion.Open();
                    string sql = "SELECT e.*, d.ID_DISCIPLINA,d.DESCRIPCION, d.CANTIDAD_JUGADORES_EQUIPO \r\nFROM Equipos e\r\nINNER JOIN Disciplinas d ON e.ID_DISCIPLINA = d.ID_DISCIPLINA\r\nWHERE e.ID_DISCIPLINA = @idDisciplina\r\nORDER BY e.PUNTOS DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idDisciplina", idDisciplina);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            equiposByPuntos = EquiposMapper.equiposByPuntos(reader);
                        }
                    }
                    return equiposByPuntos;
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static List<BracketsEntity> getBrackets(int idDisciplina)
        {
            List<BracketsEntity> brackets = new List<BracketsEntity>();
            try
            {
                DisciplinasEntity disciplina = DisciplinasDAO.getDisciplinaById(idDisciplina);

                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                using (conexion)
                {
                    conexion.Open();
                    string sql = @"
                SELECT 
                        b.ID_BRACKET,
                        b.INSTANCIA,
                        e1.ID_EQUIPO                AS ID_EQUIPO1,
                        e1.NOMBRE                   AS NOMBRE_EQUIPO1,
                        e1.PG_TORNEO                AS PG_EQUIPO1,
                        e1.PP_TORNEO                AS PP_EQUIPO1,
                        e1.PE_TORNEO                AS PE_EQUIPO1,
                        e1.PUNTOS                   AS PUNTOS_EQUIPO1,
                        e2.ID_EQUIPO                AS ID_EQUIPO2,
                        e2.NOMBRE                   AS NOMBRE_EQUIPO2,
                        e2.PG_TORNEO                AS PG_EQUIPO2,
                        e2.PP_TORNEO                AS PP_EQUIPO2,
                        e2.PE_TORNEO                AS PE_EQUIPO2,
                        e2.PUNTOS                   AS PUNTOS_EQUIPO2
                    FROM Brackets b
                    LEFT JOIN Equipos e1 ON b.ID_EQUIPO1 = e1.ID_EQUIPO
                    LEFT JOIN Equipos e2 ON b.ID_EQUIPO2 = e2.ID_EQUIPO
                    WHERE b.ID_DISCIPLINA = @idDisciplina";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idDisciplina", idDisciplina);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EquiposEntity equipo1 = reader["ID_EQUIPO1"] == DBNull.Value ? null : new EquiposEntity(
                                    Convert.ToInt32(reader["ID_EQUIPO1"]),
                                    reader["NOMBRE_EQUIPO1"]?.ToString() ?? string.Empty,
                                    disciplina,
                                    Convert.ToInt32(reader["PG_EQUIPO1"]),
                                    Convert.ToInt32(reader["PP_EQUIPO1"]),
                                    Convert.ToInt32(reader["PE_EQUIPO1"]),
                                    Convert.ToInt32(reader["PUNTOS_EQUIPO1"])
                                    );

                                EquiposEntity equipo2 = reader["ID_EQUIPO2"] == DBNull.Value ? null : new EquiposEntity(
                                    Convert.ToInt32(reader["ID_EQUIPO2"]),
                                    reader["NOMBRE_EQUIPO2"]?.ToString() ?? string.Empty,
                                    disciplina,
                                    Convert.ToInt32(reader["PG_EQUIPO2"]),
                                    Convert.ToInt32(reader["PP_EQUIPO2"]),
                                    Convert.ToInt32(reader["PE_EQUIPO2"]),
                                    Convert.ToInt32(reader["PUNTOS_EQUIPO2"])
                                );

                                BracketsEntity bracket = new BracketsEntity(
                                    Convert.ToInt32(reader["ID_BRACKET"]),
                                    reader["INSTANCIA"].ToString(),
                                    disciplina,
                                    equipo1,
                                    equipo2
                                );

                                brackets.Add(bracket);
                            }
                        }
                    }
                    return brackets;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
