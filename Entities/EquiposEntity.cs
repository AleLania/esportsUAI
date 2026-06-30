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
        public int PETorneo { get; set; }
        public int puntos { get; set; }

        public EquiposEntity(string nombre, int id) 
        { 
            this.nombre = nombre;
            this.id = id;
        }

        public EquiposEntity(int id, string nombre, DisciplinasEntity disciplina,int PGTorneo, int PPTorneo, int PETorneo, int puntos)
        {
            this.id = id;
            this.nombre = nombre;
            this.disciplina = disciplina;
            this.PGTorneo = PGTorneo;
            this.PPTorneo = PPTorneo;
            this.PETorneo = PETorneo;
            this.puntos = puntos;
        }

    }
}
