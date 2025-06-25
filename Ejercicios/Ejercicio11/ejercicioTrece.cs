using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasCrud10_15.Modulos;
using System.IO;
using SistemasCrud10_15.Modulos.archiveManHerency;
namespace SistemasCrud10_15.Ejercicios.Ejercicio11
{
    class ejercicioTrece
    {
        public static void Ejecutar()
        {
            Ruta.setPathFolder("Inventario Productos");
            Ruta.setPathFile("Inventarioproductos", "csv");
            InventarioProductos a = new InventarioProductos();
            a.ShowLines();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1) Agregar Producto");
            Console.WriteLine("2) Modificar producto");
            Console.WriteLine("3) Eliminar producto");
            int option = Validaciones.ValidarEntero("Ingrese una opcion");
            switch (option)
            {
                case 1: InventarioProductos.agregarProducto(); break;
                case 2: a.ModLine(Validaciones.ValidarEntero("Ingrese que producto modificara")); break;
                case 3: a.DeleteID(Validaciones.ValidarEntero("Que producto desea eliminar?")); break;
            }
        }
    }
}
