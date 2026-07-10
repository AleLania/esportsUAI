using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.Data.SqlClient;
using Mapper;


namespace Data
{
    public class PartidoDAO
    {
        public List<PartidosEntity> ObtenerPartidos()
        {
            List<PartidosEntity> partidos = new List<PartidosEntity>();

            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    conexion.Open();
                    string sql = "SELECT * FROM Partidos";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        using SqlDataReader reader = sqlCommand.ExecuteReader();
                        {
                            while (reader.Read())
                            {
                                partidos.Add(PartidoMapper.Map(reader));
                            }
                        }
                    }

                    return partidos;
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void CargarPartido(PartidosEntity partido)
        {
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    string sql = "INSERT INTO Partidos (EQUIPO1, EQUIPO2, GANADOR, ID_COMPETENCIA) VALUES (@Equipo1, @Equipo2, @Ganador, @IdCompetencia)";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("Equipo1", partido.equipo1);
                        sqlCommand.Parameters.AddWithValue("Equipo2", partido.equipo2);
                        sqlCommand.Parameters.AddWithValue("Ganador", partido.ganador);
                        sqlCommand.Parameters.AddWithValue("IdCompetencia", partido.idCompetencia);

                        conexion.Open();
                        sqlCommand.ExecuteNonQuery();

                    }
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarPartido(PartidosEntity partido)
        {
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    string sql = "UPDATE Partidos " +
                        "SET EQUIPO1 = @Equipo1, EQUIPO2 = @Equipo2, GANADOR = @Ganador, ID_COMPETENCIA = @IdCompetencia " +
                        "WHERE ID_PARTIDO = @IdPartido; ";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("@IdPartido", partido.id);
                        sqlCommand.Parameters.AddWithValue("@Equipo1", partido.equipo1);
                        sqlCommand.Parameters.AddWithValue("@Equipo2", partido.equipo2);
                        sqlCommand.Parameters.AddWithValue("@Ganador", partido.ganador);
                        sqlCommand.Parameters.AddWithValue("@IdCompetencia", partido.idCompetencia);

                        conexion.Open();
                        sqlCommand.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PartidosEntity? ObtenerPartidoPorId(int  id)
        {
            PartidosEntity? partido = null;

            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    string sql = "SELECT FROM Partidos WHERE ID_PARTIDO = @IdPartido";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("IdPartido", id);
                        conexion.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                partido = PartidoMapper.Map(reader);
                            }
                        }
                    }
                }
            }

            catch (Exception)
            {
                throw;
            }

            return partido;
        }
    }
}
