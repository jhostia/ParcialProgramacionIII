namespace Entidades
{
    public class Postgrado: Estudiante
    {
        public double PromSemestre { get; set; }

        public Postgrado()
        {

        }
        public Postgrado(int identificacion, string nombre, string apellido,
            string programa, int semestre, double promSemestre
        ) : base(identificacion, nombre, apellido, programa, semestre)
        {
            PromSemestre = promSemestre;
        }

        public override string ToString()
        {
            return $"POST;{Identificacion};" +
                   $"{Nombre};{Apellido};{Programa};{Semestre};{PromSemestre}";
        }

        public override void CargarDatos(string[] data)
        {
            base.CargarDatos(data);
            PromSemestre = double.Parse(data[6]);
        }
    }
}
