using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class BracketsEntity
    {
        public int id { get; set; }

        public string instancia { get; set; }
        public DisciplinasEntity disciplina { get; set; }
        public EquiposEntity? equipo1 { get; set; }
        public EquiposEntity? equipo2 { get; set; }

        public int? idSiguienteBracket {  get; set; }
        public PartidosEntity partido {  get; set; }


        public BracketsEntity(int id, string instancia,DisciplinasEntity disciplina, EquiposEntity equipo1, EquiposEntity equipo2)
        {
            this.id = id;
            this.instancia = instancia;
            this.disciplina = disciplina;
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
        }


        public class BracketsLayer
        {
            public string instancia { get; set; }
            public string disciplina { get; set; }

            public string nombreEquipo1 { get; set; }
            public string nombreEquipo2 { get; set; }

            public BracketsLayer(BracketsEntity entity)
            {
                this.instancia = entity.instancia;
                this.disciplina = entity.disciplina.descripcion;
                this.nombreEquipo1 = entity.equipo1?.nombre ?? "Por definir";
                this.nombreEquipo2 = entity.equipo2?.nombre ?? "Por definir";
            }


        }

        //constructor vacio, perdon ale
        public BracketsEntity()
        {

        }
    }
}
