using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace Data
{
    public static class EquipoDAO
    {
        public static List<EquiposEntity> getEquipos()
        {
            List<EquiposEntity> equiposLIst = new List<EquiposEntity>();
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);

                using (conexion)
                {
                    conexion.Open();
                    string sql = "SELECT e.*, d.ID_DISCIPLINA,d.DESCRIPCION, d.CANTIDAD_JUGADORES_EQUIPO \r\nFROM Equipos e\r\nINNER JOIN Disciplinas d ON e.ID_DISCIPLINA = d.ID_DISCIPLINA";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DisciplinasEntity disciplina = new DisciplinasEntity(
                                    Convert.ToInt32(reader["ID_DISCIPLINA"]),
                                    reader["DESCRIPCION"].ToString(),
                                    Convert.ToInt32(reader["CANTIDAD_JUGADORES_EQUIPO"]));

                                EquiposEntity equipo = new EquiposEntity(
                                    Convert.ToInt32(reader["ID_EQUIPO"]),
                                    reader["NOMBRE"].ToString(),
                                    disciplina,
                                    Convert.ToInt32(reader["PG_TORNEO"]),
                                    Convert.ToInt32(reader["PP_TORNEO"]),
                                    Convert.ToInt32(reader["PE_TORNEO"]),
                                    Convert.ToInt32(reader["PUNTOS"])
                                );
                                equiposLIst.Add(equipo);
                            }

                        }
                    }
                    return equiposLIst;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void insertEquipo(EquiposEntity equipo)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                using (conexion)
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Equipos (NOMBRE, ID_DISCIPLINA) VALUES (@nombre, @disciplina)", conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", equipo.nombre);
                        cmd.Parameters.AddWithValue("@disciplina", equipo.disciplina);
                        cmd.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void updateEquipo(EquiposEntity equipo)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                using (conexion)
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Equipos SET NOMBRE = @nombre WHERE ID_EQUIPO = @id", conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = equipo.nombre;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = equipo.id;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public static List<EquiposEntity> getPosiciones(int idDisciplina)
        {
            List<EquiposEntity> equiposByPuntos = new List<EquiposEntity>();
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
                            while (reader.Read())
                            {
                                DisciplinasEntity disciplina = new DisciplinasEntity(
                                    Convert.ToInt32(reader["ID_DISCIPLINA"]),
                                    reader["DESCRIPCION"].ToString(),
                                    Convert.ToInt32(reader["CANTIDAD_JUGADORES_EQUIPO"]));
                                EquiposEntity equipo = new EquiposEntity(
                                    Convert.ToInt32(reader["ID_EQUIPO"]),
                                    reader["NOMBRE"].ToString(),
                                    disciplina,
                                    Convert.ToInt32(reader["PG_TORNEO"]),
                                    Convert.ToInt32(reader["PP_TORNEO"]),
                                    Convert.ToInt32(reader["PE_TORNEO"]),
                                    Convert.ToInt32(reader["PUNTOS"])
                                );
                                equiposByPuntos.Add(equipo);
                            }
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
    }
}
