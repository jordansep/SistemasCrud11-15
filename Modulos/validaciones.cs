using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasCrud10_15.Modulos
{
    public class Validaciones
    {
        // TODO: Validaciones necesarias.
        public static string ValidarTexto(string msg="Ingrese una cadena de texto")
        {
            bool esTexto = false;
            string respuesta = "";
            do {
                try
                {
                    Console.Write(msg + ": ");
                    respuesta = Console.ReadLine();
                    if (string.IsNullOrEmpty(respuesta)) throw new ArgumentNullException($"El texto no puede ser nulo");
                    if (string.IsNullOrWhiteSpace(respuesta)) throw new ArgumentNullException($"El texto no puede ser un espacio");
                    if (long.TryParse(respuesta, out long a)) throw new FormatException($"Formato incorrecto, tiene que ser una cadena de texto");
                    esTexto = true;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("El texto no puede ser nulo");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Error en el formato {respuesta}");
                }
                catch (Exception e) {
                    Console.WriteLine(e);
                }
            }while (!esTexto);
            return respuesta;
        }
        public static string ValidarDirectorio(string msg = "Ingrese la ruta donde trabajaremos")
        {
            bool esTexto = false;
            string respuesta = "";
            do
            {
                try
                {
                    Console.Write(msg + ": ");
                    respuesta = Console.ReadLine();
                    if(!Directory.Exists(respuesta)) throw new DirectoryNotFoundException($"El directorio: {respuesta}\n    No fue encontrado");
                    if(string.IsNullOrWhiteSpace(respuesta)) throw new ArgumentNullException($"El directorio no puede ser nulo");
                    esTexto = true;
                }
                catch (ArgumentNullException) { }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } while (!esTexto);
            return respuesta;
        }
        public static int ValidarEntero(string msg = "Ingrese un entero")
        {
            bool esN = false;
            int numero = 0;
            do
            {
                Console.Write(msg + ": ");
                string n = Console.ReadLine();
                try
                {
                    if (!int.TryParse(n, out numero))
                        throw new Exception("Ingrese un numero valido.");
                    esN = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El numero ingresado es muy grande");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!esN);
            return numero;
        }
    }
}
