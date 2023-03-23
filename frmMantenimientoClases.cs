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
    public partial class frmMantenimientoClases : Form
    {

      //  Código de clase del vehículo.Valor de un solo carácter y llave primaria en la tabla.
      //  Cilindrada.Valor numérico
      //  Costo del día de alquiler.
      //  Los códigos donde A es económico con cilindradas menores a 1500 cc, B compacto con cilindrada mayor a 1500 cc y C Todo Terreno con 4x4.Los costos se determinan en el análisis al gusto.
        string archivo;
        string ruta = @"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Archivos\";

        public frmMantenimientoClases()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FileStream flujo; // para decir que concete la memoria con el disco duro

            //Variables
            archivo = "Clases.txt";

            try
            {
                Directory.CreateDirectory(ruta);
                flujo = File.Create(ruta + archivo); // 


                StreamWriter escribir = new StreamWriter(ruta + archivo, true); // el true hace que grabe registro por registro
                if (File.Exists(ruta + archivo))
                    {
                        if (cmbCodClase.SelectedItem == null || txtCostoxDía.Text.Equals("") || txtCilindrada.Text.Equals(""))
                        {
                            MessageBox.Show("Datos incompletos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           cmbCodClase.Focus();
                        }
                        else
                        {
                            escribir.WriteLine(cmbCodClase.Text + "," + txtCostoxDía.Text + "," + txtCilindrada.Text);
                            escribir.Close();

                            MessageBox.Show("Datos guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            leerArchivo();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ruta o nombre del archivo no existen", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                    if (cmbCodClase.SelectedItem == null || txtCostoxDía.Text.Equals("") || txtCilindrada.Text.Equals(""))
                    {
                        MessageBox.Show("Datos incompletos completos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbCodClase.Focus();
                    }
                    else
                    {
                        escribir.WriteLine(cmbCodClase.Text + "," + txtCostoxDía.Text + "," + txtCilindrada.Text);
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


        public void cargarListView()
        {
            lsvMantClases.Clear();
            lsvMantClases.Columns.Add("CODIGO DE CLASE").Width = 100;
            lsvMantClases.Columns.Add("COSTO POR DIA").Width = 100;
            lsvMantClases.Columns.Add("CILINDRADA").Width = 50;

        }
        public void leerArchivo()
        {

            try
            {
                StreamReader leer = new StreamReader(ruta + archivo);

                string codigoClase, costoxDia, cilindrada;

                cargarListView();

                while (leer.Peek() != -1) //.pkeek trae ultima l[inea
                {
                    string linea = leer.ReadLine();
                    string[] separador = linea.Split(',');

                    codigoClase = separador[0];
                    costoxDia = separador[1];
                    cilindrada = separador[2];

                    if (string.IsNullOrEmpty(linea))
                    {
                        continue;
                    }

                    lsvMantClases.Items.Add(codigoClase);
                    //lsvMantServicios.Items.Add[lsvMantServicios.Items.Count - 1].SubItems.Add(correo);
                    //lsvMantServicios.Items.Add[lsvMantServicios.Items.Count - 1].SubItems.Add(telefono); 
                }

                leer.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

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

        private void frmMantenimientoClases_Load(object sender, EventArgs e)
        {

        }

        private void btnInhabilitar_Click_1(object sender, EventArgs e)
        {
            string archivoTemporal = "temp.txt";
            string linea;

            StreamReader leer = new StreamReader(ruta + archivo);
            StreamWriter escribir = new StreamWriter(ruta + archivoTemporal);

            if (cmbCodClase.SelectedItem == null || txtCostoxDía.Text.Equals("") || txtCilindrada.Text.Equals(""))
            {
                MessageBox.Show("ingresar datos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCodClase.Focus();

            }
            else
            {
                while (leer.Peek() != -1) // vamos a hacer la lectura de la linea
                {
                    linea = leer.ReadLine();

                    string[] separador = linea.Split(',');

                    if (separador[0] != cmbCodClase.Text || separador[1] != txtCostoxDía.Text || separador[2] != txtCilindrada.Text)
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
    }
}
