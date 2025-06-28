using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace SistemasCrud10_15.Modulos.archiveManHerency
{
    class RegistroNotas :archiveManipulation
    {
        private string name;
        private int notaUno;
        private int notaDos;
        private int notaTres;
        public RegistroNotas()
        {
            name = string.Empty;
            notaUno = 1;
            notaDos = 1;
            notaTres = 1;
        }
        public void RegistrarNotas()
        {
            id = UniqueID();
            name = Validaciones.ValidarTexto("Ingrese el nombre de usuario");
            notaUno = Validaciones.ValidarEntero(1,10,"Ingrese la primera nota");
            notaDos = Validaciones.ValidarEntero(1,10,"Ingrese la segunda nota");
            notaTres = Validaciones.ValidarEntero(1,10,"Ingrese la tercera nota");
            string registrar = string.Join(",", id, name, notaUno, notaDos, notaTres);
            listLines.Add(registrar);
            File.WriteAllLines(pathFile, listLines.ToArray());
        }
        public void CalcularPromedio()
        {
            foreach (var line in listLines) {
                string[] notas = line.Trim().Split(',');
                int.TryParse(notas[2], out int notaUno);
                int.TryParse(notas[3], out int notaDos);
                int.TryParse(notas[4], out int notaTres);
                double promedio = (notaUno + notaDos + notaTres) / 3.0;
                Console.WriteLine($"{notas[0]}) {notas[1]}, Promedio: {promedio:F1}");
            }
        }
    }
}
