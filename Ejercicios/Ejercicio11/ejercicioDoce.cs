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
        public void Ejecutar()
        {
            Ruta.setPathFolder("Tareas");
            Ruta.setPathFile("ListaTareas", "txt");
            registroUsuarios b = new registroUsuarios();
            b.ShowLines();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1) Agregar Tarea");
            Console.WriteLine("2) Actualizar estado de una tarea");
            Console.WriteLine("3) Eliminar tarea por ID");
            int opciones = Validaciones.ValidarEntero("Ingrese una opcion");
            switch (opciones)
            {
                case 1: b.registrarUsuario(); break;
                case 2: b.ModLine(Validaciones.ValidarEntero("Que usuario desea modificar?")); break;
                case 3: b.DeleteID(Validaciones.ValidarEntero("Que usuario desea eliminar?")); break;
            }
        }
    }
}
