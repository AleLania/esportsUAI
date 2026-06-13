using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Entities;
using Microsoft.Data.SqlClient;

namespace Data
{
    public class JugadorDAO
    {
        public List<JugadoresEntity> obtenerJugadores()
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

        public void cargarJugador(JugadoresEntity jugadores)
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

        //posible transaction para no borrar un jugador que tiene un equipo asignado? uso transaction? habra que armar un DesasignarEquipo?
        //lo hice al pedo
        public void borrarJugador(int idJugador)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);

                using (conexion)
                {
                    string sql = "DELETE FROM Jugadores WHERE ID_JUGADOR = @IdJugador";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("@IdJugador", idJugador);

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

        //tiene que ser un alta por baja porque no voy a borrarjugadores
        public void actualizarJugador(int idJugador, string nombreApellido, string nick, int idEquipo)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);

                using (conexion)
                {
                    string sql = "UPDATE Jugadores " +
                        "SET NOMBRE_APELLIDO = @NombreApellido, NICK = @Nick, ID_EQUIPO = @IdEquipo " +
                        "WHERE ID_JUGADOR = @IdJugador; ";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("@IdJugador", idJugador);
                        sqlCommand.Parameters.AddWithValue("@NombreApellido", nombreApellido);
                        sqlCommand.Parameters.AddWithValue("@Nick", nick);
                        sqlCommand.Parameters.AddWithValue("@IdEquipo", idEquipo);

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

        public JugadoresEntity? obtenerJugadorPorId(int idJugador)
        {
            JugadoresEntity jugador = null;

            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);

                using (conexion)
                {
                    string sql = "SELECT * FROM Jugadores WHERE ID_JUGADOR = @idJugador";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("@idJugador", idJugador);

                        conexion.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader()) 
                        {
                            if (reader.Read())
                            {
                                jugador = new JugadoresEntity();

                                jugador.IdJugador = Convert.ToInt32(reader["ID_JUGADOR"]);
                                jugador.NombreApellido = reader["NOMBRE_APELLIDO"].ToString();
                                jugador.Nick = reader["NICK"].ToString();
                                jugador.IdEquipo = Convert.ToInt32(reader["ID_EQUIPO"]);
                            }
                        }
                    }
                }
            }

            catch (Exception)
            {
                throw;
            }

            return jugador;
        }
    }
}
