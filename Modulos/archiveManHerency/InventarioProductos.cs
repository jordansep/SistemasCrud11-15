using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemasCrud10_15.Modulos.archiveManHerency
{
    class InventarioProductos: archiveManipulation
    {
        protected static string name;
        protected static int price;
        protected static int stock;
        public InventarioProductos()
        {
            name = string.Empty;
            price = 0;
            stock = 0;
        }
        public static void agregarProducto()
        {
            id = UniqueID();
            name = Validaciones.ValidarTexto("Ingrese el nombre del producto");
            price = Validaciones.ValidarEntero("Ingrese el precio del producto");
            stock = Validaciones.ValidarEntero($"Ingrese la cantidad de stock del producto: {name}");
            string registrar = string.Join(",", id, name, price, stock);
            listLines.Add(registrar);
            File.WriteAllLines(pathFile, listLines.ToArray());
        }
    }
}

