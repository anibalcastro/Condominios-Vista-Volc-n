using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Objetos;

namespace Negocio
{
   public class nClientes
    {
        public void AgregarClientes(ObjCliente objeto)
        {
            new Datos.BDClientes().insertarCliente(objeto);
        }

        public void EliminarClientes(ObjCliente objeto)
        {
            new Datos.BDClientes().eliminarCliente(objeto);
        }

        public void ModificarClientes(ObjCliente objeto)
        {
            new Datos.BDClientes().modificarCliente(objeto);
        }

        public List<ObjCliente> leerClientes()
        {
            return new Datos.BDClientes().leerCliente();
        }

    }
}
