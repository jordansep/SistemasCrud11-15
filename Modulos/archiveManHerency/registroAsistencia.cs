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
        private string name;
        private string state;

        public registroAsistencia(){
            name = string.Empty;
            state = "Presente";
        }

        public void registrarAlumno()
        {
            id = UniqueID();
            name = Validaciones.ValidarTexto("Ingrese el nombre de usuario");
            string registrar = string.Join(",", id, name);
            listLines.Add(registrar);
            File.WriteAllLines(pathFile, listLines.ToArray());
        }
        public void registrarAsistencia()
        {
            // TODO : TOMAR LISTA DEL ARCHIVO ALUMNOS PARA CREAR UNA LISTA DE ASISTENCIAS.
            List<string> newList = new List<string>();
            string[] alumnos = File.ReadAllLines(pathFile);
            foreach (var item in alumnos)
            { 
                var a = item.Split(',');

                id = UniqueID();
                name = a[1];
                state = Status();
                string registrar = string.Join(",", id, name, state);
                newList.Add(registrar);

            }
                File.AppendAllLines(pathFile, newList.ToArray());
        }
        private string Status()
        {
            ConsoleKeyInfo key;
            char keyCharPressed;
            do { 
                Console.WriteLine("Presione A (Ausente) | Presione B para (Presente) | Presione S para salir.");
                key = Console.ReadKey();
                keyCharPressed = char.ToLower(key.KeyChar);
                if (keyCharPressed != 'a' && keyCharPressed != 'b' && keyCharPressed != 's')
                {
                    Console.WriteLine("Caracter ingresado invalido.");
                }
            } while ( keyCharPressed!= 'a' && keyCharPressed != 'b' && keyCharPressed != 's');
            switch (keyCharPressed)
            {
                case 'a': state = "Ausente"; break;
                case 's': ;break;
            }
            return state;
        }   
    }
}
