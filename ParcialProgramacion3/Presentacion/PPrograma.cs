using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    internal class PPrograma
    {
        private PPostgrado pPostgrado = new PPostgrado();
        private PresentacionPregrado pPregrado = new PresentacionPregrado();
        private PEstudiante pEstudiante = new PEstudiante();

        public void Menu()
        {
            byte op;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(".....MENU DE OPCIONES.....");
                Console.WriteLine("1. LISTA DE PREGRADO");
                Console.WriteLine("2. LISTA DE POSTGRADO");
                Console.WriteLine("3. PROMEDIO POR PROGRAMA");
                Console.WriteLine("4. ALUMNOS DESTACADOS");
                Console.WriteLine("5. SALIR");

                Console.Write("\nSeleccione una opcion: ");
                op = byte.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        pPregrado.Lista();
                        break;
                    case 2:
                        pPostgrado.Lista();
                        break;
                    case 3:
                        pEstudiante.PPromedio();
                        break;
                    case 4:
                        pEstudiante.PDestacado();
                        break;
                    case 5:
                        Console.WriteLine("\n.....EXITOS.....");
                        break;
                }
            } while (op != 5);
        }
    }
}
