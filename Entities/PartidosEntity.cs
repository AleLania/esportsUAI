using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    internal class PartidosEntity
    {
        public int id { get; set; }
        public int equipo1 { get; set; }
        public int equipo2 { get; set; }
        public int ganador { get; set;  }
        public int idCompetencia { get; set; }

    }
}
