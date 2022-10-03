
namespace Entidades
{
    public abstract class Estudiante
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Programa { get; set; }
        public int Semestre { get; set; }


        public Estudiante()
        {

        }

        public Estudiante(int identificacion, string nombre, string apellido, string programa, int semestre)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Programa = programa;
            Semestre = semestre;

        }

        public virtual void CargarDatos(string[] data)
        {
            Identificacion = int.Parse(data[1]);
            Nombre = data[2];
            Apellido = data[3];
            Programa = data[4];
            Semestre = int.Parse(data[5]);
        }
    }
}
