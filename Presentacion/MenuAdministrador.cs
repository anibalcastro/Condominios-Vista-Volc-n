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
    public partial class MenuAdministrador : Form
    {
        Negocio.nClientes clientes;
        Negocio.nReservas reservas;

        int id_colaborador;

        public MenuAdministrador()
        {
            InitializeComponent();
            clientes = new nClientes();
            reservas = new nReservas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGanancia();
            cargarCantidadClientes();
            cargarReservashoy();
        }

        public void obtenerIDColaborador(int colaborador)
        {
            id_colaborador = colaborador;
        }

        public int retornarIDColaborador()
        {
            return id_colaborador;
        }

        private void cargarCantidadClientes()
        {
            int cliente = clientes.cantidadClientes();
            totalClientes.Text = Convert.ToString(cliente);
        }

        private void cargarGanancia()
        {
            int ganancia = reservas.ganancia();
            this.lblGanancia.Text = "¢" + Convert.ToString(ganancia);

        }

        private void cargarReservashoy()
        {
            int hoy = reservas.entradashoy();
            lblReservasHoy.Text = Convert.ToString(hoy);
        }

        private void pbClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Clientes clientes = new CRUD_Clientes();
            clientes.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Clientes clientes = new CRUD_Clientes();
            clientes.Show();
        }

        private void pbColaboradores_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Colaboradores colaboradores = new CRUD_Colaboradores();
            colaboradores.Show();
        }

        private void lblColaboradores_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Colaboradores colaboradores = new CRUD_Colaboradores();
            colaboradores.Show();
        }

        private void pbGasto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Gastos gastos = new Frm_Gastos();
            gastos.Show();
        }

        private void lblGasto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Gastos gastos = new Frm_Gastos();
            gastos.Show();
        }

        private void lblBuscarReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BuscarReservacion buscar = new Frm_BuscarReservacion();
            
            buscar.Show();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BuscarReservacion buscar = new Frm_BuscarReservacion();
            buscar.Show();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio_Sesion inicio = new Inicio_Sesion();
            inicio.Show();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio_Sesion inicio = new Inicio_Sesion();
            inicio.Show();
        }

        private void pbReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Reportes reportes = new Frm_Reportes();
            reportes.Show();
        }

        private void lblReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Reportes reportes = new Frm_Reportes();
            reportes.Show();
        }

        private void pbReservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Reservas reserva = new CRUD_Reservas();
            reserva.capturarIDColaborador(id_colaborador);
            reserva.Show();
        }

        private void lblReservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Reservas reserva = new CRUD_Reservas();
            reserva.capturarIDColaborador(id_colaborador);
            reserva.Show();
        }

        private void lblHabitaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Habitaciones habitaciones = new CRUD_Habitaciones();
            habitaciones.Show();
        }

        private void pbHabitaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Habitaciones habitaciones = new CRUD_Habitaciones();
            habitaciones.Show();
        }
    }
}
