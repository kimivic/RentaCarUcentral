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
    public partial class frmReportes : Form
    {
        //Reportes por medio de la generación de informe de estado de las reservas para poder ver las que están Procesadas (facturadas y pagadas), anuladas, pendientes en el día.
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form MenuPrincipal = new frmMenu();
            MenuPrincipal.Show();

            this.Hide();
        }

        private void imgReporte_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Reportes\Estado_reserva.xlsx");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
