using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasCrud10_15.Modulos
{
    internal class Formato
    {
        private static int ancho = Console.WindowWidth;
        private static int alto;
        public static void Separador(char whatSepares = '-')
        {
            string separe = new string(whatSepares, ancho - 2);
            Console.WriteLine("+" + separe + "+");
        }
        public static void EscribirLinea(string contenido)
        {
            // Calcula el espacio disponible para el contenido
            int espacioDisponible = ancho - 2;
            if (contenido.Length > espacioDisponible)
                contenido = contenido.Substring(0, espacioDisponible);

            // Ajusta el contenido para que ocupe todo el ancho
            string linea = "|" + contenido.PadRight(espacioDisponible) + "|";
            Console.WriteLine(linea);
        }
    }
}
