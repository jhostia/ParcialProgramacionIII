using Entidades;
using System;
using System.Linq;

namespace Presentacion
{
    internal class PresentacionPregrado: PEstudiante
    {
        public void Lista()
        {
            Console.Clear();
            Console.WriteLine("ESTUDIANTES DE PREGRADO: ");

            foreach (var es in servicio.Listar().Where(estudiante => estudiante.GetType() == typeof(Pregrado)).Cast<Pregrado>())
            {
                Console.WriteLine($"IDENTIFICACION: {es.Identificacion}");
                Console.WriteLine($"NOMBRE: {es.Nombre} {es.Apellido}");
                Console.WriteLine($"PROGRAMA: {es.Programa}");
                Console.WriteLine($"SEMESTRE: {es.Semestre}");
                Console.WriteLine($"1ER CORTE: {es.PromedioCorte1}");
                Console.WriteLine($"2DO CORTE: {es.PromedioCorte2}");
                Console.WriteLine($"3ER CORTE: {es.PromedioCorte3}");

                Console.WriteLine();
            }

            Console.Write("Presione cualquier letra para volver al menu..."); Console.ReadKey();
        }
    }
}
