using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CompetenciasEntity
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public CompetenciasEntity(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

    }
}
