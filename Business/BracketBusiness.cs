using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Business
{
    public class BracketBusiness
    {
        public void AvanzarGanador(int idPartido)
        {
            try
            {
                using (var trx = new TransactionScope())
                {

                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al avanzar el ganador: " + ex.Message);
            }
        }

        //como al cargar un equipo no cargamos automaticamente en la tabla de brackets, armo esto y el bracket se llena a medida que se cargan partidos de Copa
        public BracketsEntity ObtenerOAsignarBracket(PartidosEntity partido)
        {
            try
            {
                BracketDAO bracketDAO = new BracketDAO();

                //verifico si el partido ya tiene un bracket asignado
                BracketsEntity? bracket = bracketDAO.ObtenerBracketPorEquipos(
                    partido.equipo1.id,
                    partido.equipo2.id,
                    partido.disciplina.id);

                //si existe, lo devuelvo
                if (bracket != null)
                {
                    return bracket;
                }

                //si no existe, busco un bracket disponible
                bracket = bracketDAO.ObtenerBracketDisponible(partido.disciplina.id);

                if (bracket == null)
                {
                    throw new Exception("No hay brackets disponibles para la disciplina.");
                }

                //asigno los equipos al bracket
                bracketDAO.AsignarEquipos(
                    bracket.id,
                    partido.equipo1.id,
                    partido.equipo2.id);

                //actualizo el objeto
                bracket.equipo1 = partido.equipo1;
                bracket.equipo2 = partido.equipo2;

                return bracket;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener o asignar un bracket.", ex);
            }
        }

        public void ActualizarBracket(PartidosEntity partido)
        {
            BracketDAO bracketDAO = new BracketDAO();

            BracketsEntity bracket = ObtenerOAsignarBracket(partido);

            //bracketDAO.AsignarPartido();

        }
    }
}
