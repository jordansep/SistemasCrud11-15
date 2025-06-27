using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SistemasCrud10_15.Modulos.archiveManHerency;

namespace SistemasCrud10_15.Modulos
{
    class archiveManipulation
    {
        protected static int id;
        protected static string pathFile => Ruta.pathFile;
        protected static string pathFolder = Ruta.pathFolder;
        protected static string[] lineas;
        protected static List<string> listLines = new List<string>();
        protected static string[] lineasBD;
        // Constructor
        public archiveManipulation(bool cargarLineasBD = false) {
            if(cargarLineasBD) lineasBD = File.ReadAllLines(Ruta.pathDB);
            lineas = File.ReadAllLines(Ruta.pathFile);
            listLines = lineas.ToList();
            id = UniqueID();
        }

        // Retorna un array con los strings contenidos en el archivo
        public static string[] getLines(string linesOf)
        {
            string[] lines = File.ReadAllLines(linesOf);
            return lines;
        }
        // Lee los strings de un archivo.
        public void ReadLines()
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
            int cantDatos;
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] separateLine = lineas[i].Split(',');
                int.TryParse(separateLine[0], out int foundID);
                if(lineToModify == foundID)
                {
                    Console.WriteLine("Que dato desea modificar?");
                    for (int j = 1; j < separateLine.Length; j++)
                    {
                        Console.WriteLine($"{j}) {separateLine[j]}");
                    }
                    int option = Validaciones.ValidarEntero("Ingrese una opcion");
                    // Segun la opcion elegida, entrara a ese dato especificado y lo modificara
                    while (option <= 0 || option > separateLine.Count())
                    {
                        Console.WriteLine($"Opción inválida. Debe estar entre 1 y {separateLine.Count() - 1}.");
                        option = Validaciones.ValidarEntero("Ingrese una opción válida");
                    }
                    separateLine[option] = Validaciones.ValidarTexto("Ingrese el nuevo valor");


                }
                lineas[i] = string.Join(",", separateLine);
                cantDatos = separateLine.Length;
            }
            File.WriteAllLines(pathFile,lineas);
        }

        // Elimina la linea seleccionada por el usuario en funcion de la ID.
        public void DeleteID(int lineToDelete, bool deleteOnFile = true)
        {
            if (deleteOnFile) listLines = lineas.ToList();
            else { listLines = lineasBD.ToList(); }
            for (int i = 0; i< lineas.Length; i++)
            {
                // Buscar por la ID coincidente sin importar su posicion en el archivo
                string[] searchID = lineas[i].Split(',');
                int.TryParse(searchID[0], out int foundID);
                if (foundID == lineToDelete)
                {
                    listLines.RemoveAt(i);
                }
            }
            if (deleteOnFile){
                lineas = listLines.ToArray();
                File.WriteAllLines(pathFile, lineas);
            }
            else {
                lineasBD = listLines.ToArray();
                File.WriteAllLines(Ruta.pathDB, lineasBD);
            }
        }
        // Verifica y crea que cada ID sea unica.
        protected static int UniqueID()
        {

            HashSet<int> existingIDs = new HashSet<int>();
            foreach (var linea in lineas)
            {
                var partes = linea.Split(',');
                if (int.TryParse(partes[0], out int existentID))
                {
                    existingIDs.Add(existentID);
                }
            }
            int newID = 1;
            while (existingIDs.Contains(newID))
            {
                newID++;
            }
            return newID;
        }

        // Mostrar las lineas en consola 
        public void ShowLines(string ofArchive)
        {
            lineas = getLines(ofArchive);
            foreach (string line in lineas)
            {
                string[] lines = line.Split(',');
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.Write($"{lines[i]})");
                    }
                    else if (i == lines.Length - 1)    
                    {
                        Console.Write($" {lines[i]}");
                    }
                    else
                    {
                        Console.Write($" {lines[i]} -");
                    }
                }
                Console.WriteLine();
            }
        }

        // TODO: Registrar linea por linea --
        // TODO: Leer Archivo --
        // TODO: NombrarArchivos
        // TODO: Modificacion de datos --
        // TODO: Eliminar por ID --
        // TODO: Agregar datos --
        // TODO: Sistema ID Unica. --
        // TODO: Registrar usuarios.
    }
}
