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
            Formato.Separador();
            Formato.EscribirLinea("1) Agregar tarea nueva");
            Formato.EscribirLinea("2) Modificar estado de tarea");
            Formato.EscribirLinea("3) Eliminar tarea por ID");
            Formato.Separador();
            int opciones = Validaciones.ValidarEntero("Ingrese una opcion");
            Formato.Separador();
            int max = archiveManipulation.getLines(Ruta.pathFile).Length;
            switch (opciones)
            {
                case 1: b.agregarTarea(); break;
                case 2: b.ModificarEstado(Validaciones.ValidarEntero(1, max, "A que tarea desea cambiarle el estado de completitud?")); break;
                case 3: b.DeleteID(Validaciones.ValidarEntero(1,max,"Que tarea desea eliminar?")); break;
            }
        }
    }
}
