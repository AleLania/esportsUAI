using Entities;
using Microsoft.Data.SqlClient;

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
                                    Convert.ToInt32(reader["ID_DISCIPLINA"])
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
    }
}
