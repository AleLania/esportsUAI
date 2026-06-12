using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class JugadoresEntity
    {
        public int IdJugador {  get; set; }
        public string NombreApellido { get; set; }
        public string Nick { get; set; }
        public int IdEquipo { get; set; }

        //arme este para poder mostrar el nombre del equipo en el dgv
        public string NombreEquipo { get; set;  }

    }
}
