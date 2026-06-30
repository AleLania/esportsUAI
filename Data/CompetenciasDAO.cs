using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.Data.SqlClient;

namespace Data
{
    public static class CompetenciasDAO
    {

        public static List<CompetenciasEntity> getCompetencias()
        {
            List<Entities.CompetenciasEntity> competenciasList = new List<Entities.CompetenciasEntity>();
            try
            {
                using (var conexion = new Microsoft.Data.SqlClient.SqlConnection(ConnectionString.connectionString))
                {
                    conexion.Open();
                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand("SELECT * FROM Competencias", conexion))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Entities.CompetenciasEntity competencia = new CompetenciasEntity(
                                    Convert.ToInt32(reader["ID_COMPETENCIA"]),
                                    reader["DESCRIPCION"].ToString()
                                );
                                competenciasList.Add(competencia);
                            }
                        }
                    }
                }
                return competenciasList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
