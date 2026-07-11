using Entities;
using Mapper;
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
                    string sql = "SELECT e.*, d.ID_DISCIPLINA,d.DESCRIPCION, d.CANTIDAD_JUGADORES_EQUIPO, d.CANTIDAD_EQUIPOS \r\nFROM Equipos e\r\nINNER JOIN Disciplinas d ON e.ID_DISCIPLINA = d.ID_DISCIPLINA";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DisciplinasEntity disciplina = DisciplinasMapper.Map(reader);

                                EquiposEntity equipo = EquiposMapper.equiposByPuntos(reader, disciplina);

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
                        cmd.Parameters.AddWithValue("@disciplina", equipo.disciplina.id);
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

        public static int countEquiposByDisciplina(int idDisciplina)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                using (conexion)
                {
                    conexion.Open();

                    string sql = "SELECT COUNT(*) FROM Equipos WHERE ID_DISCIPLINA = @idDisciplina";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idDisciplina", idDisciplina);
                        object resultado = cmd.ExecuteScalar();

                        int cantidadEquipos = Convert.ToInt32(resultado);

                        return cantidadEquipos;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EquiposEntity> getEquiposByDisciplina(int idDisciplina)
        {
            List<EquiposEntity> equiposList = new List<EquiposEntity>();
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                using (conexion)
                {
                    conexion.Open();
                    string sql = "SELECT e.*, d.ID_DISCIPLINA,d.DESCRIPCION, d.CANTIDAD_JUGADORES_EQUIPO, d.CANTIDAD_EQUIPOS \r\nFROM Equipos e\r\nINNER JOIN Disciplinas d ON e.ID_DISCIPLINA = d.ID_DISCIPLINA WHERE e.ID_DISCIPLINA = @idDisciplina";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idDisciplina", idDisciplina);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DisciplinasEntity disciplina = DisciplinasMapper.Map(reader);
                                EquiposEntity equipo = EquiposMapper.equiposByPuntos(reader, disciplina);
                                equiposList.Add(equipo);
                            }
                        }
                    }
                    return equiposList;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static EquiposEntity getEquipoById(int idEquipo)
        {
            EquiposEntity equipo = null;
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                using (conexion)
                {
                    conexion.Open();
                    string sql = "SELECT e.*, d.ID_DISCIPLINA,d.DESCRIPCION, d.CANTIDAD_JUGADORES_EQUIPO, d.CANTIDAD_EQUIPOS \r\nFROM Equipos e\r\nINNER JOIN Disciplinas d ON e.ID_DISCIPLINA = d.ID_DISCIPLINA WHERE e.ID_EQUIPO = @idEquipo";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idEquipo", idEquipo);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DisciplinasEntity disciplina = DisciplinasMapper.Map(reader);
                                equipo = EquiposMapper.equiposByPuntos(reader, disciplina);

                                return equipo;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return equipo;
        }

        public static void updateEstadisticasEquipo(EquiposEntity equipo)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                using (conexion)
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Equipos SET PG_TORNEO = @pg, PP_TORNEO = @pp PUNTOS = @puntos WHERE ID_EQUIPO = @id", conexion))
                    {
                        cmd.Parameters.AddWithValue("@pg", equipo.PGTorneo);
                        cmd.Parameters.AddWithValue("@pp", equipo.PPTorneo);
                        cmd.Parameters.AddWithValue("@puntos", equipo.puntos);
                        cmd.Parameters.AddWithValue("@id", equipo.id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
