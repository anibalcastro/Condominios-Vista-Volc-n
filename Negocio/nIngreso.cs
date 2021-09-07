using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Objetos;

namespace Negocio
{
    public class nIngreso
    {
        public void agregar(ObjIngresos ingreso)
        {
            new Datos.BDIngreso().agregar(ingreso);
        }
    }
}
