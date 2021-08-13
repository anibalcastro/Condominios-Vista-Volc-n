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
    public partial class CRUD_Reservas : Form
    {
        public CRUD_Reservas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador administrador = new MenuAdministrador();
            administrador.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador administrador = new MenuAdministrador();
            administrador.Show();
        }
    }
}
