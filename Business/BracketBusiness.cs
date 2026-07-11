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
                BracketsEntity? bracket = bracketDAO.ObtenerBracketDisponible(partido.disciplina.id);
                if (bracket == null)
                {
                    throw new Exception("No hay brackets disponibles para la disciplina");
                }

                bracketDAO.AsignarEquipos(bracket.id, partido.equipo1.id, partido.equipo2.id);

                bracket.equipo1 = partido.equipo1;
                bracket.equipo2 = partido.equipo2;

                return bracket;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener o asignar brackets", ex);
            }
        }
    }
}
