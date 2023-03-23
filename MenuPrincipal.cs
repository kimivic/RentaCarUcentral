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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void prereservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form prereserva = new frmPreReservaVehiculo();

            prereserva.Show();

            this.Hide();



        }

        private void facturarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form facturarReserva = new frmFacturarReserva();

            facturarReserva.Show();

            this.Hide();
        }

        private void catálogoPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoPersonas = new frmMantPersonas();

            catalogoPersonas.Show();

            this.Hide();
        }

        private void catalogoContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoContactos = new frmMantenimientoContactos();

            catalogoContactos.Show();

            this.Hide();
        }

        private void catálogoPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoPerfiles = new frmMantenimientoPerfiles();
            catalogoPerfiles.Show();

            this.Hide();
        }

        private void catálogoClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoClases =  new frmMantenimientoClases();
            catalogoClases.Show();

            this.Hide();
        }

        private void catálogoVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoVehiculos = new frmMantenimientoVehiculos();
            catalogoVehiculos.Show();

            this.Hide();
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form creditos = new Créditos();

            creditos.Show();

            this.Hide();
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form manualUsuario = new frmManualUsuario();
            manualUsuario.Show();

            this.Hide();

        }

        private void iNformesDeEstadoDeReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form reportes = new frmReportes();
            reportes.Show();

            this.Hide();
        }

        private void estadísticaPorCalseDeVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form estadisticaxClaseVehic = new frmEstadClaseVehiculo();
            estadisticaxClaseVehic.Show();

            this.Hide();
        }

        private void estadísticaDeIngresosTotalesPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form estadisticaIngresos = new frmEstadIgresosxMes();
            estadisticaIngresos.Show();

            this.Hide();
        }

        private void catálogoServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoServicios = new frmMantenimientoServicios();
            catalogoServicios.Show();

            this.Hide();
        }

        private void catálogoLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoLocalidades = new frmMantenimientoLocalidades();
            catalogoLocalidades.Show();

            this.Hide();
        }

        private void catálogoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoUsuarios = new frmMantenimientoUSuarios();
            catalogoUsuarios.Show();

            this.Hide();
        }

        private void catalogoMediosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoMedioPago = new frmMediosPago();
            catalogoMedioPago.Show();

            this.Hide();
        }

        private void catálogoEstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoEstados = new frmMantenimientoEstados();
            catalogoEstados.Show();

            this.Hide();

        }

        private void catálogoEstadoDeReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoEstReserva = new frmMantenimientoEstReserva();
            catalogoEstReserva.Show();

            this.Hide();
        }

        private void catálogoReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form catalogoReserva = new frmMantenimientoReserva();
            catalogoReserva.Show();


            this.Hide();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

