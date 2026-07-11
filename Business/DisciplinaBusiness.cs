using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class DisciplinaBusiness
    {
        public static List<DisciplinasEntity> getDisciplinas()
        {
            try
            {
                return DisciplinasDAO.getDisciplinas();

            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener las disciplinas: " + e.Message);
            }
        }

        public static int getCantidadEquiposDisciplina(int idDisciplina)
        {
            try
            {
                DisciplinasEntity disciplina = DisciplinasDAO.getDisciplinaById(idDisciplina);
                return disciplina.cantidadEquipos;

            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener la cantidad de equipos de la disciplina: " + e.Message);
            }
        }

        public static DisciplinasEntity getDisciplinaById(int idDisciplina)
        {
            try
            {
                return DisciplinasDAO.getDisciplinaById(idDisciplina);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener la disciplina por ID: " + e.Message);
            }
        }

        public static int getCantidadJugadoresDisciplina(int idDisciplina)
        {
            try
            {
                return DisciplinasDAO.getCantidadJugadoresPorDisciplina(idDisciplina);
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener la cantidad de jugadores de la disciplina.");
            }
        }
    }
}
