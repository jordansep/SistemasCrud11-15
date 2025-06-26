using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemasCrud10_15.Modulos.archiveManHerency
{
    class listaTareas : archiveManipulation
    {
        private static string descripcion;
        private static string estado;
        public listaTareas()
        {
            descripcion = string.Empty;
            estado = string.Empty;
        }
        public void agregarTarea()
        {
            id = UniqueID();
            descripcion = Validaciones.ValidarTexto("Ingrese una tarea.");
            estado = "Incompleta";
            string registrar = string.Join(",", id, descripcion, estado);
            listLines.Add(registrar);
            File.WriteAllLines(pathFile, listLines.ToArray());
        }
        public void ModificarEstado(int modificarEstado)
        {
            string realized = "Completa";
            string unrealized = "Incompleta";
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] buscarEstado = lineas[i].Split(',');
                int.TryParse(buscarEstado[0], out int id);
                if (modificarEstado == id)
                {
                    if (buscarEstado[2] == realized)
                    {
                        buscarEstado[2] = unrealized;
                    }else if (buscarEstado[2] == unrealized)
                    {
                        buscarEstado[2] = realized;
                    }
                }
                lineas[i] = string.Join (",", buscarEstado);
                File.WriteAllLines (pathFile, lineas.ToArray());
            }

        }
    }
}
