namespace Entidades
{
    public class Pregrado: Estudiante
    {
        public double PromedioCorte1 { get; set; }
        public double PromedioCorte2 { get; set; }
        public double PromedioCorte3 { get; set; }


        public Pregrado()
        {

        }

        public Pregrado(int noDocumento, string nombre, string apellido,
            string programa, int semestre, double promedioCorte1, double promedioCorte2,
            double promedioCorte3
        ) : base(noDocumento, nombre, apellido, programa, semestre)
        {
            PromedioCorte1 = promedioCorte1;
            PromedioCorte2 = promedioCorte2;
            PromedioCorte3 = promedioCorte3;
        }

        public override string ToString()
        {
            return $"PRE;{Identificacion};" +
                   $"{Nombre};{Apellido};{Programa};{Semestre};{PromedioCorte1};" +
                   $"{PromedioCorte2};{PromedioCorte3};";
        }

        public override void CargarDatos(string[] data)
        {
            base.CargarDatos(data);
            PromedioCorte1 = double.Parse(data[6]);
            PromedioCorte2 = double.Parse(data[7]);
            PromedioCorte3 = double.Parse(data[8]);
        }
    }
}
