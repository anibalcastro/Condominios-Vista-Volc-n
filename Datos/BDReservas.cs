using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Objetos;

namespace Datos
{
    public class BDReservas
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;


        public void insertarReservar(ObjReservas objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO \"Reservas\".\"Reservaciones\"" +
                "(id_cliente, id_colaborador, id_habitacion, entrada, salida, cant_personas, id_plataforma, precio) " +
                "VALUES(" +
                objeto.id_cliente + ", " +
                objeto.id_colaborador + ", " +
                objeto.id_habitacion + ", " +
                "' " + objeto.entrada + "', " +
                "'" + objeto.salida + "', " +
                 objeto.cant_personas + ", " +
                 objeto.id_plataforma + ", " +
                 objeto.precio + "); ", conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void modificarReservar(ObjReservas objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("UPDATE \"Reservas\".\"Reservaciones\"  SET " +
                "id_habitacion =" + objeto.id_habitacion + ", " +
                "entrada ='" + objeto.entrada + "', " +
                "salida ='" + objeto.salida + "', " +
                "cant_personas =" + objeto.cant_personas + ", " +
                "id_plataforma =" + objeto.id_plataforma + ", " +
                "precio =" + objeto.precio +
                "WHERE id =?; ", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void eliminarReservar(ObjReservas objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("DELETE FROM \"Reservas\".\"Reservaciones\" WHERE id =" + objeto.id_reservas + " ; ", conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public List<ObjReporteReserva> leerReservas()
        {
            List<ObjReporteReserva> lista = new List<ObjReporteReserva>();
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT id_reserva, c.nombre, e.nombre, h.nombre, entrada, salida, " +
                "cant_personas, p.nombre, precio " +
                " FROM \"Reservas\".\"Reservaciones\" r " +
                " INNER JOIN \"Reservas\".\"Clientes\" c ON c.id_cliente = r.id_cliente " +
                " INNER JOIN \"Administracion\".\"Colaboradores\" e ON e.id = r.id_colaborador " +
                " INNER JOIN \"Habitaciones\".\"Habitacion\" h ON h.id_habitacion = r.id_habitacion " +
                " INNER JOIN \"Reservas\".\"Plataforma\" p ON p.id_plataforma = r.id_plataforma ; ", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjReporteReserva objeto = new ObjReporteReserva()
                    {
                        id_reserva = dr.GetInt32(0),
                        nombre_cliente = dr.GetString(1),
                        nombre_colaborador = dr.GetString(2),
                        nombre_habitacion = dr.GetString(3),
                        entrada = dr.GetDateTime(4),
                        salida = dr.GetDateTime(5),
                        cantidad_personas = dr.GetInt32(6),
                        nombre_plataforma = dr.GetString(7),
                        precio = dr.GetInt32(8)
                    };
                    lista.Add(objeto);
                }
            }
            conexion.Close();
            return lista;
        }

        public int Ganancia()
        {
            int ganancia = 0;

            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT SUM(precio) FROM \"Reservas\".\"Reservaciones\";",
                conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ganancia = dr.GetInt32(0);
                }
            }

            return ganancia;
        }

        public List<ObjReporteReserva> reporteXfechas(DateTime desde, DateTime hasta)
        {
            List<ObjReporteReserva> listaColaborador = new List<ObjReporteReserva>();
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT id_reserva, c.nombre, e.nombre, h.nombre, entrada, salida, cant_personas, p.nombre, precio " +
                "FROM \"Reservas\".\"Reservaciones\" r " +
                "INNER JOIN \"Reservas\".\"Clientes\" c ON c.id_cliente = r.id_cliente " +
                "INNER JOIN \"Administracion\".\"Colaboradores\" e ON e.id = r.id_colaborador " +
                "INNER JOIN \"Habitaciones\".\"Habitacion\" h ON h.id_habitacion = r.id_habitacion " +
                "INNER JOIN \"Reservas\".\"Plataforma\" p ON p.id_plataforma = r.id_plataforma " +
                "WHERE entrada BETWEEN  '" + desde + "' AND '" + hasta + "'; ", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjReporteReserva objeto = new ObjReporteReserva()
                    {
                        id_reserva = dr.GetInt32(0),
                        nombre_cliente = dr.GetString(1),
                        nombre_colaborador = dr.GetString(2),
                        nombre_habitacion = dr.GetString(3),
                        entrada = dr.GetDateTime(4),
                        salida = dr.GetDateTime(5),
                        cantidad_personas = dr.GetInt32(6),
                        nombre_plataforma = dr.GetString(7),
                        precio = dr.GetInt32(8)
                    };
                    listaColaborador.Add(objeto);
                }
            }
            conexion.Close();
            return listaColaborador;
        }

        public List<ObjReporteReserva> reporteXID(int id)
        {
            List<ObjReporteReserva> listaColaborador = new List<ObjReporteReserva>();
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT id_reserva, c.nombre, e.nombre, h.nombre, entrada, salida, cant_personas, p.nombre, precio " +
                "FROM \"Reservas\".\"Reservaciones\" r " +
                "INNER JOIN \"Reservas\".\"Clientes\" c ON c.id_cliente = r.id_cliente " +
                "INNER JOIN \"Administracion\".\"Colaboradores\" e ON e.id = r.id_colaborador " +
                "INNER JOIN \"Habitaciones\".\"Habitacion\" h ON h.id_habitacion = r.id_habitacion " +
                "INNER JOIN \"Reservas\".\"Plataforma\" p ON p.id_plataforma = r.id_plataforma " +
                "WHERE id_reserva =" + id + ";", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjReporteReserva objeto = new ObjReporteReserva()
                    {
                        id_reserva = dr.GetInt32(0),
                        nombre_cliente = dr.GetString(1),
                        nombre_colaborador = dr.GetString(2),
                        nombre_habitacion = dr.GetString(3),
                        entrada = dr.GetDateTime(4),
                        salida = dr.GetDateTime(5),
                        cantidad_personas = dr.GetInt32(6),
                        nombre_plataforma = dr.GetString(7),
                        precio = dr.GetInt32(8)
                    };
                    listaColaborador.Add(objeto);
                }
            }
            conexion.Close();
            return listaColaborador;
        }

        public int ReservasParaHoy()
        {
            int hoy = 0;
            DateTime fecha_actual = DateTime.Now.Date;

            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT COUNT(id_reserva) FROM  \"Reservas\".\"Reservaciones\"" +
                "WHERE entrada = '" + fecha_actual + "'; ",
                conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    hoy = dr.GetInt32(0);
                }
            }

            return hoy;
        }

        public int SalidasHoy()
        {
            int hoy = 0;
            DateTime fecha_actual = DateTime.Now.Date;

            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT COUNT(id_reserva) FROM  \"Reservas\".\"Reservaciones\"" +
                "WHERE salida = '" + fecha_actual + "'; ",
                conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    hoy = dr.GetInt32(0);
                }
            }

            return hoy;
        }

        public List<int> reservasPlataforma()
        {
            List<int> lista = new List<int>();
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT COUNT(id_reserva), id_plataforma FROM  \"Reservas\".\"Reservaciones\" " +
                " GROUP BY id_plataforma; ", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int reserva_plataforma = dr.GetInt32(0);
                    lista.Add(reserva_plataforma);
                }
            }
            return lista;
        }
    



    }
}
