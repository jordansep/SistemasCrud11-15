using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasCrud10_15.Modulos;
using SistemasCrud10_15.Modulos.archiveManHerency;

namespace SistemasCrud10_15.Ejercicios.Ejercicio11
{
    public class ejercicioOnce
    {
        public static void Ejecutar()
        {
            Ruta.SetPathFolder("usuarios");
            Ruta.SetPathFile("usuarios", "txt");
            registroUsuarios b = new registroUsuarios();
            b.ShowLines(Ruta.pathFile);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1) Registrar usuario");
            Console.WriteLine("2) Actualizar/Modificar usuario");
            Console.WriteLine("3) Eliminar usuario por ID");
            int opciones = Validaciones.ValidarEntero(1,3,"Ingrese una opcion");
            Console.WriteLine("----------------------------------------------------");
            int max = archiveManipulation.getLines(Ruta.pathFile).Length;
            switch (opciones)
            {
                case 1: b.registrarUsuario(); break;
                case 2: b.ModLine(Validaciones.ValidarEntero(1, max, "Que usuario desea modificar?")); break;
                case 3: b.DeleteID(Validaciones.ValidarEntero(1, max, "Que usuario desea eliminar?")); break;
            }
        }
    }
}
