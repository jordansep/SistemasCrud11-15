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
            Formato.Separador();
            Formato.EscribirLinea("1) Registrar alumno nuevo");
            Formato.EscribirLinea("2) Registrar asistencia de alumnos");
            Formato.EscribirLinea("3) Borrar alumno por ID");
            Formato.Separador();
            int opciones = Validaciones.ValidarEntero(1, 3,"Ingrese una opcion");
            Formato.Separador();
            int max = archiveManipulation.getLines(Ruta.pathDB).Length;
            switch (opciones)
            {
                case 1:
                    Ruta.SetPathFile("Alumnos", "txt");
                    b.AddRegister();
                    break;
                case 2: b.registrarAsistencia(); break;
                case 3: b.DeleteID(Validaciones.ValidarEntero(1,max,"Que alumno desea eliminar?"),false); break;
            }

        }
    }
}
