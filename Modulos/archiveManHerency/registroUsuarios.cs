using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SistemasCrud10_15.Ejercicios;

namespace SistemasCrud10_15.Modulos.archiveManHerency
{
    class registroUsuarios:archiveManipulation, IRegistros
    {
        private static string nombre;
        private static string email;
        private static int edad;
        private static string contraseña;
        public registroUsuarios()
        {
            nombre = string.Empty;
            email = string.Empty;
            edad = 0;
            contraseña = "1";
        }
        public void AddRegister()

        {
            id = UniqueID();
            nombre = Validaciones.ValidarTexto("Ingrese el nombre de usuario");
            email = Validaciones.ValidarTexto("Ingrese el Correo Electronico");
            edad = Validaciones.ValidarEntero(1,100,"Ingrese la edad del usuario");
            contraseña = Validaciones.ValidarTexto("Ingrese la contraseña del usuario");

            string registrar = string.Join(",", id, nombre, email, edad, contraseña);
            listLines.Add(registrar);
            File.WriteAllLines(pathFile, listLines.ToArray());
        }
        public void Loggin()
        {
            Formato.EscribirLinea("Ingrese el nombre de usuario o email");
            nombre = Validaciones.ValidarTexto("Ingrese el nombre de usuario o email");
            contraseña = Validaciones.ValidarTexto("Ingrese la contraseña");
            lineas = getLines(pathFile);
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] datos = lineas[i].Split(',');
                if (datos[1] == nombre && datos[4] == contraseña || datos[2] == nombre && datos[4] == contraseña)
                {
                    Formato.EscribirLinea("Logueado correctamente");
                    Formato.EscribirLinea($"Bienvenido {datos[1]}");
                    int opciones = Validaciones.ValidarEntero(1, 3, "Que desea hacer? \n1) Modificar datos \n2) Eliminar usuario \n3) Salir");
                    switch (opciones)
                    {
                        case 1: ModLine(Validaciones.ValidarEntero(1, datos.Length, "Que dato desea modificar?")); break;
                        case 2: DeleteID(int.Parse(datos[0])); break;
                        case 3: return;
                    }

                    return;
                }
            }
        }
        
    }
}
