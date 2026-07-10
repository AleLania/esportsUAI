using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class PartidoBusiness
    {
        public List<PartidosEntity> ObtenerPartidos()
        {
            PartidoDAO partidoDAO = new PartidoDAO();

            return partidoDAO.ObtenerPartidos();
        }

        public PartidosEntity? ObtenerPartidoPorId(int idPartido)
        {
            PartidoDAO partidoDAO = new PartidoDAO();

            return partidoDAO.ObtenerPartidoPorId(idPartido);
        }

        public void CargarPartido(PartidosEntity partido)
        {
            //metodo de validacion

            PartidoDAO partidoDAO = new PartidoDAO();

            partidoDAO.CargarPartido(partido);
        }

        //por ahora no se si se va a implementar
        public void ActualizarPartido(PartidosEntity partido)
        {
            //validacion

            PartidoDAO partidoDAO = new PartidoDAO();

            partidoDAO.ActualizarPartido(partido);
        }

        public void ValidarPartido(PartidosEntity partido)
        {
            //validacion minimo de equipos cargados
            //validar cantidad de jugadores por disciplina

            if (partido.equipo1 == 0)
                throw new Exception("Debe seleccionar el equipo 1.");

            if (partido.equipo2 == 0)
                throw new Exception("Debe seleccionar el equipo 2.");

            if (partido.equipo1 == partido.equipo2)
                throw new Exception("Un equipo no puede jugar contra sí mismo.");

            if (partido.ganador != partido.equipo1 &&
                partido.ganador != partido.equipo2)
                throw new Exception("El ganador debe ser uno de los equipos que disputaron el partido.");
        }
    }
}
