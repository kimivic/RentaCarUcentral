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
    public partial class frmManualUsuario : Form
    {
        public frmManualUsuario()
        {
            InitializeComponent();
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

        private void imgManual_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Manual\ManualUsuario.pdf");
        }
    }
}
