using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Mapper;

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
                                brackets.Add(BracketMapper.Map(reader));
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
    }
}
