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
    public partial class CRUD_Reservas : Form
    {
        Negocio.nHabitacion habitacion;
        Negocio.nClientes clientes;
        Negocio.nReservas reservas;
        Negocio.nColaboradores colaborador;
        ObjReservas objeto;

        int id_plataforma;
        int id_reserva;
        int id_colaborador;
        string nombre_colaborador;

        public CRUD_Reservas()
        {
            InitializeComponent();
            habitacion = new nHabitacion();
            clientes = new nClientes();
            reservas = new nReservas();
            colaborador = new nColaboradores();
        }

        public void capturarIDColaborador(int id_empleado)
        {
            id_colaborador = id_empleado;
        }

        private void cargarHabitaciones()
        {
            List<ObjHabitacion> lista = habitacion.ListaHabitaciones();
            cbPropiedad.ValueMember = "id_habitacion";
            cbPropiedad.DisplayMember = "nombre_habitacion";

            cbPropiedad.DataSource = lista;
        }

        private void cargarCliente()
        {
            List<ObjCliente> lista = clientes.leerClientes();
            cbCliente.ValueMember = "id_cliente";
            cbCliente.DisplayMember = "nombre";

            cbCliente.DataSource = lista;
        }

        private void AgregarReserva()
        {
            this.CapturarDatos();

            if (objeto !=null)
            {
                reservas.AgregarReserva(objeto);
                limpiar();
                llenarTabla();
                objeto = null;
                MessageBox.Show("Reserva Agregada", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void EditarReserva()
        {
            this.CapturarDatos();

            if (objeto != null)
            {
                reservas.EditarReserva(objeto);
                limpiar();
                llenarTabla();
                objeto = null;
                MessageBox.Show("Reserva Editada", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void llenarTabla()
        {
            List<ObjReporteReserva> lista = reservas.leerReserva();

            DataTable cola = new DataTable("Reservas");
            DataColumn columna0 = new DataColumn("ID");
            DataColumn columna1 = new DataColumn("Nombre Cliente");
            DataColumn columna2 = new DataColumn("Nombre Colaborador");
            DataColumn columna3 = new DataColumn("Nombre Habitacion");
            DataColumn columna4 = new DataColumn("Entrada");
            DataColumn columna5 = new DataColumn("Salida");
            DataColumn columna6 = new DataColumn("Cantidad Personas");
            DataColumn columna7 = new DataColumn("Nombre Plataforma");
            DataColumn columna8 = new DataColumn("Precio");
           
            cola.Columns.Add(columna0);
            cola.Columns.Add(columna1);
            cola.Columns.Add(columna2);
            cola.Columns.Add(columna3);
            cola.Columns.Add(columna4);
            cola.Columns.Add(columna5);
            cola.Columns.Add(columna6);
            cola.Columns.Add(columna7);
            cola.Columns.Add(columna8);
            


            for (int x = 0; x < lista.Count; x++)
            {
                cola.Rows.Add(
                    lista[x].id_reserva,
                    lista[x].nombre_cliente,
                    lista[x].nombre_colaborador,
                    lista[x].nombre_habitacion,
                    lista[x].entrada,
                    lista[x].salida,
                    lista[x].cantidad_personas,
                    lista[x].nombre_plataforma,
                    lista[x].precio);
            }
            this.dataGridView1.DataSource = cola;
        }

        private void EliminarReserva()
        {
            this.CapturarDatos();

            if (objeto != null)
            {
                reservas.EliminarReserva(objeto);
                limpiar();
                llenarTabla();
                objeto = null;
                MessageBox.Show("Reserva Eliminada", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CapturarDatos()
        {
            try
            {
                this.capturarPlataforma();
                if (id_reserva == 0)
                {
                    objeto = new ObjReservas()
                    {
                        id_cliente = Convert.ToInt32(cbCliente.SelectedValue.ToString()),
                        id_colaborador = id_colaborador,
                        id_plataforma = id_plataforma,
                        id_habitacion = Convert.ToInt32(cbPropiedad.SelectedValue.ToString()),
                        entrada = entrada.Value,
                        salida = salida.Value,
                        cant_personas = Convert.ToInt32(txtCantidadPersonas.Text),
                        precio = Convert.ToInt32(txtPrecio.Text)
                    };
                }
                else
                {
                    objeto = new ObjReservas()
                    {
                        id_reservas = id_reserva,
                        id_cliente = Convert.ToInt32(cbCliente.SelectedValue.ToString()),
                        id_colaborador = id_colaborador,
                        id_plataforma = id_plataforma,
                        id_habitacion = Convert.ToInt32(cbPropiedad.SelectedValue.ToString()),
                        entrada = entrada.Value,
                        salida = salida.Value,
                        cant_personas = Convert.ToInt32(txtCantidadPersonas.Text),
                        precio = Convert.ToInt32(txtPrecio.Text)
                    };
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Faltan campos por llenar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void limpiar()
        {
            this.cbCliente.SelectedItem = 1;
            this.txtCantidadPersonas.Text = "1";
            this.cbPropiedad.SelectedItem = 1;
            booking.Checked = false;
            airbnb.Checked = false;
            directa.Checked = false;
            expedia.Checked = false;
            objeto = null;
            entrada.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            salida.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            id_plataforma = 0;
            id_reserva = 0;
            txtPrecio.Text = "";
        }

        private void capturarPlataforma()
        {
            if (booking.Checked == true)
            {
                id_plataforma = 1;
            }
            else if (directa.Checked == true)
            {
                id_plataforma = 2;
            }
            else if ( airbnb.Checked == true)
            {
                id_plataforma = 3;
            }
            else if (expedia.Checked == true)
            {
                id_plataforma = 4;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador administrador = new MenuAdministrador();
            administrador.obtenerIDColaborador(id_colaborador);
            administrador.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador administrador = new MenuAdministrador();
            administrador.obtenerIDColaborador(id_colaborador);
            administrador.Show();
        }

        private void CRUD_Reservas_Load(object sender, EventArgs e)
        {
            this.llenarTabla();
            this.cargarHabitaciones();
            this.cargarCliente();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cbCliente.SelectedItem = row.Cells["Nombre Cliente"].Value.ToString();
                cbPropiedad.SelectedItem = row.Cells["Nombre Habitacion"].Value.ToString();
                entrada.Value = Convert.ToDateTime(row.Cells["Entrada"].Value.ToString());
                salida.Value = Convert.ToDateTime(row.Cells["Salida"].Value.ToString());
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtCantidadPersonas.Text = row.Cells["Cantidad Personas"].Value.ToString();
                string plataforma = row.Cells["Nombre Plataforma"].Value.ToString();
                nombre_colaborador = row.Cells["Nombre Colaborador"].Value.ToString();
                this.obtenerIDcolaborador(nombre_colaborador);
                id_reserva = Convert.ToInt32(row.Cells["ID"].Value.ToString());

                if (plataforma.Equals("Booking.com"))
                {
                    booking.Checked = true;
                }
                else if (plataforma.Equals("Reserva Directa"))
                {
                    directa.Checked = true;
                }
                else if (plataforma.Equals("Airbnb"))
                {
                    airbnb.Checked = true;
                }
                else
                {
                    expedia.Checked = true;
                }
            }
        }

        public void obtenerIDcolaborador(string nombre)
        {
            List<ObjColaboradores> colaboradores = colaborador.leerColaboradores();

            for (int i = 0; i < colaboradores.Count; i++)
            {
                if (colaboradores[i].nombre.Equals(nombre))
                {
                    id_colaborador = colaboradores[i].id_colaborador;
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarReserva();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.AgregarReserva();
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            this.EditarReserva();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.EditarReserva();
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            this.EliminarReserva();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.EliminarReserva();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void pbLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void entrada_ValueChanged(object sender, EventArgs e)
        {
            DateTime valor = entrada.Value;
            
            salida.Value = valor.AddDays(1);
        }
    }
}
