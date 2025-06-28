using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemasCrud10_15.Modulos.archiveManHerency
{
    class registroUsuarios:archiveManipulation
    {
        private static string nombre;
        private static string email;
        private static int edad;
        public registroUsuarios()
        {
            nombre = string.Empty;
            email = string.Empty;
            edad = 0;
        }
        public void registrarUsuario()
        {
            id = UniqueID();
            nombre = Validaciones.ValidarTexto("Ingrese el nombre de usuario");
            email = Validaciones.ValidarTexto("Ingrese el Correo Electronico");
            edad = Validaciones.ValidarEntero(1,100,"Ingrese la edad del usuario");
            string registrar = string.Join(",", id, nombre, email, edad);
            listLines.Add(registrar);
            File.WriteAllLines(pathFile, listLines.ToArray());
        }
        
    }
}
