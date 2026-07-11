using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Mapper;
using Microsoft.VisualBasic;

namespace Data
{
    public class BracketDAO
    {
        public List<BracketsEntity> ObtenerBrackets()
        {
            List<BracketsEntity> brackets = new List<BracketsEntity>();

            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    conexion.Open();

                    string sql = "SELECT " +
                        "B.ID_BRACKET, " +
                        "B.INSTANCIA, " +
                        "D.ID_DISCIPLINA, " +
                        "D.DESCRIPCION, " +
                        "D.CANTIDAD_JUGADORES_EQUIPO, " +
                        "E1.ID_EQUIPO AS ID_EQUIPO1, " +
                        "E1.NOMBRE AS NOMBRE_EQUIPO1, " +
                        "E2.ID_EQUIPO AS ID_EQUIPO2, " +
                        "E2.NOMBRE AS NOMBRE_EQUIPO2, " +
                        "B.ID_SIGUIENTE_BRACKET, " +
                        "B.ID_PARTIDO " +
                        "FROM Brackets B " +
                        "INNER JOIN Disciplinas D " +
                        "ON B.ID_DISCIPLINA = D.ID_DISCIPLINA " +
                        "LEFT JOIN Equipos E1 " +
                        "ON B.ID_EQUIPO1 = E1.ID_EQUIPO " +
                        "LEFT JOIN Equipos E2 " +
                        "ON B.ID_EQUIPO2 = E2.ID_EQUIPO;";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                brackets.Add(BracketsMapper.Map(reader));
                            }
                        }
                    }
                }

                return brackets;
            }

            catch (Exception)
            {
                throw;
            }

        }

        public BracketsEntity? ObtenerBracketDisponible(int idDisciplina)
        {
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    string sql = "SELECT TOP 1 " +
                        "B.ID_BRACKET, " +
                        "B.INSTANCIA, " +
                        "B.ID_SIGUIENTE_BRACKET, " +
                        "B.ID_PARTIDO, " +
                        "D.ID_DISCIPLINA, " +
                        "D.DESCRIPCION, " +
                        "D.CANTIDAD_JUGADORES_EQUIPO " +
                        "FROM Brackets B " +
                        "INNER JOIN Disciplinas D " +
                        "ON B.ID_DISCIPLINA = D.ID_DISCIPLINA " +
                        "WHERE " +
                        "B.ID_DISCIPLINA = @idDisciplina " +
                        "AND B.INSTANCIA LIKE 'cuartos%' " +
                        "AND B.ID_EQUIPO1 IS NULL " +
                        "AND B.ID_EQUIPO2 IS NULL " +
                        "ORDER BY B.ID_BRACKET";

                    conexion.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("@idDisciplina", idDisciplina);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return BracketsMapper.MapBracket(reader);
                            }
                        }
                    }
                }

                return null;
            }

            catch (Exception ex)
            {
                throw new Exception("Error al obtener un bracket disponible.", ex);
            }

        }

        public BracketsEntity? ObtenerBracketPorEquipos(int idEquipo1, int idEquipo2, int idDisciplina)
        {
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);

                string sql =
                    "SELECT " +
                    "B.ID_BRACKET, " +
                    "B.INSTANCIA, " +
                    "B.ID_SIGUIENTE_BRACKET, " +
                    "B.ID_PARTIDO, " +
                    "D.ID_DISCIPLINA, " +
                    "D.DESCRIPCION, " +
                    "D.CANTIDAD_JUGADORES_EQUIPO " +
                    "FROM Brackets B " +
                    "INNER JOIN Disciplinas D " +
                    "ON B.ID_DISCIPLINA = D.ID_DISCIPLINA " +
                    "WHERE B.ID_DISCIPLINA = @idDisciplina " +
                    "AND ( " +
                    "    (B.ID_EQUIPO1 = @idEquipo1 AND B.ID_EQUIPO2 = @idEquipo2) " +
                    " OR (B.ID_EQUIPO1 = @idEquipo2 AND B.ID_EQUIPO2 = @idEquipo1) " +
                    ")";

                using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                {
                    sqlCommand.Parameters.AddWithValue("@idDisciplina", idDisciplina);
                    sqlCommand.Parameters.AddWithValue("@idEquipo1", idEquipo1);
                    sqlCommand.Parameters.AddWithValue("@idEquipo2", idEquipo2);

                    conexion.Open();

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return BracketsMapper.MapBracket(reader);
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el bracket por equipos.", ex);
            }
        }

        public void AsignarEquipos(int idBracket, int idEquipo1, int idEquipo2)
        {
            try
            {

                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    conexion.Open();

                    string sql = "UPDATE Brackets " +
                        "SET ID_EQUIPO1 = @idEquipo1, ID_EQUIPO2 = @idEquipo2 " +
                        "WHERE ID_BRACKET = @idBracket; ";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("@idBracket", idBracket);
                        sqlCommand.Parameters.AddWithValue("@idEquipo1", idEquipo1);
                        sqlCommand.Parameters.AddWithValue("@idEquipo2", idEquipo2);

                        sqlCommand.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron asignar los equipos al bracket", ex);
            }
        }
    }
}
