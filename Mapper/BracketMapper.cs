using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public class BracketMapper
    {
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
    }
}
