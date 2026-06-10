using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.Data.SqlClient;

namespace Data
{
    public class JugadorDAO
    {
        public List<JugadoresEntity> ObtenerJugadores()
        {
            List<JugadoresEntity> jugadores = new List<JugadoresEntity>();

            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);

                using (conexion)
                {
                    conexion.Open();

                    string sql = "SELECT * FROM Jugadores";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                JugadoresEntity jugador = new JugadoresEntity();

                                jugador.IdJugador = Convert.ToInt32(reader["ID_JUGADOR"]);
                                jugador.NombreApellido = reader["NOMBRE_APELLIDO"].ToString();
                                jugador.Nick = reader["NICK"].ToString();
                                jugador.IdEquipo = Convert.ToInt32(reader["ID_EQUIPO"]);

                                jugadores.Add(jugador);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return jugadores;
        }
    }
}
