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
        public EquiposEntity equipo { get; set; }

        //arme este para poder mostrar el nombre del equipo en el dgv
        public string NombreEquipo { get; set;  }


        public JugadoresEntity(int id, string nombreApellido, string nick, EquiposEntity equipo)
        {
            IdJugador = id;
            NombreApellido = nombreApellido;
            Nick = nick;
            this.equipo = equipo;
        }

        public JugadoresEntity(int id, string nombreApellido, string nick, int idEquipo)
        {
            IdJugador = id;
            NombreApellido = nombreApellido;
            Nick = nick;
            this.equipo = new EquiposEntity(idEquipo, "", null, 0, 0, 0);
        }

        public JugadoresEntity(string nombreApellido, string nick, int idEquipo)
        {
            NombreApellido = nombreApellido;
            Nick = nick;
            this.equipo = new EquiposEntity(idEquipo, "", null, 0, 0, 0);
        }

    }

}
