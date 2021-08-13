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

            cmd = new NpgsqlCommand("", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjGastos objeto = new ObjGastos()
                    {

                    };
                    lista.Add(objeto);
                }
            }
            conexion.Close();
            return lista;
        }
    }
}
