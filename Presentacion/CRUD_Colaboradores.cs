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
    public partial class CRUD_Colaboradores : Form
    {
        Negocio.nColaboradores colaborador;
        Objetos.ObjColaboradores objetos;
        int id = 0;
        public CRUD_Colaboradores()
        {
            InitializeComponent();
            colaborador = new nColaboradores();
        }

        public void capturarDatos()
        {
            try
            {
                if (id == 0)
                {
                    objetos = new ObjColaboradores()
                    {
                        cedula = Convert.ToInt32(txtCedula.Text),
                        nombre = txtNombre.Text,
                        telefono = Convert.ToInt32(txtTelefono.Text),
                        fecha_nacimiento = dtFechaNac.Value,
                        correo = txtCorreo.Text,
                        contrasenna = txtContrasenna.Text,
                        salario = Convert.ToInt32(txtSalario.Text),
                        rol = cbRol.SelectedItem.ToString()
                    };
                }
                else
                {
                    objetos = new ObjColaboradores()
                    {
                        id_colaborador = id,
                        cedula = Convert.ToInt32(txtCedula.Text),
                        nombre = txtNombre.Text,
                        telefono = Convert.ToInt32(txtTelefono.Text),
                        fecha_nacimiento = dtFechaNac.Value,
                        correo = txtCorreo.Text,
                        contrasenna = txtContrasenna.Text,
                        salario = Convert.ToInt32(txtSalario.Text),
                        rol = cbRol.SelectedItem.ToString()
                    };
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan espacios por llenar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void AgregarColaborador()
        {
            capturarDatos();
            if (objetos != null)
            {
                
                colaborador.AgregarColaboradores(objetos);
                this.llenarTabla();
                MessageBox.Show("Colaborador Agregado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limpiarCampos();
                objetos = null;
            }
            
        }

        private void limpiarCampos()
        {
            txtContrasenna.Enabled = true;
            txtCedula.Clear();
            txtNombre.Clear();
            txtContrasenna.Clear();
            txtCorreo.Clear();
            txtSalario.Clear();
            txtTelefono.Clear();
            cbRol.SelectedItem = 0;
            dtFechaNac.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        private void llenarTabla()
        {
            List<ObjColaboradores> lista = colaborador.leerColaboradores();

            DataTable cola = new DataTable("Colaborador");
            DataColumn columna0 = new DataColumn("ID");
            DataColumn columna1 = new DataColumn("Cédula");
            DataColumn columna2 = new DataColumn("Nombre");
            DataColumn columna3 = new DataColumn("Telefono");
            DataColumn columna4 = new DataColumn("Fecha Nacimiento");
            DataColumn columna5 = new DataColumn("Correo");
            DataColumn columna7 = new DataColumn("Salario");
            DataColumn columna6 = new DataColumn("Rol");

            cola.Columns.Add(columna0);
            cola.Columns.Add(columna1);
            cola.Columns.Add(columna2);
            cola.Columns.Add(columna3);
            cola.Columns.Add(columna4);
            cola.Columns.Add(columna5);
            cola.Columns.Add(columna7);
            cola.Columns.Add(columna6);


            for (int x = 0; x < lista.Count; x++)
            {
                cola.Rows.Add(
                    lista[x].id_colaborador, 
                    lista[x].cedula, 
                    lista[x].nombre, 
                    lista[x].telefono, 
                    lista[x].fecha_nacimiento,
                    lista[x].correo, 
                    lista[x].salario,
                    lista[x].rol);
            }
            this.dataGridView1.DataSource = cola;
        }

        private void Regresar ()
        {
            this.Hide();
            MenuAdministrador admin = new MenuAdministrador();
            admin.Show();
            this.limpiarCampos();
        }

        private void editar()
        {
            this.capturarDatos();
            if (objetos!= null)
            {
                
                colaborador.EditarColaboradores(objetos);
                MessageBox.Show("Colaborador Editado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.llenarTabla();
                this.limpiarCampos();
                objetos = null;
            }
           
        }

        private void eliminar()
        {
            this.capturarDatos();
            if (objetos != null)
            {
                
                colaborador.EliminarColaboradores(objetos);
                MessageBox.Show("Colaborador Eliminado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.llenarTabla();
                this.limpiarCampos();
                objetos = null;
            }
         }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Regresar();
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            this.Regresar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarColaborador();
        }

        private void pbAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarColaborador();
        }

        private void CRUD_Colaboradores_Load(object sender, EventArgs e)
        {
            this.llenarTabla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.limpiarCampos();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtContrasenna.Enabled = false;
                id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                txtCedula.Text = row.Cells["Cédula"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                cbRol.SelectedItem = row.Cells["Rol"].Value.ToString();
                 DateTime fecha = Convert.ToDateTime( row.Cells["Fecha Nacimiento"].Value.ToString());
                dtFechaNac.Value = fecha;

                txtSalario.Text = row.Cells["Salario"].Value.ToString();
            }
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

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            this.eliminar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarCampos();
        }

        private void pbLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarCampos();
        }
    }
}
