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
    public partial class Frm_BuscarReservacion : Form
    {
        nReservas reservas;
        int id;
        int id_colaborador;

        public Frm_BuscarReservacion()
        {
            InitializeComponent();
            reservas = new nReservas();
        }

        public void obtenerIDColaborador(int colaborador)
        {
            id_colaborador = colaborador;
        }

        private void llenarTablaPorFechas(DateTime Desde, DateTime Hasta)
        {
            List<ObjReporteReserva> lista = reservas.buscarPorFecha(Desde,Hasta);

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
            this.dtgPorFecha.DataSource = cola;
        }

        private void llenarTablaPorID()
        {
            List<ObjReporteReserva> lista = reservas.buscarPorID(id);

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
            this.dtgPorNReserva.DataSource = cola;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador admin = new MenuAdministrador();
            admin.obtenerIDColaborador(id_colaborador);
            admin.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(this.txtNumReserva.Text);
            if (id!=null)
            {
                this.llenarTablaPorID();
            }
        }

        private void Frm_BuscarReservacion_Load(object sender, EventArgs e)
        {
            DateTime Desde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime Hasta = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(7);
            
            dtpDesde.Value = Desde;
            dtpHasta.Value = Hasta;

            this.llenarTablaPorFechas(Desde, Hasta);

        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(this.txtNumReserva.Text);
            if (id != null)
            {
                this.llenarTablaPorID();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime Desde = dtpDesde.Value;
            DateTime Hasta = dtpHasta.Value;

            this.llenarTablaPorFechas(Desde, Hasta);
        }

        private void buscar1_Click(object sender, EventArgs e)
        {
            DateTime Desde = dtpDesde.Value;
            DateTime Hasta = dtpHasta.Value;

            this.llenarTablaPorFechas(Desde, Hasta);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador admin = new MenuAdministrador();
            admin.obtenerIDColaborador(id_colaborador);
            admin.Show();
        }
    }
}
