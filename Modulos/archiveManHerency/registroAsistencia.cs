using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemasCrud10_15.Modulos.archiveManHerency
{
    class registroAsistencia : archiveManipulation
    {
        protected static string pathBD = Ruta.setPathBD("Alumnos", "txt");
        private string name;
        private string state;
        private List<string> list;
        public registroAsistencia(){
            name = string.Empty;
            state = "Presente";
        }

        public void registrarAlumno()
        {
            listLines = File.Exists(pathBD) ? File.ReadAllLines(pathBD).ToList() : new List<string>();
            id = UniqueID();
            name = Validaciones.ValidarTexto("Ingrese el nombre de usuario");
            string registrar = string.Join(",", id, name);
            listLines.Add(registrar);
            File.WriteAllLines(pathBD, listLines.ToArray());
        }
        public void registrarAsistencia()
        {
            // TODO : TOMAR LISTA DEL ARCHIVO ALUMNOS PARA CREAR UNA LISTA DE ASISTENCIAS.
            List<string> newList = new List<string>();
            string[] alumnos = File.ReadAllLines(pathBD);
            // Por cada alumno, registrar su estado en el aula.
            int cont = 1;
            Console.WriteLine("Presione A (Ausente) | Presione B para (Presente) | Presione S para salir.");

            foreach (var item in alumnos)
            { 
                var a = item.Split(',');

                int uniqueID = cont;
                cont += 1;
                name = a[1];
                Console.WriteLine($"Alumno: {a[1]}");
                state = Status();
                string registrar = string.Join(",", uniqueID, name, state);
                newList.Add(registrar);

            }
                File.WriteAllLines(pathFile, newList.ToArray());
        }
        private string Status()
        {
            // Cambia el estado del alumno.
            ConsoleKeyInfo key;
            
            char keyCharPressed;
            // Mientras A-B o S no sean presionadas no funca
            do { 
                Console.Write("Estado: ");
                key = Console.ReadKey();
                Console.WriteLine("");
                keyCharPressed = char.ToLower(key.KeyChar);
                if (keyCharPressed != 'a' && keyCharPressed != 'b' && keyCharPressed != 's')
                {
                    Console.WriteLine("Caracter ingresado invalido.");
                }
            } while ( keyCharPressed!= 'a' && keyCharPressed != 'b' && keyCharPressed != 's');
            switch (keyCharPressed)
            {
                case 'a': state = "Ausente"; break;
                case 'b': state = "Presente";break;
                case 's': Environment.Exit(1);break;
            }
            return state;
        }   
    }
}
