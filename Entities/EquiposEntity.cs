namespace Entities
{
    public class EquiposEntity
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public DisciplinasEntity disciplina { get; set; }
        public int cantJugadores { get; set; }
        public int PGTorneo { get; set; }
        public int PPTorneo { get; set; }
        public int puntos { get; set; }

        public EquiposEntity(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public EquiposEntity(string nombre, DisciplinasEntity disciplina)
        {
            this.nombre = nombre;
            this.disciplina = disciplina;
        }

        public EquiposEntity(int id, string nombre, DisciplinasEntity disciplina, int PGTorneo, int PPTorneo, int puntos)
        {
            this.id = id;
            this.nombre = nombre;
            this.disciplina = disciplina;
            this.PGTorneo = PGTorneo;
            this.PPTorneo = PPTorneo;
            this.puntos = puntos;
        }


        public class EquiposTorneoEntity
        {
            public string nombre { get; set; }
            public int puntos { get; set; }
            public int PG { get; set; }
            public int PP { get; set; }
            public int PE { get; set; }

            public EquiposTorneoEntity(EquiposEntity entity)
            {
                this.nombre = entity.nombre;
                this.puntos = entity.puntos;
                this.PG = entity.PGTorneo;
                this.PP = entity.PPTorneo;
            }
        }

        //arme el constrcutor vacio perdon ale
        public EquiposEntity()
        {
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
