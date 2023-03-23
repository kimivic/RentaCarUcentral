using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto
{
    public partial class Créditos : Form
    {
        // Objetivo de la pantalla: Visualizar los nombres de los desarrolladores del Sistema de renta de vehículos.
        public Créditos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Botón para regresar al menú principal
            Form MenuPrincipal = new frmMenu();
            MenuPrincipal.Show();

            this.Hide();
        }

        private void Créditos_Load(object sender, EventArgs e)
        {

        }
    }
}
