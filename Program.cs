using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasCrud10_15.Modulos;

namespace SistemasCrud10_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ruta.setPathFolder("Act11");
            Console.WriteLine(Ruta.origenPath);
            Console.WriteLine(Ruta.pathFolder);
            Ruta.setPathFile("registrosuno", "txt");
            Console.WriteLine(Ruta.pathFile);
        }
    }
}
