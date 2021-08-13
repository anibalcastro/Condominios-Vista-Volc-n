using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class ObjColaboradores
    {
        public int id_colaborador { set; get; }
        public int cedula { set; get; }
        public string nombre { set; get; }
        public int telefono { set; get; }
        public DateTime fecha_nacimiento { set; get; }
        public string correo { set; get; }
        public int salario { set; get; }
        public string contrasenna { set; get; }

        public string rol { set; get; }

    }
}
