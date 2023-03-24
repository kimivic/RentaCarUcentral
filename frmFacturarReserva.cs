using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmFacturarReserva : Form
    {
        public frmFacturarReserva()
        {
            InitializeComponent();
        }
         // Proceso de facturacion de la reserva 
        private void frmFacturarReserva_Load(object sender, EventArgs e)
        {

        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form MenuPrincipal = new frmMenu();
            MenuPrincipal.Show();

            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
