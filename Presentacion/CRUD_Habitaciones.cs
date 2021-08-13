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
    public partial class CRUD_Habitaciones : Form
    {
        ObjHabitacion objeto;
        Negocio.nHabitacion habitacion;
        int id_habitacion = 0;
        
        public CRUD_Habitaciones()
        {
            InitializeComponent();
            habitacion = new nHabitacion();
        }
        
        public void capturarDatos()
        {
            try
            {
                if (id_habitacion == 0)
                {
                    objeto = new ObjHabitacion()
                    {
                        nombre_habitacion = txtNombre.Text,
                        estado = cbEstado.SelectedItem.ToString(),
                        num_piso = cbNumPiso.SelectedItem.ToString(),
                        max_personas = Convert.ToInt32(txtCantPersonas.Value.ToString())
                    };
                }
                else
                {
                    objeto = new ObjHabitacion()
                    {
                        id_habitacion = id_habitacion,
                        nombre_habitacion = txtNombre.Text,
                        estado = cbEstado.SelectedItem.ToString(),
                        num_piso = cbNumPiso.SelectedItem.ToString(),
                        max_personas = Convert.ToInt32(txtCantPersonas.Value.ToString())
                    };
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Faltan espacios por llenar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador administrador = new MenuAdministrador();
            administrador.Show();
        }
        
        private void limpiar()
        {
            this.txtNombre.Clear();
            cbEstado.SelectedItem = 1;
            cbNumPiso.SelectedItem = 1;
            txtCantPersonas.Value = 1;
        }
        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador administrador = new MenuAdministrador();
            administrador.Show();
        }
        
        private void agregarHabitacion()
        {
            this.capturarDatos();

            if (objeto != null)
            {
                habitacion.AgregarHabitaciones(objeto);
                MessageBox.Show("Habitacion agregada", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limpiar();
                this.llenarTabla();
                objeto = null;
            }
            
        }
        
        private void eliminar()
        {
            this.capturarDatos();
           
            if (objeto!=null)
            {
                habitacion.EliminarHabitacion(objeto);
                MessageBox.Show("Habitacion Eliminada", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limpiar();
                this.llenarTabla();
                objeto = null;
            }

        }
        
        private void editar()
        {
            this.capturarDatos();

            if (objeto!=null)
            {
                habitacion.EditarHabitaciones(objeto);
                MessageBox.Show("Habitacion Modificada", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limpiar();
                this.llenarTabla();
                objeto = null;
            }

        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.agregarHabitacion();
        }
        
        private void pbAgregar_Click(object sender, EventArgs e)
        {
            this.agregarHabitacion();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id_habitacion = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                txtNombre.Text = row.Cells["Nombre Habitacion"].Value.ToString();
                txtCantPersonas.Value = Convert.ToInt32(row.Cells["Máximo Personas"].Value.ToString());
                cbNumPiso.SelectedItem = row.Cells["Piso"].Value.ToString();
                cbEstado.SelectedItem = row.Cells["Estado"].Value.ToString();
            }
        }
       
        private void llenarTabla()
        {
            List<ObjHabitacion> lista = habitacion.ListaHabitaciones();

            DataTable tabla = new DataTable("Habitaciones");
            DataColumn columna0 = new DataColumn("ID");
            DataColumn columna1 = new DataColumn("Nombre Habitacion");
            DataColumn columna2 = new DataColumn("Máximo Personas");
            DataColumn columna3 = new DataColumn("Piso");
            DataColumn columna4 = new DataColumn("Estado");


            tabla.Columns.Add(columna0);
            tabla.Columns.Add(columna1);
            tabla.Columns.Add(columna2);
            tabla.Columns.Add(columna3);
            tabla.Columns.Add(columna4);
           


            for (int x = 0; x < lista.Count; x++)
            {
                tabla.Rows.Add(
                    lista[x].id_habitacion,
                    lista[x].nombre_habitacion,
                    lista[x].max_personas,
                    lista[x].num_piso,
                    lista[x].estado);
            }
            this.dataGridView1.DataSource = tabla;
        }

        private void CRUD_Habitaciones_Load(object sender, EventArgs e)
        {
            this.llenarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.editar();
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            this.editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.eliminar();
        }

        private void pbElimnar_Click(object sender, EventArgs e)
        {
            this.eliminar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void pbLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }
    }
}
