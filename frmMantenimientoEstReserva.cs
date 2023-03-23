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
    public partial class frmMantenimientoEstReserva : Form
    {
        //Código del estado de la reserva. Valor numérico y llave primaria en la tabla.
        //Descripción del estado de la reserva.Solamente debe de aceptar letras y espacios.
        //Para el caso de estados de reserva 0 es para pendiente, 1 procesado y 2 para anulada la reserva.
        string archivo;
        string ruta = @"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Archivos\";

        public frmMantenimientoEstReserva()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FileStream flujo; // para decir que concete la memoria con el disco duro

            //Variables
            archivo = "EstadoReservas.txt";

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter escribir = new StreamWriter(ruta + archivo, true); // el true hace que grabe registro por registro

                if (File.Exists(ruta + archivo))
                {
                    if (txtCódEstadoReserva.Text.Equals("") || txtDescripEstadoReserva.Text.Equals(""))
                    {
                        MessageBox.Show("Datos incompletos completos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCódEstadoReserva.Focus();
                    }
                    else
                    {
                        escribir.WriteLine(txtCódEstadoReserva.Text + "," + txtDescripEstadoReserva.Text + ",");
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

            if (txtCódEstadoReserva.Text.Equals("") || txtDescripEstadoReserva.Text.Equals(""))
            {
                MessageBox.Show("ingresar datos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCódEstadoReserva.Focus();

            }
            else
            {
                while (leer.Peek() != -1) // vamos a hacer la lectura de la linea
                {
                    linea = leer.ReadLine();

                    string[] separador = linea.Split(',');

                    if (separador[0] != txtCódEstadoReserva.Text || separador[1] != txtDescripEstadoReserva.Text)
                    {
                        escribir.WriteLine(linea);
                    }
                }
                MessageBox.Show("Registro inhabilitado satisfactoriamente", "INhabilitar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                leer.Close();
                escribir.Close();

                File.Delete(ruta + archivo);
                File.Move(ruta + archivoTemporal, ruta + archivo);

                leerArchivo();
            }
        }
        public void leerArchivo()
        {

            try
            {
                StreamReader leer = new StreamReader(ruta + archivo);

                string codEstadoReserva, descripEstadoReserva;

                cargarListView();

                while (leer.Peek() != -1) //.pkeek trae ultima l[inea
                {
                    string linea = leer.ReadLine();
                    string[] separador = linea.Split(',');

                    codEstadoReserva = separador[0];
                    descripEstadoReserva = separador[1];


                    if (string.IsNullOrEmpty(linea))
                    {
                        continue;
                    }

                    lsvMantEstadoReserva.Items.Add(codEstadoReserva);
                    // lsvMantEstadoReserva.Items.Add[lsvMantServicios.Items.Count - 1].SubItems.Add(correo);
                    //lsvMantEstadoReserva.Items.Add[lsvMantServicios.Items.Count - 1].SubItems.Add(telefono); 
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
            lsvMantEstadoReserva.Clear();
            lsvMantEstadoReserva.Columns.Add("CODIGO DE ESTADO DE LA RESERVA").Width = 100;
            lsvMantEstadoReserva.Columns.Add("DESCRIPCION").Width = 100;
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

        private void frmMantenimientoEstReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
