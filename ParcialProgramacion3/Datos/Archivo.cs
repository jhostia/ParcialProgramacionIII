using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivo
    {
        private string ruta;
        private Estudiante estudiante;
        public Archivo(string ruta)
        {
            this.ruta = ruta;
        }

        public List<Estudiante> CargarEstudiante()
        {

            var rd = new StreamReader(ruta);
            var estudiantes = new List<Estudiante>();

            var dato = rd.ReadLine();
            while (dato != null)
            {
                var id = dato.Split(';')[0];
                if (id == "PRE")
                {
                    estudiante = new Pregrado();
                    estudiante.CargarDatos(dato.Split(';'));
                }
                else
                {
                    estudiante = new Postgrado();
                    estudiante.CargarDatos(dato.Split(';'));
                }
                estudiantes.Add(estudiante);
                dato = rd.ReadLine();
            }

            rd.Close();
            return estudiantes;
        }
    }
}
