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
        public CompetenciasEntity competencia { get; set; }
        public DisciplinasEntity disciplina { get; set; }


        public PartidosEntity(EquiposEntity equipo1, EquiposEntity equipo2, EquiposEntity ganador, CompetenciasEntity competencia, DisciplinasEntity disciplina)
        {
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
            this.ganador = ganador;
            this.competencia = competencia;
            this.disciplina = disciplina;
        }

        public class PartidosLayer
        {
            public string Equipo1 { get; set; }
            public string Equipo2 { get; set; }
            public string ganador { get; set; }
            public string competencia { get; set; }

            public string disciplina { get; set; }
            public PartidosLayer(PartidosEntity entity)
            {
                this.Equipo1 = entity.equipo1.nombre;
                this.Equipo2 = entity.equipo2.nombre;
                this.ganador = entity.ganador.nombre;
                this.competencia = entity.competencia.descripcion;
                this.disciplina = entity.disciplina.descripcion;
            }
        }

    }
}
