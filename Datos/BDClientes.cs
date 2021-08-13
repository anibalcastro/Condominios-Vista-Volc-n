using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Objetos;

namespace Datos
{
    public class BDClientes
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;


        public void insertarCliente(ObjCliente objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO \"Reservas\".\"Clientes\"" +
                "( cedula, nombre, telefono, fecha_nacimiento, correo, nacionalidad, idioma, capital_nacion, moneda_nacion) " +
                "VALUES(" +
                objeto.cedula + "," +
                "'" + objeto.nombre + ", " +
                objeto.telefono + ", " +
                "'" + objeto.fecha_nacimiento + ", " +
                "'" + objeto.correo + "', " +
                "'" + objeto.nacionalidad +"', " +
                "'"+ objeto.idioma + "', " +
                "'" +  objeto.capital_nacion + "', " +
                "'" + objeto.moneda_nacion + "');"
                , conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void modificarCliente(ObjCliente objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("UPDATE \"Reservas\".\"Clientes\" SET " +
                "cedula =" + objeto.cedula + "," +
                "nombre ='" + objeto.nombre + "', " +
                "telefono =" + objeto.telefono + ", " +
                "fecha_nacimiento =' " + objeto.fecha_nacimiento + "', " +
                "correo =' " + objeto.correo + "', " +
                "nacionalidad ='" + objeto.nacionalidad +"', " +
                "idioma =' "+ objeto.idioma +"', " +
                "capital_nacion ='"+ objeto.capital_nacion +"', " +
                "moneda_nacion = '"+ objeto.moneda_nacion +"'" +
                "WHERE id_cliente =" + objeto.id_cliente + ";", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void eliminarCliente(ObjCliente objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("DELETE FROM \"Reservas\".\"Clientes\" " +
                "WHERE id_cliente = " + objeto.id_cliente +";", conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public List<ObjCliente> leerCliente()
        {
            List<ObjCliente> listaCliente = new List<ObjCliente>();
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT id_cliente, cedula, nombre, telefono, fecha_nacimiento, correo, nacionalidad, idioma, capital_nacion, moneda_nacion" +
                "FROM \"Reservas\".\"Clientes\"; ", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjCliente objeto = new ObjCliente()
                    {
                        id_cliente = dr.GetInt32(0),
                        cedula = dr.GetInt32(1),
                        nombre = dr.GetString(2),
                        telefono = dr.GetInt32(3),
                        fecha_nacimiento = dr.GetDateTime(4),
                        correo = dr.GetString(5),
                        nacionalidad = dr.GetString(6),
                        idioma = dr.GetString(6),
                        capital_nacion = dr.GetString(7),
                        moneda_nacion = dr.GetString(8)
                    };
                    listaCliente.Add(objeto);
                }
            }
            conexion.Close();
            return listaCliente;
        }


    }
}
