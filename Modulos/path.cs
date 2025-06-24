using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemasCrud10_15.Modulos
{
    class Ruta
    {

        // Por defecto origenPath es el Directorio Actual
        public static string origenPath = Directory.GetCurrentDirectory();
        public static string pathFolder;
        public static string pathFile;

        public static string setOrigenPath()
        { // Se usa para settear un origenPath custom.
            // Recordemos que por defecto es el Directorio Actual.
            string getPath = Validaciones.ValidarDirectorio();
            origenPath = getPath;
            return getPath;
        }
        public static string setPathFolder(string folderName) { 
            // Setteamos el pathFolder segun un nombre dado y el origenPath.
            pathFolder = Path.Combine(origenPath, folderName);
            if (!Directory.Exists(pathFolder)) { 
                Directory.CreateDirectory(pathFolder);
            }
            return pathFolder;
        }
        public static string setPathFile(string fileName, string extencion) { 
            // Setteamos un pathFile segun el nombre dado y el pathFolder
            string setFile = Path.Combine(pathFolder, fileName+"."+extencion);
            if (!File.Exists(setFile)) { File.Create(setFile).Close(); }
            return setFile;
        }
    }
}
