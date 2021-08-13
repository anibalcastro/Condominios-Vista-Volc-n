using Npgsql;
using Objetos;
using System.Collections.Generic;

namespace Datos
{
    public class BDHabitaciones
    {

        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public void insertarHabitacion(ObjHabitacion habitacion)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO \"Habitaciones\".\"Habitacion\" (nombre, num_piso, max_personas, estado) " +
                "VALUES " +
                "('" + habitacion.nombre_habitacion + "'"+
                ",'" + habitacion.num_piso + "'" +
                "," + habitacion.max_personas +
                ",'" + habitacion.estado + "');", conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void modificarHabitacion(ObjHabitacion habitacion)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("UPDATE \"Habitaciones\".\"Habitacion\" " +
                "SET nombre  = '" + habitacion.nombre_habitacion + "',"
                + "num_piso = '"+ habitacion.num_piso + "'," + 
                "max_personas =" + habitacion.max_personas + 
                ", estado ='"+ habitacion.estado + "'"  + 
                " WHERE id_habitacion = " + habitacion.id_habitacion + ";", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void eliminarHabitacion(ObjHabitacion habitacion)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("DELETE FROM \"Habitaciones\".\"Habitacion\" " +
                "WHERE id_habitacion = " + habitacion.id_habitacion + ";", conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public List<ObjHabitacion> leerHabitacion ()
        {
            List<ObjHabitacion> listaHabitaciones = new List<ObjHabitacion>();
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT nombre, num_piso, max_personas, estado, id_habitacion FROM \"Habitaciones\".\"Habitacion\"; ", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjHabitacion habitacion = new ObjHabitacion()
                    {
                        nombre_habitacion = dr.GetString(0),
                        num_piso = dr.GetString(1),
                        max_personas = dr.GetInt32(2),
                        estado = dr.GetString(3),
                        id_habitacion = dr.GetInt32(4)
                    };
                    listaHabitaciones.Add(habitacion);
                }
            }
            conexion.Close();
            return listaHabitaciones;
        }
        


    }
}
