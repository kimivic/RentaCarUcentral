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
    public partial class frmEstadClaseVehiculo : Form
    {
        //Estadísticas generando por medio de consultas y depositando en contenedores de datos las clases de vehículos más usadas en un período determinado, es decir el usuario podrá indicar el mes y el año a consultar
        public frmEstadClaseVehiculo()
        {
            InitializeComponent();
        }

        private void frmEstadClaseVehiculo_Load(object sender, EventArgs e)
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

        private void imgEstadística_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Estadisticas\Estadistica_clase_vehiculo.xlsx");
        }
    }
}
