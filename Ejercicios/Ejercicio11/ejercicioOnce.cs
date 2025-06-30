using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasCrud10_15.Modulos;
using SistemasCrud10_15.Modulos.archiveManHerency;

namespace SistemasCrud10_15.Ejercicios.Ejercicio11
{
    public class ejercicioOnce
    {
        public static void Ejecutar()
        {
            Ruta.SetPathFolder("usuarios");
            Ruta.SetPathFile("usuarios", "txt");
            registroUsuarios b = new registroUsuarios();
            b.ShowLines(Ruta.pathFile);
            Formato.Separador();
            Formato.EscribirLinea("1) Registrar usuario nuevo");
            Formato.EscribirLinea("2) Loguearse.");
            Formato.EscribirLinea("3) Modificar usuario");
            Formato.EscribirLinea("4) Eliminar usuario por ID");
            Formato.Separador();
            int opciones = Validaciones.ValidarEntero(1,3,"Ingrese una opcion");
            Formato.Separador();
            int max = archiveManipulation.getLines(Ruta.pathFile).Length;
            switch (opciones)
            {
                case 1: b.registrarUsuario(); break;
                case 2: b.Loggin(); break;
                case 3: b.ModLine(Validaciones.ValidarEntero(1, max, "Que usuario desea modificar?")); break;
                case 4: b.DeleteID(Validaciones.ValidarEntero(1, max, "Que usuario desea eliminar?")); break;
            }
        }
    }
}
