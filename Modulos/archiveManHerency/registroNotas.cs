using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace SistemasCrud10_15.Modulos.archiveManHerency
{
    class registroNotas :archiveManipulation
    {
        private string name;
        private int notaUno;
        private int notaDos;
        private int notaTres;
        public registroNotas()
        {
            name = string.Empty;
            notaUno = 0;
            notaDos = 0;
            notaTres = 0;
        }
        public void registrarNotas()
        {
            id = UniqueID();
            name = Validaciones.ValidarTexto("Ingrese el nombre de usuario");
            notaUno = Validaciones.ValidarEntero("Ingrese la primera nota");
            notaDos = Validaciones.ValidarEntero("Ingrese la segunda nota");
            notaTres = Validaciones.ValidarEntero("Ingrese la tercera nota");

            string registrar = string.Join(",", id, name, notaUno, notaDos, notaTres);
            listLines.Add(registrar);
            File.WriteAllLines(pathFile, listLines.ToArray());
        }
    }
}
