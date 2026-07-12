using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class BracketsMapper
    {
        public static BracketsEntity map(SqlDataReader reader, EquiposEntity equipo1, EquiposEntity equipo2, DisciplinasEntity disciplina)
        {
            BracketsEntity bracket = new BracketsEntity(
                Convert.ToInt32(reader["ID_BRACKET"]),
                reader["INSTANCIA"].ToString(),
                disciplina,
                equipo1,
                equipo2
            );
            return bracket;
        }

        //junte mi Mapper, teniamos 2 clases de Mapper para bracket
        public static BracketsEntity Map(SqlDataReader reader)
        {

            BracketsEntity bracket = new BracketsEntity();

            //valido por si bracket devuelve un null
            if (reader["ID_SIGUIENTE_BRACKET"] != DBNull.Value)
                bracket.idSiguienteBracket = Convert.ToInt32(reader["ID_SIGUIENTE_BRACKET"]);

            bracket.id = Convert.ToInt32(reader["ID_BRACKET"]);
            bracket.instancia = reader["INSTANCIA"].ToString();

            bracket.disciplina = DisciplinasMapper.Map(reader);

            //uso el mapper que cree para esto
            bracket.equipo1 = EquiposMapper.MapBracket(reader, 1);
            bracket.equipo2 = EquiposMapper.MapBracket(reader, 2);

            return bracket;
        }

        //arme otro mapper especifico para el bracketDAO
        public static BracketsEntity MapBracket(SqlDataReader reader)
        {
            BracketsEntity bracket = new BracketsEntity();

            bracket.id = Convert.ToInt32(reader["ID_BRACKET"]);
            bracket.instancia = reader["INSTANCIA"].ToString();

            if (reader["ID_SIGUIENTE_BRACKET"] != DBNull.Value)
                bracket.idSiguienteBracket = Convert.ToInt32(reader["ID_SIGUIENTE_BRACKET"]);

            bracket.disciplina = DisciplinasMapper.Map(reader);

            bracket.equipo1 = null;
            bracket.equipo2 = null;
            bracket.partido = null;

            return bracket;
        }

        public static BracketsEntity MapBracket(SqlDataReader reader, DisciplinasEntity disciplina)
        {
            BracketsEntity bracket = new BracketsEntity();

            bracket.id = Convert.ToInt32(reader["ID_BRACKET"]);
            bracket.instancia = reader["INSTANCIA"].ToString();

            if (reader["ID_SIGUIENTE_BRACKET"] != DBNull.Value)
                bracket.idSiguienteBracket = Convert.ToInt32(reader["ID_SIGUIENTE_BRACKET"]);

            bracket.disciplina = disciplina;

            bracket.equipo1 = EquiposMapper.mapEquipo(reader, disciplina, "1");
            bracket.equipo2 = EquiposMapper.mapEquipo(reader, disciplina, "2");

            bracket.partido = null;

            return bracket;
        }
    }
}
