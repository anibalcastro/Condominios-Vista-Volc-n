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
    public partial class CRUD_Clientes : Form
    {
        Objetos.ObjCliente objeto;
        Negocio.nClientes cliente;
   
        int id_cliente;
        int id_colaborador;
        string imagen;
        string capital;
        string iso;
        string moneda;
        string continente;
        string codigo_celular;
        string idioma;


        List<string> lista_paises = new List<string>();
        List<string> lista_moneda = new List<string>();
        List<string> lista_capital = new List<string>();
        List<string> lista_bandera = new List<string>();
        List<string> lista_codigo_cel = new List<string>();
        List<string> lista_continente = new List<string>();
        List<string> lista_iso = new List<string>();
        List<string> lista_lengua = new List<string>();

        public CRUD_Clientes()
        {
            InitializeComponent();
            cliente = new nClientes();
        }
        public void obtenerIDColaborador(int colaborador)
        {
            id_colaborador = colaborador;
        }

        public int retornarIDColaborador()
        {
            return id_colaborador;
        }

        private void capturarDatos()
        {
            try
            {
                this.obtenerContinente();
                this.obtenerMoneda();

                if (id_cliente== 0)
                {
                    objeto = new ObjCliente()
                    {
                        nombre = txtNombre.Text,
                        cedula = Convert.ToInt32(txtCedula.Text),
                        telefono = txtTelefono.Text,
                        correo = txtCorreo.Text,
                        fecha_nacimiento = dtFechaNacimiento.Value,
                        nacionalidad = cbNacionalidad.SelectedItem.ToString(),
                        moneda_nacion = moneda,
                        capital_nacion = capital,
                        idioma = idioma,
                        iso = iso,
                        codigo_celular = codigo_celular,
                        continente = continente
                    };
                }
                else
                {
                    objeto = new ObjCliente()
                    {
                        id_cliente = id_cliente,
                        nombre = txtNombre.Text,
                        cedula = Convert.ToInt32(txtCedula.Text),
                        telefono = txtTelefono.Text,
                        correo = txtCorreo.Text,
                        fecha_nacimiento = dtFechaNacimiento.Value,
                        nacionalidad = Convert.ToString(cbNacionalidad.SelectedItem.ToString()),
                        moneda_nacion = moneda,
                        capital_nacion = capital,
                        idioma = idioma,
                        iso = iso,
                        codigo_celular = codigo_celular,
                        continente = continente
                    };
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, hay espacios vacios, intentelo de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarCliente()
        {
            this.capturarDatos();

            if (objeto!= null)
            {
                cliente.AgregarClientes(objeto);
                this.limpiar();
                this.cargarTabla();
                MessageBox.Show("Cliente agregado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objeto = null;
            }
        }

        private void EditarCliente()
        {
            this.capturarDatos();

            if (objeto != null)
            {
                cliente.ModificarClientes(objeto);
                this.limpiar();
                this.cargarTabla();
                MessageBox.Show("Cliente modificado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objeto = null;
            }
        }

        private void eliminarCliente()
        {
            this.capturarDatos();

            if (objeto != null)
            {
                cliente.EliminarClientes(objeto);
                this.limpiar();
                this.cargarTabla();
                MessageBox.Show("Cliente eliminado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objeto = null;
            }
        }  
        
        private void cargarTabla()
        {
            List<ObjCliente> lista = cliente.leerClientes();

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
            DataColumn columna11= new DataColumn("Siglas Continente");
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
            this.dtg.DataSource = cola;
        }

        private void limpiar()
        {
            this.txtCedula.Clear();
            this.txtNombre.Clear();
            this.txtCorreo.Clear();
            this.txtTelefono.Clear();
            this.dtFechaNacimiento.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            this.cbNacionalidad.SelectedItem = 1;
            this.capital = "";
            this.id_cliente = 0;
            this.moneda = "";
        }

        private List<string> webServices()
        {
            org.oorsprong.webservices.tCountryInfo[] ws = 
                new org.oorsprong.webservices.CountryInfoService().FullCountryInfoAllCountries();

            for (int i = 0; i < ws.Length; i++)
            {
                string country = ws[i].sName;
                string money = ws[i].sCurrencyISOCode;
                string capi = ws[i].sCapitalCity;
                string codigo_telefono = ws[i].sPhoneCode;
                string continente_codigo = ws[i].sContinentCode;
                string iso = ws[i].sISOCode;
                string bandera = ws[i].sCountryFlag;


                lista_paises.Add(country);
                lista_moneda.Add(money);
                lista_capital.Add(capi);
                lista_codigo_cel.Add(codigo_telefono);
                lista_continente.Add(continente_codigo);
                lista_bandera.Add(bandera);
                lista_iso.Add(iso);
            }

            return lista_paises;
        }

        private void obtenerLenguage()
        {
            org.oorsprong.webservices.tLanguage[] lenguage =
               new org.oorsprong.webservices.CountryInfoService().ListOfLanguagesByName();

            for (int i = 0; i < lenguage.Length; i++)
            {
                string lengua = lenguage[i].sName;
                lista_lengua.Add(lengua);
            }
        }

        private void obtenerContinente()
        {
            org.oorsprong.webservices.tContinent[] wsContinente =
               new org.oorsprong.webservices.CountryInfoService().ListOfContinentsByCode();

            for (int i = 0; i < wsContinente.Length; i++)
            {
                if (continente.Equals(wsContinente[i].sCode))
                {
                    continente = continente + "- " + wsContinente[i].sName;
                    break;
                }
            }
        }

        private void obtenerMoneda()
        {
            org.oorsprong.webservices.tCurrency[] wsMoneda =
               new org.oorsprong.webservices.CountryInfoService().ListOfCurrenciesByName();

            for (int i = 0; i < wsMoneda.Length; i++)
            {
                
                if (moneda.Equals(wsMoneda[i].sISOCode))
                {
                    moneda = moneda + "- " + wsMoneda[i].sName;
                    break;
                }
                
            }
        }

        private void cargarLenguage()
        {
            this.obtenerLenguage();
            for (int i = 0; i < lista_lengua.Count; i++)
            {
                cbLenguage.Items.Add(lista_lengua[i]);
            }
        }

        private void cargarPaises()
        {
            List<string> paises = this.webServices();

            for (int i = 0; i < paises.Count; i++)
            {
                cbNacionalidad.Items.Add(paises[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador admin = new MenuAdministrador();
            admin.obtenerIDColaborador(id_colaborador);
            admin.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador admin = new MenuAdministrador();
            admin.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg.Rows[e.RowIndex];
                id_cliente = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtCedula.Text = row.Cells["Cédula"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                cbNacionalidad.SelectedItem = row.Cells["País"].Value.ToString();
                cbLenguage.SelectedItem = row.Cells["Idioma"].Value.ToString();
                dtFechaNacimiento.Value = Convert.ToDateTime(row.Cells["Fecha Nacimiento"].Value.ToString());

            }
        }

        private void CRUD_Clientes_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
            this.cargarPaises();
            this.cargarLenguage();
            
            
        }

        private void cbNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pais = cbNacionalidad.SelectedItem.ToString();

            for (int i = 0; i < lista_paises.Count; i++)
            {
                if (lista_paises[i].Equals(pais))
                {
                    imagen = lista_bandera[i];
                    iso = lista_iso[i];
                    capital = lista_capital[i];
                    moneda = lista_moneda[i];
                    continente = lista_continente[i];
                    codigo_celular = "+" + lista_codigo_cel[i];
                    break;
                }
            }
            bandera.ImageLocation = @imagen;

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarCliente();
        }

        private void pbAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarCliente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.EditarCliente();
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            this.EditarCliente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.eliminarCliente();
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            this.eliminarCliente();
        }

        private void pbLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void cbLenguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            idioma = cbLenguage.SelectedItem.ToString();
        }
    }
}
