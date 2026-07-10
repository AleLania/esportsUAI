using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    internal class BracketsEntity
    {
        public int id { get; set; }
        public CompetenciasEntity competencia { get; set; }

        public EquiposEntity equipo1 { get; set; }
        public EquiposEntity equipo2 { get; set; }

    }
}
