using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Proyecto
{
    public partial class frmEstadIgresosxMes : Form
    {
//        podrá consultar ingresos por monto de alquileres mensuales, es decir el usuario podrá indicar el mes y el año a consultar.
        public frmEstadIgresosxMes()
        {
            InitializeComponent();
        }

        private void imgEstadística_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Estadisticas\Estadistica_ingresos_x_mes.xlsx");
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

        private void frmEstadIgresosxMes_Load(object sender, EventArgs e)
        {

        }
    }
}
