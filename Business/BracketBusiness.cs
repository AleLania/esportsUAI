using Data;
using Entities;
using Mapper;
using Microsoft.Data.SqlClient;
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

                BracketsEntity? siguienteBracket = bracketDAO.getBracketPorId(bracket.idSiguienteBracket.Value);

                if(siguienteBracket == null)
                {
                    throw new Exception("No se encontró el siguiente Bracket");
                }
                //si el primer equipo está vacío, asigno el ganador ahí
                if (siguienteBracket.equipo1 == null)
                {
                    bracketDAO.actualizarEquipo1(siguienteBracket.id, partido.ganador.id);

                    //actualizo el objeto en memoria
                    siguienteBracket.equipo1 = partido.ganador;
                }
                else
                {
                    //si no, asigno el ganador al segundo equipo
                    bracketDAO.actualizarEquipo2(siguienteBracket.id, partido.ganador.id);

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
                BracketsEntity? bracket = bracketDAO.getBracketPorEquipos(
                    partido.equipo1.id,
                    partido.equipo2.id,
                    partido.disciplina.id);

                //si existe, lo devuelvo
                if (bracket != null)
                {
                    return bracket;
                }

                //verifico que el equipo no este en otro bracket de cuartos
                validarEquiposCuartos(partido);

                //si no existe, busco un bracket disponible
                bracket = bracketDAO.getBracketDisponible(partido.disciplina.id);

                if (bracket == null)
                {
                    throw new Exception("No hay brackets disponibles para la disciplina.");
                }

                //asigno los equipos al bracket
                bracketDAO.asignarEquipos(
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

        public void actualizarBracket(PartidosEntity partido)
        {
            try
            {
                BracketDAO bracketDAO = new BracketDAO();


                using (var trx = new TransactionScope())
                {
                    //obtengo o asigno el bracket al partido
                    BracketsEntity bracket = ObtenerOAsignarBracket(partido);

                    //registro el partido en el bracket
                    bracketDAO.asignarPartido(bracket.id, partido.id);

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

        public void validarEquiposCuartos(PartidosEntity partido)
        {
            try
            {
                BracketDAO bracketDAO = new BracketDAO();

                //cargo los brackets
                List<BracketsEntity> brackets = bracketDAO.getBrackets();

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

        public void armarBracketsCopa(int idDisciplina)
        {
            try
            {
                BracketDAO bracketDAO = new BracketDAO();

                // traemos los equipos de la disciplina
                List<EquiposEntity> equipos = EquipoDAO.getEquiposByDisciplina(idDisciplina);

                // mezclamos aleatoriamente
                Random rng = new Random();
                equipos = equipos.OrderBy(e => rng.Next()).ToList();

                // traemos los brackets de cuartos disponibles ordenados
                List<BracketsEntity> brackets = bracketDAO.getBracketsDeCuartos(idDisciplina);

                if (brackets.Count < 4)
                    throw new Exception("No hay suficientes brackets de cuartos para la disciplina.");

                // asignamos de a pares: equipo 0-1 al bracket 0, equipo 2-3 al bracket 1, etc.
                for (int i = 0; i < 4; i++)
                {
                    bracketDAO.asignarEquipos(
                        brackets[i].id,
                        equipos[i * 2].id,
                        equipos[i * 2 + 1].id
                    );
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<BracketsEntity> getBracketsConEquipos(int idDisciplina)
        {
            BracketDAO bracketDAO = new BracketDAO();
            return bracketDAO.getBracketsConEquipos(idDisciplina);
        }

    }
}
