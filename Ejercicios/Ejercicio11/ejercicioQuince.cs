using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasCrud10_15.Modulos.archiveManHerency;
using SistemasCrud10_15.Modulos;

namespace SistemasCrud10_15.Ejercicios.Ejercicio11
{
    internal class ejercicioQuince
    {
        public static void Ejecutar()
        {
            Ruta.SetPathFolder("Registro Notas");
            Ruta.SetPathFile("notas", "txt");
            RegistroNotas a = new RegistroNotas();
            a.ShowLines(Ruta.pathFile);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1) Agregar Alumno");
            Console.WriteLine("2) Modificar registro");
            Console.WriteLine("3) Promedios alumnos");
            Console.WriteLine("4) Eliminar alumno");

            int option = Validaciones.ValidarEntero("Ingrese una opcion");
            Console.WriteLine("--------------------------------------------------");
            int max = archiveManipulation.getLines(Ruta.pathFile).Length;
            switch (option)
            {
                case 1: a.RegistrarNotas(); break;
                case 2: a.ModLine(1,10,Validaciones.ValidarEntero(1, max, "Ingrese que alumno modificara")); break;
                case 3: a.CalcularPromedio(); break;
                case 4: a.DeleteID(Validaciones.ValidarEntero(1, max, "Que alumno desea eliminar?")); break;
            }
        }
    }
}
