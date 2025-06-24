using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemasCrud10_15.Modulos.archiveManHerency
{
    class registroUsuarios:archiveManipulation
    {
        private string nombre;
        private string email;
        private int edad;
        public registroUsuarios()
        {
            this.nombre = string.Empty;
            this.email = string.Empty;
            this.edad = 0;
        }
    }
}
