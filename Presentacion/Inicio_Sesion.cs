using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Objetos;

namespace Presentacion
{
    public partial class Inicio_Sesion : Form
    {
        Negocio.nColaboradores colaborador;
        public Inicio_Sesion()
        {
            InitializeComponent();
            colaborador = new nColaboradores();
        }



        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(this.txtCedula.Text);
            string contrasenna = this.txtContrasenna.Text;

            string rol = colaborador.validarExistencia(cedula, contrasenna);

            if (rol.Equals("Administrador"))
            {
                int id = colaborador.retornarIDColaborador();
                this.Hide();
                MenuAdministrador admin = new MenuAdministrador();
                admin.Show();
                admin.obtenerIDColaborador(id);

                MessageBox.Show("Bienvenido", "BIENVENIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rol.Equals("Recepcionista"))
            {
                MessageBox.Show("Opción inactiva", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error usuario no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
