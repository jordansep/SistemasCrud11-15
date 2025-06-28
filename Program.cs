using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using SistemasCrud10_15.Ejercicios.Ejercicio11;
using SistemasCrud10_15.Modulos;
using SistemasCrud10_15.Modulos.archiveManHerency;

namespace SistemasCrud10_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Registro de Usuarios Basico");
            Console.WriteLine("2) Registro de Tareas");
            Console.WriteLine("3) Registro de inventario de productos");
            Console.WriteLine("4) Registro de Asistencia");
            Console.WriteLine("5) Registro de Notas con Promedio");
            int opciones = Validaciones.ValidarEntero(1,5,"Elija una opcion");
            switch (opciones)
            {
                case 1: ejercicioOnce.Ejecutar();break;
                case 2: ejercicioDoce.Ejecutar(); break;
                case 3: ejercicioTrece.Ejecutar(); break;
                case 4: ejercicioCatorce.Ejecutar(); break;
                case 5: ejercicioQuince.Ejecutar(); break;
            }
        }
    }
}
