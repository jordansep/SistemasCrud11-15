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
            Ruta.setPathFile("registrosuno", "txt");
            archiveManipulation a = new archiveManipulation();
            a.readLines();
            string[] lineas = archiveManipulation.getLines();
            a.ModLine(Validaciones.ValidarEntero("Que linea desea modificar?;"));
        }
    }
}
