using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.Data.SqlClient;


namespace Mapper
{
    public class JugadorMapper
    {
        public static JugadoresEntity Map(SqlDataReader reader)
        {
            JugadoresEntity jugador = new JugadoresEntity();

            jugador.IdJugador = Convert.ToInt32(reader["ID_JUGADOR"]);
            jugador.NombreApellido = reader["NOMBRE_APELLIDO"].ToString();
            jugador.Nick = reader["NICK"].ToString();
            jugador.IdEquipo = Convert.ToInt32(reader["ID_EQUIPO"]);
            // mapeo nombre equipo
            jugador.NombreEquipo = reader["NOMBRE_EQUIPO"].ToString();

            return jugador;
        }
    }
}
