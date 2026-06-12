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

                    //arme un join para poder mostrar el equipo en el dgv y no solo el id_equipo
                    string sql = "SELECT " +
                        "Jugadores.ID_JUGADOR, " +
                        "Jugadores.NOMBRE_APELLIDO, " +
                        "Jugadores.NICK, " +
                        "Jugadores.ID_EQUIPO, " +
                        "Equipos.NOMBRE AS NOMBRE_EQUIPO " +
                        "FROM Jugadores " +
                        "INNER JOIN Equipos " +
                        "ON Jugadores.ID_EQUIPO = Equipos.ID_EQUIPO";

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
                                // mapeo nombre equipo
                                jugador.NombreEquipo = reader["NOMBRE_EQUIPO"].ToString();

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

        public void CargarJugador(JugadoresEntity jugadores)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);

                using (conexion)
                {
                    string sql = "INSERT INTO Jugadores (NOMBRE_APELLIDO, NICK, ID_EQUIPO) VALUES (@NombreApellido, @Nick, @IdEquipo)";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("NombreApellido", jugadores.NombreApellido);
                        sqlCommand.Parameters.AddWithValue("Nick", jugadores.Nick);
                        sqlCommand.Parameters.AddWithValue("IdEquipo", jugadores.IdEquipo);

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
    }
}
