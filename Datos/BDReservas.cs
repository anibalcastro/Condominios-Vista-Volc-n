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
                objeto.id_colaborador +", " +
                objeto.id_habitacion +", " +
                "' "+ objeto.entrada + "', " +
                "'" + objeto.salida + "', " +
                 objeto.cant_personas +", " +
                 objeto.id_plataforma+", " +
                 objeto.precio +"); ", conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void modificarReservar(ObjReservas objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("UPDATE \"Reservas\".\"Reservaciones\"  SET " +
                "id_habitacion ="+objeto.id_habitacion+", " +
                "entrada ='"+ objeto.entrada+"', " +
                "salida ='"+ objeto.salida +"', " +
                "cant_personas ="+ objeto.cant_personas +", " +
                "id_plataforma ="+ objeto.id_plataforma +", " +
                "precio =" +objeto.precio +
                "WHERE id =?; ", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void eliminarReservar(ObjReservas objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("DELETE FROM \"Reservas\".\"Reservaciones\" WHERE id ="+ objeto.id_reservas +" ; ", conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public List<ObjColaboradores> leerColaborador()
        {
            List<ObjColaboradores> listaColaborador = new List<ObjColaboradores>();
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjColaboradores objeto = new ObjColaboradores()
                    {
                        id_colaborador = dr.GetInt32(0),
                        nombre = dr.GetString(1),
                        telefono = dr.GetInt32(2),
                        fecha_nacimiento = dr.GetDateTime(3),
                        correo = dr.GetString(4),
                        contrasenna = dr.GetString(5),
                        salario = dr.GetInt32(6)
                    };
                    listaColaborador.Add(objeto);
                }
            }
            conexion.Close();
            return listaColaborador;
        }

    }
}
