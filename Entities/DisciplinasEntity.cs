using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class DisciplinasEntity
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int cantidadJugadores { get; set; }

        public DisciplinasEntity(int id, string descripcion, int cantidadJugadores)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.cantidadJugadores = cantidadJugadores;
        }
    }
}
