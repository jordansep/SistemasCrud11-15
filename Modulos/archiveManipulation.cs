using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemasCrud10_15.Modulos
{
    class archiveManipulation
    {
        private int id;
        private static string pathFile = Ruta.pathFile;
        private static string pathFolder = Ruta.pathFolder;
        private static string[] lineas = File.ReadAllLines(Ruta.pathFile);
        private static List<string> listLines = new List<string>(lineas.ToList());
        // Constructor
        public archiveManipulation() { 
            this.id = 1;
        }

        // Retorna un array con los strings contenidos en el archivo
        public static string[] getLines()
        {
            string[] lines = File.ReadAllLines(Ruta.pathFile);
            return lines;
        }
        // Lee los strings de un archivo.
        public void readLines()
        {
            if(lineas.Length != 0)
            {
                foreach (string line in lineas)
                {
                    Console.WriteLine(line);
                }
            }
        }

        // Agrega un string al archivo
        public void addLine(string addLine)
        {
            File.AppendAllText(pathFile, addLine);
        }

        // Agrega un array de strings al archivo
        public void addLines(string[] addLines)
        {
            File.AppendAllLines(pathFile, addLines);
        }

        // Modificacion de datos segun la linea elegida por el usuario.
        public void ModLine(int lineToModify) {
            lineToModify -= 1;
            int cantDatos;
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] separateLine = lineas[i].Split(',');
                if(lineToModify == i)
                {
                    Console.WriteLine("Que dato desea modificar?");
                    Console.WriteLine("1) Nombre");
                    Console.WriteLine("2) Descripcion");
                    int option = Validaciones.ValidarEntero("Ingrese una opcion: ");
                    // Segun la opcion elegida, entrara a ese dato especificado y lo modificara
                    while (option <= 0 || option > separateLine.Count())
                    {
                        Console.WriteLine($"Opción inválida. Debe estar entre 1 y {separateLine.Count() - 1}.");
                        option = Validaciones.ValidarEntero("Ingrese una opción válida: ");
                    }
                    separateLine[option] = Validaciones.ValidarTexto("Ingrese el nuevo valor");


                }
                lineas[i] = string.Join(",", separateLine);
                cantDatos = separateLine.Length;
            }
            File.WriteAllLines(pathFile,lineas);
        }

        // Elimina la linea seleccionada por el usuario en funcion de la ID.
        public void deleteID(int lineToDelete)
        {
            for(int i = 1; i< lineas.Length; i++)
            {
                string[] searchID = lineas[i].Split(',');
                int.TryParse(searchID[0], out int foundID);
                if (foundID == lineToDelete)
                {
                    listLines.RemoveAt(i);
                }
            }
            lineas = listLines.ToArray();
            File.WriteAllLines(pathFile,lineas);
        }


        // Nombrar archivos.
        // TODO: Registrar linea por linea --
        // TODO: Leer Archivo --
        // TODO: NombrarArchivos
        // TODO: Modificacion de datos --
        // TODO: Eliminar por ID --
        // TODO: Agregar datos
        // TODO: Sistema ID Unica.
    }
}
