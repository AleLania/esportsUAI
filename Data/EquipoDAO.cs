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

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Equipos", conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EquiposEntity equipo = new EquiposEntity(
                                    Convert.ToInt32(reader["ID_EQUIPO"]),
                                    reader["NOMBRE"].ToString(),
                                    Convert.ToInt32(reader["ID_DISCIPLINA"]),
                                    Convert.ToInt32(reader["cantidad_jugadores"])
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
    }
}
