using Data;
using Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Business
{
    public class BracketBusiness
    {
        public void AvanzarGanador(PartidosEntity partido, BracketsEntity bracket)
        {
            try
            {
                BracketDAO bracketDAO = new BracketDAO();

                if(bracket.idSiguienteBracket == null)
                {
                    return;
                }

                BracketsEntity? siguienteBracket = bracketDAO.ObtenerBracketPorId(bracket.idSiguienteBracket.Value);

                if(siguienteBracket == null)
                {
                    throw new Exception("No se encontró el siguiente Bracket");
                }
                //si el primer equipo está vacío, asigno el ganador ahí
                if (siguienteBracket.equipo1 == null)
                {
                    bracketDAO.ActualizarEquipo1(siguienteBracket.id, partido.ganador.id);

                    //actualizo el objeto en memoria
                    siguienteBracket.equipo1 = partido.ganador;
                }
                else
                {
                    //si no, asigno el ganador al segundo equipo
                    bracketDAO.ActualizarEquipo2(siguienteBracket.id, partido.ganador.id);

                    //actualizo el objeto en memoria
                    siguienteBracket.equipo2 = partido.ganador;
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

                //verifico que el equipo no este en otro bracket de cuartos
                ValidarEquiposCuartos(partido);

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
                throw;
            }
        }

        public void ActualizarBracket(PartidosEntity partido)
        {
            try
            {
                BracketDAO bracketDAO = new BracketDAO();


                using (var trx = new TransactionScope())
                {
                    //obtengo o asigno el bracket al partido
                    BracketsEntity bracket = ObtenerOAsignarBracket(partido);

                    //registro el partido en el bracket
                    bracketDAO.AsignarPartido(bracket.id, partido.id);

                    if (bracket.idSiguienteBracket != null)
                    {
                        AvanzarGanador(partido, bracket);
                    }
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void ValidarEquiposCuartos(PartidosEntity partido)
        {
            try
            {
                BracketDAO bracketDAO = new BracketDAO();

                //cargo los brackets
                List<BracketsEntity> brackets = bracketDAO.ObtenerBrackets();

                //recorro lista
                foreach(BracketsEntity bracket in brackets)
                {
                    //si es otra disciplina, sigo
                    if(bracket.disciplina.id != partido.disciplina.id)
                    {
                        continue;
                    }

                    //solo valido cuartos porque las otras instancias se arman solas

                    if(!bracket.instancia.StartsWith("cuartos"))
                    {
                        continue;
                    }

                    //verifico si los equipos ya estan en algun bracket de cuartos
                    if ((bracket.equipo1?.id == partido.equipo1.id) ||
                        (bracket.equipo2?.id == partido.equipo1.id) ||
                        (bracket.equipo1?.id == partido.equipo2.id) ||
                        (bracket.equipo2?.id == partido.equipo2.id))
                    {
                        throw new Exception("Uno de los equipos ya se encuentra jugando los cuartos de final.");
                    }

                }

            }

            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
