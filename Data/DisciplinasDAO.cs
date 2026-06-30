using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Data
{
    public static class DisciplinasDAO
    {

        public static List<DisciplinasEntity> getDisciplinas()
        {
            List<DisciplinasEntity> disciplinasList = new List<DisciplinasEntity>();
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                using (conexion)
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Disciplinas", conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DisciplinasEntity disciplina = new DisciplinasEntity(
                                    Convert.ToInt32(reader["ID_DISCIPLINA"]),
                                    reader["DESCRIPCION"].ToString(),
                                    Convert.ToInt32(reader["CANTIDAD_JUGADORES_EQUIPO"])
                                );
                                disciplinasList.Add(disciplina);
                            }
                        }
                    }
                    return disciplinasList;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
