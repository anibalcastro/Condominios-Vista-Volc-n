using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class ObjReservas
    {
        public int id_reservas { set; get; }
        public int id_cliente { set; get; }
        public int id_colaborador { set; get; }
        public int id_plataforma { set; get; }
        public int id_habitacion { set; get; }
        public DateTime entrada { set; get; }
        public DateTime salida { set; get; }
        public int cant_personas { set; get; }
        public int precio { set; get; }


    }
}
