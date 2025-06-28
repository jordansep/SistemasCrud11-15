﻿using System;
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

        // Valida numeros enteros.
        public static int ValidarEntero( string msg = "Ingrese un entero")
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
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!esN);
            return numero;
        }

        // Sobrescribir el metodo para que use uno acorde a lo necesario
        // En caso de que validar entero solo necesite ser llamado y/o pasarle el string usa el metodo que contiene el parametro string
        // En caso de querer agregar un rango entre dos numeros, llamara a el que contenga esos parametros extra
        public static int ValidarEntero(int min, int max, string msg = "Ingrese un entero")
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
                    // Extra: Si numero es menor que min o mayor que max, devolver un OverflowException.
                    if (numero < min || numero > max)
                        throw new OverflowException($"Ingrese un número entre {min} y {max} (inclusive).");

                    esN = true;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!esN);
            return numero;
        }
        // TODO: Rango de enteros para seleccion de opciones.
    }
}
