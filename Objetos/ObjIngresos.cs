using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class ObjIngresos
    {
        public string moneda { set; get; }
        public decimal monto { set; get; }
        public string descripcion { set; get; }
        public DateTime fecha { set; get; }
    }
}
