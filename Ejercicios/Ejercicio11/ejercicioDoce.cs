using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasCrud10_15.Modulos;
using SistemasCrud10_15.Modulos.archiveManHerency;

namespace SistemasCrud10_15.Ejercicios.Ejercicio11
{
    public class ejercicioDoce
    {
        public static void Ejecutar()
        {
            Ruta.SetPathFolder("Tareas");
            Ruta.SetPathFile("ListaTareas", "txt");
            listaTareas b = new listaTareas();
            b.ShowLines(Ruta.pathFile);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1) Agregar Tarea");
            Console.WriteLine("2) Actualizar estado de una tarea");
            Console.WriteLine("3) Eliminar tarea por ID");
            int opciones = Validaciones.ValidarEntero("Ingrese una opcion");
            Console.WriteLine("----------------------------------------------------");

            switch (opciones)
            {
                case 1: b.agregarTarea(); break;
                case 2: b.ModificarEstado(Validaciones.ValidarEntero("A que tarea desea cambiarle el estado de completitud?")); break;
                case 3: b.DeleteID(Validaciones.ValidarEntero("Que tarea desea eliminar?")); break;
            }
        }
    }
}
