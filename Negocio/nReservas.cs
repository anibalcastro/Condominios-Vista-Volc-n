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

        public int ganancia()
        {
            return new Datos.BDReservas().Ganancia();
        }

        public int entradashoy()
        {
            return new Datos.BDReservas().ReservasParaHoy();
        }

        public List<ObjReporteReserva> buscarPorFecha(DateTime desde, DateTime hasta)
        {
            return new Datos.BDReservas().reporteXfechas(desde, hasta);
        }

        public List<ObjReporteReserva> buscarPorID(int id)
        {
            return new Datos.BDReservas().reporteXID(id);
        }

        public List<ObjReporteReserva> leerReserva ()
        {
            return new Datos.BDReservas().leerReservas();
        }
    }
}
