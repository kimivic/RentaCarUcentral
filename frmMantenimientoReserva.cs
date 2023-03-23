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
    public partial class frmMantenimientoReserva : Form
    {
        string archivo;
        string ruta = @"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Archivos\";

        public frmMantenimientoReserva()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FileStream flujo; // para decir que concete la memoria con el disco duro

            //Variables
            archivo = "MantReservas.txt";

            try
            {
                Directory.CreateDirectory(ruta);
                flujo = File.Create(ruta + archivo); // 

                MessageBox.Show("Archivo con clases creado", "CREACION DE MANTENIMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void frmMantenimientoReserva_Load(object sender, EventArgs e)
        {

        }

        public void leerArchivo()
        {

            try
            {
                StreamReader leer = new StreamReader(ruta + archivo);

                string codReserva, localidadRecogida, fechaRecogida, edad, claseVehiculo, estadoReserva, localidadDevolucion,fechaDevolucion, medioPago;

                cargarListView();

                while (leer.Peek() != -1) //.pkeek trae ultima l[inea
                {
                    string linea = leer.ReadLine();
                    string[] separador = linea.Split(',');

                    codReserva = separador[0];
                    localidadRecogida = separador[1];
                    fechaRecogida = separador[2];
                    edad = separador[3];
                    claseVehiculo = separador[4];
                    estadoReserva = separador[5];
                    localidadDevolucion = separador[6];
                    fechaDevolucion = separador[7];
                    medioPago = separador[8];

                    if (string.IsNullOrEmpty(linea))
                    {
                        continue;
                    }

                    lsvMantPersonas.Items.Add(codReserva);
                    // lsvMantPersonas.Items.Add[lsvMantServicios.Items.Count - 1].SubItems.Add(descipPerfilUsuario);

                }

                leer.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        public void cargarListView()
        {
            lsvMantPersonas.Clear();
            lsvMantPersonas.Columns.Add("CODIGO RESERVA").Width = 100;
            lsvMantPersonas.Columns.Add("LOCALIDAD RECOGIDA").Width = 100;
            lsvMantPersonas.Columns.Add("FECHA RECOGIDA").Width = 100;
            lsvMantPersonas.Columns.Add("EDAD").Width = 100;
            lsvMantPersonas.Columns.Add("CLASE DE VEHICULO").Width = 100;
            lsvMantPersonas.Columns.Add("ESTADO RESERVA").Width = 100;
            lsvMantPersonas.Columns.Add("LOCALIDAD DEVOLUCION").Width = 100;
            lsvMantPersonas.Columns.Add("FECHA DEVOLUCION").Width = 100;
            lsvMantPersonas.Columns.Add("MEDIO PAGO").Width = 100;
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter escribir = new StreamWriter(ruta + archivo, true); // el true hace que grabe registro por registro

                if (File.Exists(ruta + archivo))
                {
                    if (txtCódReserva.Text.Equals("") || cmbLocalidadRecogida.SelectedItem == null ||dtpFechaRecogida.Text.Equals("") || txtEdad.Text.Equals("") ||cmbClaseVehículo.SelectedItem == null || cmbEstadoReserva.SelectedItem == null || cmbLocalidadDevolución.SelectedItem == null ||dtpFechaDevolución.Text.Equals("") ||   cmbMedioPago.SelectedItem == null)
                    {
                        MessageBox.Show("Datos incompletos completos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCódReserva.Focus();
                    }
                    else
                    {
                        escribir.WriteLine(txtCódReserva.Text + "," + cmbLocalidadRecogida.Text + "," + dtpFechaRecogida.Text + "," + txtEdad.Text + "," + cmbClaseVehículo.Text + "," + cmbEstadoReserva.Text + "," + cmbLocalidadDevolución.Text + "," + dtpFechaDevolución.Text + "," + cmbMedioPago.Text);
                        escribir.Close();

                        MessageBox.Show("Datos del perro guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leerArchivo();
                    }
                }
                else
                {
                    MessageBox.Show("Ruta no existen", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            string archivoTemporal = "temp.txt";
            string linea;

            StreamReader leer = new StreamReader(ruta + archivo);
            StreamWriter escribir = new StreamWriter(ruta + archivoTemporal);

            if (txtCódReserva.Text.Equals("") || cmbLocalidadRecogida.SelectedItem == null || dtpFechaRecogida.Text.Equals("") || txtEdad.Text.Equals("") || cmbClaseVehículo.SelectedItem == null || cmbEstadoReserva.SelectedItem == null || cmbLocalidadDevolución.SelectedItem == null || dtpFechaDevolución.Text.Equals("") || cmbMedioPago.SelectedItem == null)
                {
                MessageBox.Show("ingresar datos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCódReserva.Focus();

            }
            else
            {
                while (leer.Peek() != -1) // vamos a hacer la lectura de la linea
                {
                    linea = leer.ReadLine();

                    string[] separador = linea.Split(',');

                    if (separador[0] != txtCódReserva.Text || separador[1] != cmbLocalidadRecogida.Text || separador[1] != dtpFechaRecogida.Text || separador[1] != txtEdad.Text || separador[1] != cmbClaseVehículo.Text || separador[1] != cmbEstadoReserva.Text || separador[1] != cmbLocalidadDevolución.Text || separador[1] != cmbMedioPago.Text)
                    {
                        escribir.WriteLine(linea);
                    }
                }
                MessageBox.Show("Registro inhabilitado satisfactoriamente", "Inhabilitar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                leer.Close();
                escribir.Close();

                File.Delete(ruta + archivo);
                File.Move(ruta + archivoTemporal, ruta + archivo);

                leerArchivo();
            }

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
