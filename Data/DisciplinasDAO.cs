using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Mapper;
using System.Security.Cryptography;

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
                                disciplinasList.Add(DisciplinasMapper.Map(reader));
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

        public static DisciplinasEntity getDisciplinaById(int idDisciplina)
        {
            DisciplinasEntity disciplina = null;
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                using (conexion)
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Disciplinas WHERE ID_DISCIPLINA = @idDisciplina", conexion))
                    {
                        cmd.Parameters.AddWithValue("@idDisciplina", idDisciplina);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                disciplina = DisciplinasMapper.Map(reader);
                            }
                        }
                    }
                    return disciplina;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static int getCantidadJugadoresPorDisciplina(int idDisciplina)
        {
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);

                conexion.Open();

                string sql = @"SELECT CANTIDAD_JUGADORES_EQUIPO
                       FROM Disciplinas
                       WHERE ID_DISCIPLINA = @idDisciplina";

                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idDisciplina", idDisciplina);

                    object resultado = cmd.ExecuteScalar();

                    return Convert.ToInt32(resultado);
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
