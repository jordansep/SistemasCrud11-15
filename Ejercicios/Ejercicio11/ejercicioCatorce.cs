using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using SistemasCrud10_15.Modulos;
using SistemasCrud10_15.Modulos.archiveManHerency;

namespace SistemasCrud10_15.Ejercicios.Ejercicio11
{
    class ejercicioCatorce
    {
        public static void Ejecutar()
        {
            Ruta.SetPathFolder("Asistencia");
            Ruta.SetPathFile(DateTime.UtcNow.ToString("yyyy-MM-dd"), "txt");
            registroAsistencia b = new registroAsistencia();
            archiveManipulation cargarBD = new archiveManipulation(true);
            b.ShowLines(Ruta.pathDB);
            Console.WriteLine("1) Registrar Alumno");
            Console.WriteLine($"2) Tomar asistencia del dia {DateTime.UtcNow.ToString("yyyy-MM-dd")}");
            Console.WriteLine("3) Borrar alumno por ID");
            int opciones = Validaciones.ValidarEntero(1, 3,"Ingrese una opcion");
            int max = archiveManipulation.getLines(Ruta.pathDB).Length;
            switch (opciones)
            {
                case 1:
                    Ruta.SetPathFile("Alumnos", "txt");
                    b.registrarAlumno();
                    break;
                case 2: b.registrarAsistencia(); break;
                case 3: b.DeleteID(Validaciones.ValidarEntero(1,max,"Que alumno desea eliminar?"),false); break;
            }

        }
    }
}
