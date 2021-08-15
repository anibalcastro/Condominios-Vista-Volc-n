using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class ObjReporteReserva
    {
        public int id_reserva { set; get; }
        public string nombre_cliente { set; get; }
        public string nombre_colaborador { set; get; }
        public string nombre_habitacion { set; get; }
        public DateTime entrada { set; get; }
        public DateTime salida { set; get; }
        public int cantidad_personas { set; get; }
        public string nombre_plataforma { set; get; }
        public int precio { set; get; }
    }
}
