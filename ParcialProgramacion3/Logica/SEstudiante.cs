using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class SEstudiante
    {
        private List<Estudiante> estudiantes;
        private Archivo archivo;

        private List<string> materiasPregrado = new List<string>
        {
            "SISTEMAS", "DERECHO", "ENFERMERIA", "LICENCIATURA", "MUSICA"
        };

        private List<string> materiasPostgrado = new List<string>()
        {
            "DESARROLLO SOFTWARE", "DERECHO", "Administrativo", "AUDITORIA EN SALUD"
        };

        public SEstudiante()
        {
            estudiantes = new List<Estudiante>();
            archivo = new Archivo("Informe estudiante.dat");
            CargarDatos();
        }

        public List<Estudiante> Listar()
        {
            return estudiantes;
        }

        private void CargarDatos()
        {
            estudiantes = archivo.CargarEstudiante();
        }

        public string Prom(string materia)
        {
            double promedio = 0;
            var cantEstudiantes = 0;

            foreach (var estudiante in estudiantes)
            {
                if (estudiante.Programa.Equals(materia) && materiasPregrado.Contains(materia))
                {
                    var es = (Pregrado)estudiante;
                    var promEstudiantes = (es.PromedioCorte1 + es.PromedioCorte2 + es.PromedioCorte3) / 3;
                    promedio += promEstudiantes;
                    cantEstudiantes += 1;
                }
                else if (estudiante.Programa.Equals(materia) && materiasPostgrado.Contains(materia))
                {
                    var es = (Postgrado)estudiante;
                    promedio += es.PromSemestre;
                    cantEstudiantes += 1;
                }
            }

            var promedioFinal = promedio / cantEstudiantes;
            return $"El promedio de la materia {materia} es {promedioFinal}";
        }

        public string Destacado(string materia)
        {
            double promMaximo = 0;
            string destacado = "";
            foreach (var estudiante in estudiantes)
            {
                double promEstudiante;
                if (estudiante.Programa.Equals(materia) && materiasPregrado.Contains(materia))
                {
                    var es = (Pregrado)estudiante;
                    promEstudiante = (es.PromedioCorte1 + es.PromedioCorte2 + es.PromedioCorte3) / 3;

                    if (!(promEstudiante > promMaximo)) continue;
                    promMaximo = promEstudiante;
                    destacado = es.Nombre;
                }
                else if (estudiante.Programa.Equals(materia) && materiasPostgrado.Contains(materia))
                {
                    var es = (Postgrado)estudiante;
                    promEstudiante = es.PromSemestre;

                    if (!(promEstudiante > promMaximo)) continue;
                    promMaximo = promEstudiante;
                    destacado = es.Nombre;
                }
            }
            return $"El estudiante destacado es {destacado}";
        }
    }
}
