using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Entities;
using Microsoft.Data.SqlClient;
using Mapper;


namespace Data
{
    public class JugadorDAO
    {
        public List<JugadoresEntity> ObtenerJugadores()
        {
            List<JugadoresEntity> jugadores = new List<JugadoresEntity>();

            try
            {

                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
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
                                //mapper
                                jugadores.Add(JugadorMapper.Map(reader));
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

        public void CargarJugador(JugadoresEntity jugador)
        {
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    string sql = "INSERT INTO Jugadores (NOMBRE_APELLIDO, NICK, ID_EQUIPO) VALUES (@NombreApellido, @Nick, @IdEquipo)";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("NombreApellido", jugador.NombreApellido);
                        sqlCommand.Parameters.AddWithValue("Nick", jugador.Nick);
                        sqlCommand.Parameters.AddWithValue("IdEquipo", jugador.IdEquipo);

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
        public void BorrarJugador(int idJugador)
        {
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
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
        public void ActualizarJugador(JugadoresEntity jugador)
        {
            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    string sql = "UPDATE Jugadores " +
                        "SET NOMBRE_APELLIDO = @NombreApellido, NICK = @Nick, ID_EQUIPO = @IdEquipo " +
                        "WHERE ID_JUGADOR = @IdJugador; ";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("@IdJugador", jugador.IdJugador);
                        sqlCommand.Parameters.AddWithValue("@NombreApellido", jugador.NombreApellido);
                        sqlCommand.Parameters.AddWithValue("@Nick", jugador.Nick);
                        sqlCommand.Parameters.AddWithValue("@IdEquipo", jugador.IdEquipo);

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

        public JugadoresEntity? ObtenerJugadorPorId(int idJugador)
        {
            JugadoresEntity? jugador = null;

            try
            {
                using SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                {
                    string sql = "SELECT " +
                        "Jugadores.ID_JUGADOR, " +
                        "Jugadores.NOMBRE_APELLIDO, " +
                        "Jugadores.NICK, " +
                        "Jugadores.ID_EQUIPO, " +
                        "Equipos.NOMBRE AS NOMBRE_EQUIPO " +
                        "FROM Jugadores " +
                        "INNER JOIN Equipos " +
                        "ON Jugadores.ID_EQUIPO = Equipos.ID_EQUIPO " +
                        "WHERE Jugadores.ID_JUGADOR = @idJugador";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, conexion))
                    {
                        sqlCommand.Parameters.AddWithValue("@idJugador", idJugador);

                        conexion.Open();

                        using (SqlDataReader reader = sqlCommand.ExecuteReader()) 
                        {
                            if (reader.Read())
                            {
                                //mapper
                                jugador = JugadorMapper.Map(reader);
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

        public static int getCantidadJugadores(int idEquipo)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString.connectionString);
                using (conexion)
                {
                    conexion.Open();

                    string sql = "SELECT COUNT(*) FROM Jugadores WHERE ID_EQUIPO = @idEquipo";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idEquipo", idEquipo);
                        object resultado = cmd.ExecuteScalar();

                        int cantidadJugadores = Convert.ToInt32(resultado);

                        return cantidadJugadores;
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
