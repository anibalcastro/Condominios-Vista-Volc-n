using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Objetos;
using Npgsql;

namespace Datos
{
    public class BDGastos
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;


        public void insertarGastos(ObjGastos objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO \"Administracion\".\"Gastos\"(tipo_gasto, num_factura,fecha, monto) " +
                "VALUES" +
                "('" + objeto.tipo_gasto +"'," +
                       objeto.num_factura + "," +
                       "'" + objeto.fecha + "',"+
                       objeto.monto + ");", conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public List<ObjGastos> leerGastos()
        {
            List<ObjGastos> lista = new List<ObjGastos>();
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT id, tipo_gasto, num_factura, monto, fecha FROM \"Administracion\".\"Gastos\""
                , conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjGastos objeto = new ObjGastos()
                    {
                        id_gasto = dr.GetInt32(0),
                        tipo_gasto = dr.GetString(1),
                        num_factura = dr.GetInt32(2),
                        monto = dr.GetInt32(3),
                        fecha = dr.GetDateTime(4)
                    };
                    lista.Add(objeto);
                }
            }
            conexion.Close();
            return lista;
        }

        public List<ObjGastos> leerGastosPorFecha(DateTime desde, DateTime hasta)
        {
            List<ObjGastos> lista = new List<ObjGastos>();
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT id, tipo_gasto, num_factura, monto, fecha FROM \"Administracion\".\"Gastos\" " +
                " WHERE fecha BETWEEN '"+ desde +"' AND '"+ hasta +"'; "
                , conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjGastos objeto = new ObjGastos()
                    {
                        id_gasto = dr.GetInt32(0),
                        tipo_gasto = dr.GetString(1),
                        num_factura = dr.GetInt32(2),
                        monto = dr.GetInt32(3),
                        fecha = dr.GetDateTime(4)
                    };
                    lista.Add(objeto);
                }
            }
            conexion.Close();
            return lista;
        }
    }
}
