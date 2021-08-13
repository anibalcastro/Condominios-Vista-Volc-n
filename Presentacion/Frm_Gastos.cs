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
    public partial class Frm_Gastos : Form
    {
        Objetos.ObjGastos objeto;
        Negocio.nGastos gastos;

        public Frm_Gastos()
        {
            InitializeComponent();
            gastos = new nGastos();
        }

        private void CapturarDatos()
        {
            try
            {
                objeto = new ObjGastos()
                {
                    tipo_gasto = cbTipoGasto.SelectedItem.ToString(),
                    num_factura = Convert.ToInt32(txtNumFactura.Text),
                    monto = Convert.ToInt32(txtMonto.Text),
                    fecha = DateTime.Now.Date
                };
            }
            catch (Exception)
            { 
                MessageBox.Show("Faltan espacios por llenar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
            
        }

        private void limpiar()
        {
            this.cbTipoGasto.SelectedItem = 1;
            this.txtNumFactura.Clear();
            this.txtMonto.Clear();
        }

        private void AgregarGasto()
        {
           this.CapturarDatos();

           if (objeto != null)
           {
             gastos.AgregarGasto(objeto);
             this.limpiar();
             MessageBox.Show("Gasto agregado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
             objeto = null;
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador admin = new MenuAdministrador();
            admin.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador admin = new MenuAdministrador();
            admin.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarGasto();  
        }

        private void pbAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarGasto();
        }
    }
}
