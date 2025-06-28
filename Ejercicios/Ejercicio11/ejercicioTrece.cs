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
            Ruta.SetPathFolder("Inventario Productos");
            Ruta.SetPathFile("Inventarioproductos", "csv");
            RegistroNotas a = new RegistroNotas();
            a.ShowLines(Ruta.pathFile);
            Formato.Separador();
            Formato.EscribirLinea("1) Registrar producto nuevo");
            Formato.EscribirLinea("2) Modificar producto");
            Formato.EscribirLinea("3) Eliminar producto por ID");
            Formato.Separador();
            int option = Validaciones.ValidarEntero("Ingrese una opcion");
            Formato.Separador();
            int max = archiveManipulation.getLines(Ruta.pathFile).Length;
            switch (option)
            {
                case 1: a.RegistrarNotas(); break;
                case 2: a.ModLine(Validaciones.ValidarEntero(1, max, "Ingrese que producto modificara")); break;
                case 3: a.DeleteID(Validaciones.ValidarEntero(1, max, "Que producto desea eliminar?")); break;
            }
        }
    }
}
