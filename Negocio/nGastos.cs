using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objetos;
using Datos;

namespace Negocio
{
    public class nGastos
    {
        public void AgregarGasto(ObjGastos objeto)
        {
            new Datos.BDGastos().insertarGastos(objeto);
        }

        public List<ObjGastos> leerGastos()
        {
            return new Datos.BDGastos().leerGastos();
        }
    }
}
