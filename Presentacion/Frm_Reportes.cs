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
    public partial class Frm_Reportes : Form
    {
        Negocio.nClientes clientes;
        Negocio.nColaboradores colaboradores;
        Negocio.nHabitacion habitacion;
        Negocio.nGastos gastos;
        Negocio.nReservas reservas;

        public Frm_Reportes()
        {
            InitializeComponent();
            clientes = new nClientes();
            colaboradores = new nColaboradores();
            habitacion = new nHabitacion();
            gastos = new nGastos();
            reservas = new nReservas();
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

        private void cargarColaboradores()
        {
            List<ObjColaboradores> lista = colaboradores.leerColaboradores();

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
            this.dtgColaboradores.DataSource = cola;
        } 

        private void cargarClientes()
        {
            List<ObjCliente> lista = clientes.leerClientes();
           
            DataTable cola = new DataTable("Cliente");
            DataColumn columna0 = new DataColumn("ID");
            DataColumn columna1 = new DataColumn("Cédula");
            DataColumn columna2 = new DataColumn("Nombre");
            DataColumn columna3 = new DataColumn("Telefono");
            DataColumn columna4 = new DataColumn("Fecha Nacimiento");
            DataColumn columna5 = new DataColumn("Correo");
            DataColumn columna6 = new DataColumn("País");
            DataColumn columna7 = new DataColumn("Capital");
            DataColumn columna8 = new DataColumn("Idioma");
            DataColumn columna9 = new DataColumn("Moneda");
            DataColumn columna10 = new DataColumn("ISO");
            DataColumn columna11 = new DataColumn("Siglas Continente");
            DataColumn columna12 = new DataColumn("Codigo");

            cola.Columns.Add(columna0);
            cola.Columns.Add(columna1);
            cola.Columns.Add(columna2);
            cola.Columns.Add(columna3);
            cola.Columns.Add(columna4);
            cola.Columns.Add(columna5);
            cola.Columns.Add(columna6);
            cola.Columns.Add(columna7);
            cola.Columns.Add(columna8);
            cola.Columns.Add(columna9);
            cola.Columns.Add(columna10);
            cola.Columns.Add(columna11);
            cola.Columns.Add(columna12);


            for (int x = 0; x < lista.Count; x++)
            {
                cola.Rows.Add(
                    lista[x].id_cliente,
                    lista[x].cedula,
                    lista[x].nombre,
                    lista[x].telefono,
                    lista[x].fecha_nacimiento,
                    lista[x].correo,
                    lista[x].nacionalidad,
                    lista[x].capital_nacion,
                    lista[x].idioma,
                    lista[x].moneda_nacion,
                    lista[x].iso,
                    lista[x].continente,
                    lista[x].codigo_celular);
            }
            this.dtgClientes.DataSource = cola;

        }

        private void cargarHabitacion()
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
            this.dtgHabitacion.DataSource = tabla;

        }

        private void cargarGastoFecha(DateTime desde, DateTime hasta)
        {
            List<ObjGastos> lista = gastos.leerGastosPorFecha(desde,hasta);

            DataTable cola = new DataTable("Cliente");
            DataColumn columna0 = new DataColumn("ID");
            DataColumn columna1 = new DataColumn("Tipo Gasto");
            DataColumn columna2 = new DataColumn("Número Factura");
            DataColumn columna3 = new DataColumn("Monto");
            DataColumn columna4 = new DataColumn("Fecha");

            cola.Columns.Add(columna0);
            cola.Columns.Add(columna1);
            cola.Columns.Add(columna2);
            cola.Columns.Add(columna3);
            cola.Columns.Add(columna4);

            for (int x = 0; x < lista.Count; x++)
            {
                cola.Rows.Add
                    (
                      lista[x].id_gasto,
                      lista[x].tipo_gasto,
                      lista[x].num_factura,
                      lista[x].monto,
                      lista[x].fecha
                    );
            }
            this.dtgGastos.DataSource = cola;

        }

        private void cargarGasto()
        {
            List<ObjGastos> lista = gastos.leerGastos();

            DataTable cola = new DataTable("Cliente");
            DataColumn columna0 = new DataColumn("ID");
            DataColumn columna1 = new DataColumn("Tipo Gasto");
            DataColumn columna2 = new DataColumn("Número Factura");
            DataColumn columna3 = new DataColumn("Monto");
            DataColumn columna4 = new DataColumn("Fecha");
           
            cola.Columns.Add(columna0);
            cola.Columns.Add(columna1);
            cola.Columns.Add(columna2);
            cola.Columns.Add(columna3);
            cola.Columns.Add(columna4);

            for (int x = 0; x < lista.Count; x++)
            {
                cola.Rows.Add
                    (
                      lista[x].id_gasto,
                      lista[x].tipo_gasto,
                      lista[x].num_factura,
                      lista[x].monto,
                      lista[x].fecha
                    );
            }
            this.dtgGastos.DataSource = cola;
        }

        private void cargarChart()
        {
            String[] serie = { "Airbnb", "Expedia","Reserva Directa","Booking.com" };
            int[] cant = reservas.reservasPlataforma().ToArray();

            chReservasPlataforma.Titles.Add("Porcentaje de reservas por plataforma");
            chReservasPlataforma.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;

            for (int x = 0; x < serie.Length; x++)
            {
                // Series seriegf = chart1.Series.Add(serie[x]);
                //seriegf.Label = cant[x].ToString();
                //seriegf.Points.Add(cant[x]);

                chReservasPlataforma.Series["Series1"].Points.AddXY(serie[x], cant[x]);
            }
        }

        private void Frm_Reportes_Load(object sender, EventArgs e)
        {
            this.cargarClientes();
            this.cargarColaboradores();
            this.cargarHabitacion();
            this.cargarGasto();
            this.cargarChart();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;

            this.cargarGastoFecha(desde, hasta);  
        }
    }
}
