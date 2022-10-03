using Logica;
using System;

namespace Presentacion
{
    internal class PEstudiante
    {
        protected SEstudiante servicio = new SEstudiante();

        public void PPromedio()
        {
            Console.Clear();

            Console.Write("Ingrese la materia a calcular: ");
            var materia = Console.ReadLine().ToUpper();

            Console.WriteLine(servicio.Prom(materia));
            Console.Write("Presione enter para continuar..."); Console.ReadKey();
        }

        public void PDestacado()
        {
            Console.Clear();

            Console.Write("Ingrese la materia a la que desea conocer el estudiante destacado: ");
            var materia = Console.ReadLine().ToUpper();

            Console.WriteLine(servicio.Destacado(materia));
            Console.Write("Presione enter para continuar..."); Console.ReadKey();
        }
    }
}
