using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Objetos;

namespace Negocio
{
    public class nColaboradores
    {
        List<ObjColaboradores> lista = new Datos.BDColaboradores().leerColaborador();
        int id_colaborador;

        public string validarExistencia(int cedula, string contrasenna)
        {
            string rol = "";
            

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].cedula.Equals(cedula))
                {
                    if (lista[i].contrasenna.Equals(contrasenna))
                    {
                        if (lista[i].rol.Equals("Administrador"))
                        {
                            rol = "Administrador";
                            id_colaborador = lista[i].id_colaborador;
                            break;
                        }
                        else if (lista[i].rol.Equals("Recepcionista"))
                        {
                            rol = "Recepcionista";
                            id_colaborador = lista[i].id_colaborador;
                            break;
                        }
                        else 
                        {
                            rol = "";

                        }

                    }

                    
                }
              
            }

            return rol;
        }

        public int retornarIDColaborador()
        {
            return id_colaborador;
        }

        public void AgregarColaboradores(ObjColaboradores objeto)
        {
            new Datos.BDColaboradores().insertarColaborador(objeto);
        }

        public void EditarColaboradores(ObjColaboradores objeto)
        {
            new Datos.BDColaboradores().modificarColaborador(objeto);
        }

        public void EliminarColaboradores(ObjColaboradores objeto)
        {
            new Datos.BDColaboradores().eliminarColaborador(objeto);
        }
        public List<ObjColaboradores> leerColaboradores ()
        {
            return new Datos.BDColaboradores().leerColaborador();
        }
    }
}
