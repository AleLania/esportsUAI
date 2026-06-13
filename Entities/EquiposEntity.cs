namespace Entities
{
    public class EquiposEntity
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int disciplina { get; set; }
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

        public EquiposEntity(int id, string nombre, int disciplina, int cantJugadores)
        {
            this.id = id;
            this.nombre = nombre;
            this.cantJugadores = cantJugadores;
            this.disciplina = disciplina;
        }

    }
}
