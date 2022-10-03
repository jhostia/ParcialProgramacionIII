using System;
using Entidades;
using System.Linq;

namespace Presentacion
{
    internal class PPostgrado: PEstudiante
    {
        public void Lista()
        {
            Console.Clear();
            Console.WriteLine("ESTUDIANTES DE POSTGRADO: ");

            foreach (var es in servicio.Listar().Where(estudiante => estudiante.GetType() == typeof(Postgrado))
                         .Cast<Postgrado>())
            {
                Console.WriteLine($"IDENTIFICACION: {es.Identificacion}");
                Console.WriteLine($"NOMBRE: {es.Nombre} {es.Apellido}");
                Console.WriteLine($"PROGRAMA: {es.Programa}");
                Console.WriteLine($"SEMESTRE: {es.Semestre}");
                Console.WriteLine($"PROMEDIO DE NOTAS: {es.PromSemestre}");

                Console.WriteLine();
            }
            Console.Write("Presione cualquier letra para volver al menu..."); Console.ReadKey();
        }
    }
}
