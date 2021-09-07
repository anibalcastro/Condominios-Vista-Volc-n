using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objetos;
using Negocio;

namespace Presentacion
{
    public partial class FrmIngreso : Form
    {
        ObjIngresos objeto;
        Negocio.nIngreso negocio;
        int id_colaborador; 

        public FrmIngreso()
        {
            InitializeComponent();
            negocio = new nIngreso();
        }

        public void capturarDatos()
        {
            try
            {
                objeto = new ObjIngresos()
                {
                    moneda = cbTipoMoneda.SelectedItem.ToString(),
                    monto = Convert.ToDecimal(txtCantidad.Text),
                    descripcion = txtDescripcion.Text,
                    fecha = DateTime.Now
                };
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR FALTAN CAMPOS POR LLENAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                objeto = null;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.capturarDatos();

            if (objeto!=null)
            {
                negocio.agregar(objeto);
                MessageBox.Show("INGRESO AGREGADO", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCantidad.Clear();
                this.txtDescripcion.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador admin = new MenuAdministrador();
            admin.obtenerIDColaborador(id_colaborador);
            admin.Show();
        }

        public void obtenerIDColaborador(int colaborador)
        {
            id_colaborador = colaborador;
        }
    }
}
