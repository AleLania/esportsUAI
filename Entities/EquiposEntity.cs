namespace Entities
{
    public class EquiposEntity
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public int disciplina { get; set; }
        public int PGTorneo { get; set; }
        public int PPTorneo { get; set; }
        public int PETorneo { get; set; }
        public int puntos { get; set; }

        public EquiposEntity(string nombre, int disciplina) 
        { 
            this.nombre = nombre;
            this.disciplina = disciplina;
        }

    }
}
