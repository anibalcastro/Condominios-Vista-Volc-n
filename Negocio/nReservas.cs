using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objetos;
using Datos;

namespace Negocio
{
    public class nReservas
    {

        public void AgregarReserva(ObjReservas obj)
        {
            new Datos.BDReservas().insertarReservar(obj);
        }

        public void EditarReserva(ObjReservas obj)
        {
            new Datos.BDReservas().modificarReservar(obj);
        }

        public void EliminarReserva(ObjReservas obj)
        {
            new Datos.BDReservas().eliminarReservar(obj);
        }
    }
}
