using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Objetos;

namespace Datos
{
    public class BDColaboradores
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;


        public void insertarColaborador(ObjColaboradores objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO \"Administracion\".\"Colaboradores\" " +
                "( cedula, nombre, telefono, fecha_nacimiento, correo, contrasenna,rol, salario) " +
                "VALUES(" +
                        objeto.cedula + "," +
                "'" + objeto.nombre + "'," +
                       objeto.telefono + "," +
                "'" + objeto.fecha_nacimiento + "'," +
                "'" + objeto.correo + "'," +
                  "'" + objeto.contrasenna + "'," +
                  "'" + objeto.rol + "'," +
                    objeto.salario + ");" 
                , conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void modificarColaborador(ObjColaboradores objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("UPDATE \"Administracion\".\"Colaboradores\" " +
                "SET " +
                "cedula =" + objeto.cedula + ", " +
                "nombre ='" + objeto.nombre +  "', " +
                "telefono =" + objeto.telefono +  ", " +
                "fecha_nacimiento =' "+ objeto.fecha_nacimiento +"', " +
                "correo ='" +  objeto.correo +"', " +
                "rol ='" + objeto.rol + "', " +
                "salario = " + objeto.salario +
                "WHERE id = " +  objeto.id_colaborador +"; ", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void eliminarColaborador(ObjColaboradores objeto)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("DELETE FROM \"Administracion\".\"Colaboradores\" " +
                "WHERE id =" + objeto.id_colaborador + ";", conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public List<ObjColaboradores> leerColaborador()
        {
            List<ObjColaboradores> listaColaborador = new List<ObjColaboradores>();
            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT id, cedula, nombre, telefono, fecha_nacimiento, correo, contrasenna, salario, rol FROM \"Administracion\".\"Colaboradores\";", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjColaboradores objeto = new ObjColaboradores()
                    {
                        id_colaborador = dr.GetInt32(0),
                        cedula = dr.GetInt32(1),
                        nombre = dr.GetString(2),
                        telefono = dr.GetInt32(3),
                        fecha_nacimiento = dr.GetDateTime(4),
                        correo = dr.GetString(5),
                        contrasenna = dr.GetString(6),
                        salario = dr.GetInt32(7),
                        rol = dr.GetString(8)
                    };
                    listaColaborador.Add(objeto);
                }
            }
            conexion.Close();
            return listaColaborador;
        }




    }
}
