using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Objetos;

namespace Negocio
{
    public class nHabitacion
    {
        public void AgregarHabitaciones(ObjHabitacion obj)
        {
            new Datos.BDHabitaciones().insertarHabitacion(obj);
        }

        public void EditarHabitaciones(ObjHabitacion obj)
        {
            new Datos.BDHabitaciones().modificarHabitacion(obj);
        }

        public void EliminarHabitacion(ObjHabitacion obj)
        {
            new Datos.BDHabitaciones().eliminarHabitacion(obj);
        }

       public List<ObjHabitacion> ListaHabitaciones()
        {
            return new Datos.BDHabitaciones().leerHabitacion();
        }
    }
}
