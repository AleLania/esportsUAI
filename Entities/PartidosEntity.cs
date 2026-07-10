using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class PartidosEntity
    {
        public int id { get; set; }
        public EquiposEntity equipo1 { get; set; }
        public EquiposEntity equipo2 { get; set; }
        public EquiposEntity ganador { get; set;  }
        public CompetenciasEntity idCompetencia { get; set; }
        public DisciplinasEntity idDisciplina { get; set; }

    }
}
