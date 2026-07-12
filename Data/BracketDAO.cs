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
            public List<BracketsEntity> getBrackets()
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
                            "D.CANTIDAD_EQUIPOS, " +
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

            public BracketsEntity? getBracketPorId(int idBracket)
            {
                try
                {
                    using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);

                    string sql =
                        "SELECT " +
                        "B.ID_BRACKET, " +
                        "B.INSTANCIA, " +
                        "D.ID_DISCIPLINA, " +
                        "D.DESCRIPCION, " +
                        "D.CANTIDAD_EQUIPOS, " +
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
                        "ON B.ID_EQUIPO2 = E2.ID_EQUIPO " +
                        "WHERE B.ID_BRACKET = @idBracket";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("@idBracket", idBracket);

                        conexion.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return BracketsMapper.Map(reader);
                            }
                        }
                    }

                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el bracket por ID.", ex);
                }
            }

            public BracketsEntity? getBracketDisponible(int idDisciplina)
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
                            "D.CANTIDAD_EQUIPOS, " +
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

            public BracketsEntity? getBracketPorEquipos(int idEquipo1, int idEquipo2, int idDisciplina)
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
                        "D.CANTIDAD_EQUIPOS, " +
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

            public void asignarEquipos(int idBracket, int idEquipo1, int idEquipo2)
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

            public void asignarPartido(int idBracket, int idPartido)
            {
                try
                {

                    using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                    {
                        conexion.Open();

                        string sql = "UPDATE Brackets " +
                            "SET ID_PARTIDO = @idPartido " +
                            "WHERE ID_BRACKET = @idBracket; ";

                        using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                        {
                            sqlCommand.Parameters.AddWithValue("@idPartido", idPartido);
                            sqlCommand.Parameters.AddWithValue("@idBracket", idBracket);

                            sqlCommand.ExecuteNonQuery();

                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("No se pudo asignar el partido al bracket", ex);
                }

            }

            //tuve que armar esto porque no me salio armar uno generico que sirva para ambos equipos
            public void actualizarEquipo1(int idBracket, int idEquipo)
            {
                try
                {
                    using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                    {
                        conexion.Open();

                        string sql = "UPDATE Brackets " +
                                     "SET ID_EQUIPO1 = @idEquipo " +
                                     "WHERE ID_BRACKET = @idBracket";

                        using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                        {
                            sqlCommand.Parameters.AddWithValue("@idEquipo", idEquipo);
                            sqlCommand.Parameters.AddWithValue("@idBracket", idBracket);

                            sqlCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("No se pudo actualizar el equipo 1 del bracket.", ex);
                }
            }

            public void actualizarEquipo2(int idBracket, int idEquipo)
            {
                try
                {
                    using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                    {
                        conexion.Open();

                        string sql = "UPDATE Brackets " +
                                     "SET ID_EQUIPO2 = @idEquipo " +
                                     "WHERE ID_BRACKET = @idBracket";

                        using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                        {
                            sqlCommand.Parameters.AddWithValue("@idEquipo", idEquipo);
                            sqlCommand.Parameters.AddWithValue("@idBracket", idBracket);

                            sqlCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("No se pudo actualizar el equipo 2 del bracket.", ex);
                }
            }

            public List<BracketsEntity> getBracketsDeCuartos(int idDisciplina)
            {
                List<BracketsEntity> brackets = new List<BracketsEntity>();
                try
                {
                    using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                    conexion.Open();
                    string sql = @"
                SELECT 
                    B.ID_BRACKET,
                    B.INSTANCIA,
                    B.ID_SIGUIENTE_BRACKET,
                    B.ID_PARTIDO,
                    D.ID_DISCIPLINA,
                    D.DESCRIPCION,
                    D.CANTIDAD_JUGADORES_EQUIPO,
                    D.CANTIDAD_EQUIPOS
                FROM Brackets B
                INNER JOIN Disciplinas D ON B.ID_DISCIPLINA = D.ID_DISCIPLINA
                WHERE B.ID_DISCIPLINA = @idDisciplina
                  AND B.INSTANCIA LIKE 'cuartos%'
                ORDER BY B.ID_BRACKET";

                    using SqlCommand cmd = new SqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@idDisciplina", idDisciplina);
                    using SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        brackets.Add(BracketsMapper.MapBracket(reader));
                    }
                    return brackets;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public List<BracketsEntity> getBracketsConEquipos(int idDisciplina)
            {
                List<BracketsEntity> brackets = new List<BracketsEntity>();
                try
                {
                    using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                    conexion.Open();
                    string sql = @"
                SELECT 
                    b.ID_BRACKET,
                    b.INSTANCIA,
                    b.ID_SIGUIENTE_BRACKET,
                    b.ID_PARTIDO,
                    d.ID_DISCIPLINA,
                    d.DESCRIPCION,
                    d.CANTIDAD_JUGADORES_EQUIPO,
                    d.CANTIDAD_EQUIPOS,
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
                INNER JOIN Disciplinas d ON b.ID_DISCIPLINA = d.ID_DISCIPLINA
                LEFT JOIN Equipos e1     ON b.ID_EQUIPO1    = e1.ID_EQUIPO
                LEFT JOIN Equipos e2     ON b.ID_EQUIPO2    = e2.ID_EQUIPO
                WHERE b.ID_DISCIPLINA = @idDisciplina
                  AND b.ID_EQUIPO1 IS NOT NULL
                  AND b.ID_EQUIPO2 IS NOT NULL
                  AND b.ID_PARTIDO IS NULL
                ORDER BY b.ID_BRACKET";

                    using SqlCommand cmd = new SqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@idDisciplina", idDisciplina);
                    using SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DisciplinasEntity disciplina = new DisciplinasEntity(
                            Convert.ToInt32(reader["ID_DISCIPLINA"]),
                            reader["DESCRIPCION"].ToString(),
                            Convert.ToInt32(reader["CANTIDAD_JUGADORES_EQUIPO"]),
                            Convert.ToInt32(reader["CANTIDAD_EQUIPOS"])
                        );
                        brackets.Add(BracketsMapper.MapBracket(reader, disciplina));
                    }
                    return brackets;
                }
                catch (Exception) { throw; }
            }
        }
    }
