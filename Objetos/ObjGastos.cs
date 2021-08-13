using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
  public class ObjGastos
    {
        public int id_gasto { set; get; }
        public string tipo_gasto { set; get; }
        public int num_factura { set; get; }
        public int monto { set; get; }
        public DateTime fecha { set; get; }
    }
}
