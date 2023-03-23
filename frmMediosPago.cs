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
    public partial class frmMediosPago : Form
    {
        string archivo;
        string ruta = @"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Archivos\";

        public frmMediosPago()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FileStream flujo; // para decir que concete la memoria con el disco duro

            //Variables
            archivo = "MantMedioPago.txt";

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

        public void cargarListView()
        {
            lsvManttMedioPago.Clear();
            lsvManttMedioPago.Columns.Add("CODIGO MEDIO PAGO").Width = 100;
            lsvManttMedioPago.Columns.Add("DESCRIPCION").Width = 100;

        }
        public void leerArchivo()
        {

            try
            {
                StreamReader leer = new StreamReader(ruta + archivo);

                string codigoMedioPago, descripMedioPago;

                cargarListView();

                while (leer.Peek() != -1) //.pkeek trae ultima l[inea
                {
                    string linea = leer.ReadLine();
                    string[] separador = linea.Split(',');

                    codigoMedioPago = separador[0];
                    descripMedioPago = separador[1];
                    

                    if (string.IsNullOrEmpty(linea))
                    {
                        continue;
                    }

                     lsvManttMedioPago.Items.Add(codigoMedioPago);
                    //lsvManttMedioPago.Items.Add[lsvMantServicios.Items.Count - 1].SubItems.Add(correo);
                    //lsvManttMedioPagolsvMantServicios.Items.Add[lsvMantServicios.Items.Count - 1].SubItems.Add(telefono); 
                }

                leer.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter escribir = new StreamWriter(ruta + archivo, true); // el true hace que grabe registro por registro

                if (File.Exists(ruta + archivo))
                {
                    if (txtCódMedioPago.Text.Equals("") || txtDDescripciónMedioPago.Text.Equals(""))
                    {
                        MessageBox.Show("Datos incompletos completos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCódMedioPago.Focus();
                    }
                    else
                    {
                        escribir.WriteLine(txtCódMedioPago.Text + "," + txtDDescripciónMedioPago.Text);
                        escribir.Close();

                        MessageBox.Show("Datos guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leerArchivo();
                    }
                }
                else
                {
                    MessageBox.Show("Ruta no existe", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (txtCódMedioPago.Text.Equals("") || txtDDescripciónMedioPago.Text.Equals(""))
            {
                MessageBox.Show("ingresar datos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCódMedioPago.Focus();

            }
            else
            {
                while (leer.Peek() != -1) // vamos a hacer la lectura de la linea
                {
                    linea = leer.ReadLine();

                    string[] separador = linea.Split(',');

                    if (separador[0] != txtCódMedioPago.Text || separador[1] != txtDDescripciónMedioPago.Text)
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
