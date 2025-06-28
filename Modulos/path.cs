using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemasCrud10_15.Modulos
{
    public class Ruta
    {

        // Por defecto origenPath es el Directorio Actual
        public static string origenPath = Directory.GetCurrentDirectory();
        public static string pathFolder;
        public static string pathFile;
        public static string pathDB;

        // Se usa para settear un origenPath custom.
            // Recordemos que por defecto es el Directorio Actual.
        public static string setOrigenPath()
        {
            string getPath = Validaciones.ValidarDirectorio();
            origenPath = getPath;
            return getPath;
        }
                // Guardamos la ruta de la carpeta en pathFolder.
        public static string SetPathFolder(string folderName) { 
            // Setteamos el pathFolder segun un nombre dado y el origenPath.
            pathFolder = Path.Combine(origenPath, folderName);
            // Si no existe lo creamos
            if (!Directory.Exists(pathFolder)) { 
                Directory.CreateDirectory(pathFolder);
            }
            return pathFolder;
        }
            // Setteamos un pathFile segun el nombre dado y el pathFolder
        public static string SetPathFile(string fileName, string extencion) { 
            // Concatenamos para obtener la ruta.
            string setFile = Path.Combine(pathFolder, fileName+"."+extencion);
             // Guardamos la ruta del archivo en pathFile.
            pathFile = setFile;
            // Si no existe la creamos.
            if (!File.Exists(setFile)) { File.Create(setFile).Close(); }
            return setFile;
        }
        public static string setPathBD(string nameBD, string extencion)
        {
            // Concatenamos para obtener la ruta.
            string setFile = Path.Combine(pathFolder, nameBD+ "." + extencion);
            // Guardamos la ruta del archivo en pathFile.
            pathDB = setFile;
            // Si no existe la creamos.
            if (!File.Exists(setFile)) { File.Create(setFile).Close(); }
            return setFile;
        }
    }
}
