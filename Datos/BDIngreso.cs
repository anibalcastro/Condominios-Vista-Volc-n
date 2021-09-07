using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Objetos;

namespace Datos
{
    public class BDIngreso
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public void agregar(ObjIngresos ingreso)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO \"Administracion\".\"Ingresos\"(moneda, monto,descripcion, fecha) " +
                "VALUES" +
                "('" + ingreso.moneda + "'," +
                       ingreso.monto + "," +
                       "'" + ingreso.descripcion + "','" +
                       ingreso.fecha + "');", conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
