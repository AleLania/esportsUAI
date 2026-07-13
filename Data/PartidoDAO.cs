using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.Data.SqlClient;
using Mapper;


namespace Data
{
    public class PartidoDAO
    {
        public List<PartidosEntity> ObtenerPartidos()
        {
            List<PartidosEntity> partidos = new List<PartidosEntity>();

            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                conexion.Open();
                string sql = @"
            SELECT 
                p.ID_PARTIDO,
                p.EQUIPO1,
                p.EQUIPO2,
                p.GANADOR,
                p.ID_COMPETENCIA,
                c.DESCRIPCION           AS DESCRIPCION_COMPETENCIA,
                e1.NOMBRE               AS NOMBRE_EQUIPO1,
                e1.PG_TORNEO            AS PG_EQUIPO1,
                e1.PP_TORNEO            AS PP_EQUIPO1,
                e1.PUNTOS               AS PUNTOS_EQUIPO1,
                e2.NOMBRE               AS NOMBRE_EQUIPO2,
                e2.PG_TORNEO            AS PG_EQUIPO2,
                e2.PP_TORNEO            AS PP_EQUIPO2,
                e2.PUNTOS               AS PUNTOS_EQUIPO2,
                eg.NOMBRE               AS NOMBRE_GANADOR,
                d.ID_DISCIPLINA,
                d.DESCRIPCION           AS DESCRIPCION_DISCIPLINA,
                d.CANTIDAD_JUGADORES_EQUIPO,
                d.CANTIDAD_EQUIPOS
            FROM Partidos p
            INNER JOIN Competencias c  ON p.ID_COMPETENCIA = c.ID_COMPETENCIA
            INNER JOIN Equipos e1      ON p.EQUIPO1        = e1.ID_EQUIPO
            INNER JOIN Equipos e2      ON p.EQUIPO2        = e2.ID_EQUIPO
            INNER JOIN Equipos eg      ON p.GANADOR        = eg.ID_EQUIPO
            INNER JOIN Disciplinas d   ON e1.ID_DISCIPLINA = d.ID_DISCIPLINA";

                using SqlCommand cmd = new SqlCommand(sql, conexion);
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DisciplinasEntity disciplina = new DisciplinasEntity(
                        Convert.ToInt32(reader["ID_DISCIPLINA"]),
                        reader["DESCRIPCION_DISCIPLINA"].ToString(),
                        Convert.ToInt32(reader["CANTIDAD_JUGADORES_EQUIPO"]),
                        Convert.ToInt32(reader["CANTIDAD_EQUIPOS"])
                    );
                    partidos.Add(PartidoMapper.Map(reader));
                }

                return partidos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CargarPartido(PartidosEntity partido)
        {
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    string sql = "INSERT INTO Partidos (EQUIPO1, EQUIPO2, GANADOR, ID_COMPETENCIA) VALUES (@Equipo1, @Equipo2, @Ganador, @IdCompetencia); SELECT SCOPE_IDENTITY()";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("@Equipo1", partido.equipo1.id);
                        sqlCommand.Parameters.AddWithValue("@Equipo2", partido.equipo2.id);
                        sqlCommand.Parameters.AddWithValue("@Ganador", partido.ganador.id);
                        sqlCommand.Parameters.AddWithValue("@IdCompetencia", partido.competencia.id);

                        conexion.Open();

                        object resultado = sqlCommand.ExecuteScalar();

                        partido.id = Convert.ToInt32(resultado);

                    }
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarPartido(PartidosEntity partido)
        {
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    string sql = "UPDATE Partidos " +
                        "SET EQUIPO1 = @Equipo1, EQUIPO2 = @Equipo2, GANADOR = @Ganador, ID_COMPETENCIA = @IdCompetencia " +
                        "WHERE ID_PARTIDO = @IdPartido; ";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("@IdPartido", partido.id);
                        sqlCommand.Parameters.AddWithValue("@Equipo1", partido.equipo1);
                        sqlCommand.Parameters.AddWithValue("@Equipo2", partido.equipo2);
                        sqlCommand.Parameters.AddWithValue("@Ganador", partido.ganador);
                        sqlCommand.Parameters.AddWithValue("@IdCompetencia", partido.competencia.id);
                        sqlCommand.Parameters.AddWithValue("@IdDisciplina", partido.disciplina.id);

                        conexion.Open();
                        sqlCommand.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PartidosEntity? ObtenerPartidoPorId(int  id)
        {
            PartidosEntity? partido = null;

            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    string sql = "SELECT FROM Partidos WHERE ID_PARTIDO = @IdPartido";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("IdPartido", id);
                        conexion.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                partido = PartidoMapper.Map(reader);
                            }
                        }
                    }
                }
            }

            catch (Exception)
            {
                throw;
            }

            return partido;
        }

        public List<PartidosEntity> getPartidosByEquipoYCompetencia(int idEquipo, int idCompetencia)
        {
            List<PartidosEntity> partidos = new List<PartidosEntity>();
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                conexion.Open();
                string sql = @"
                SELECT 
                    p.ID_PARTIDO,
                    p.EQUIPO1,
                    p.EQUIPO2,
                    p.GANADOR,
                    p.ID_COMPETENCIA,
                    c.DESCRIPCION               AS DESCRIPCION_COMPETENCIA,
                    e1.NOMBRE                   AS NOMBRE_EQUIPO1,
                    e1.PG_TORNEO                AS PG_EQUIPO1,
                    e1.PP_TORNEO                AS PP_EQUIPO1,
                    e1.PUNTOS                   AS PUNTOS_EQUIPO1,
                    e2.NOMBRE                   AS NOMBRE_EQUIPO2,
                    e2.PG_TORNEO                AS PG_EQUIPO2,
                    e2.PP_TORNEO                AS PP_EQUIPO2,
                    e2.PUNTOS                   AS PUNTOS_EQUIPO2,
                    eg.NOMBRE                   AS NOMBRE_GANADOR,
                    d.ID_DISCIPLINA,
                    d.DESCRIPCION               AS DESCRIPCION_DISCIPLINA,
                    d.CANTIDAD_JUGADORES_EQUIPO,
                    d.CANTIDAD_EQUIPOS
                FROM Partidos p
                INNER JOIN Competencias c  ON p.ID_COMPETENCIA = c.ID_COMPETENCIA
                INNER JOIN Equipos e1      ON p.EQUIPO1        = e1.ID_EQUIPO
                INNER JOIN Equipos e2      ON p.EQUIPO2        = e2.ID_EQUIPO
                INNER JOIN Equipos eg      ON p.GANADOR        = eg.ID_EQUIPO
                INNER JOIN Disciplinas d   ON e1.ID_DISCIPLINA = d.ID_DISCIPLINA
                WHERE (p.EQUIPO1 = @IdEquipo OR p.EQUIPO2 = @IdEquipo)
                  AND p.ID_COMPETENCIA = @IdCompetencia"; ;

                using SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);
                cmd.Parameters.AddWithValue("@IdCompetencia", idCompetencia);

                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    partidos.Add(PartidoMapper.Map(reader));
                }

                return partidos;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void deletePartidosByEquipo(int idEquipo)
        {
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                conexion.Open();
                using SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Partidos WHERE EQUIPO1 = @idEquipo OR EQUIPO2 = @idEquipo",
                    conexion);
                cmd.Parameters.AddWithValue("@idEquipo", idEquipo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
