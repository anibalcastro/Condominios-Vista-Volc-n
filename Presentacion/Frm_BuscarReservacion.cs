using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_BuscarReservacion : Form
    {
        public Frm_BuscarReservacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador admin = new MenuAdministrador();
            admin.Show();
        }
    }
}
