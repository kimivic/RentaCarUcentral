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
    public partial class frmMantenimientoContactos : Form
    {
        //Cedula, DNI o Pasaporte. Valor alfanumérico y llave primaria en la tabla.
        //Correo electrónico.Valor alfanumérico.
        //Número de contacto.Solo se debe de aceptar números y paréntesis para código de país.

        string archivo;
        string ruta = @"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Archivos\";

        public frmMantenimientoContactos()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FileStream flujo; // para decir que concete la memoria con el disco duro

            //Variables
            archivo = "Contactos.txt";

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

            StreamWriter escribir = new StreamWriter(ruta + archivo, true); // el true hace que grabe registro por registro

            try
            {
                if (File.Exists(ruta + archivo))
                {
                    if (txtIdentificación.Text.Equals("") || txtCorreo.Text.Equals("") || txtTeléfono.Text.Equals(""))
                    {
                        MessageBox.Show("Datos  incompletos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIdentificación.Focus();
                    }
                    else
                    {
                        escribir.WriteLine(txtIdentificación.Text + "," + txtCorreo.Text + "," + txtTeléfono.Text);
                        escribir.Close();

                        MessageBox.Show("Datos del perro guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                StreamWriter escribir = new StreamWriter(ruta + archivo, true); // el true hace que grabe registro por registro

                if (File.Exists(ruta + archivo))
                {       // si no cumple estas condiciones 
                    if (txtIdentificación.Text.Equals("") || txtCorreo.Text.Equals("") || txtTeléfono.Text.Equals(""))
                    {
                        MessageBox.Show("Datos incompletos completos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIdentificación.Focus();
                    }
                    else
                    {
                        escribir.WriteLine(txtIdentificación.Text + "," + txtCorreo.Text + "," + txtTeléfono.Text);
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

            if (txtIdentificación.Text.Equals("") || txtCorreo.Text.Equals("") || txtTeléfono.Text.Equals(""))
            {
                MessageBox.Show("ingresar datos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdentificación.Focus();

            }
            else
            {
                while (leer.Peek() != -1) // vamos a hacer la lectura de la linea
                {
                    linea = leer.ReadLine();

                    string[] separador = linea.Split(',');

                    if (separador[0] != txtIdentificación.Text || separador[1] != txtCorreo.Text || separador[2] != txtTeléfono.Text)
                    {
                        escribir.WriteLine(linea);
                    }
                }
                MessageBox.Show("Registro inhabilitado satisfactoriamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                leer.Close();
                escribir.Close();

                File.Delete(ruta + archivo);
                File.Move(ruta + archivoTemporal, ruta + archivo);

                leerArchivo();
            }
        }

        public void cargarListView()
        {
            lsvMantServicios.Clear();
            lsvMantServicios.Columns.Add("IDENTIFICACION").Width = 100;
            lsvMantServicios.Columns.Add("CORREO").Width = 100;
            lsvMantServicios.Columns.Add("TELEFONO").Width = 50;

        }
        public void leerArchivo()
        {

            try
            {
                StreamReader leer = new StreamReader(ruta + archivo);

                string identificacion, correo, telefono;

                cargarListView();

                while (leer.Peek() != -1) //.pkeek trae ultima l[inea
                {
                    string linea = leer.ReadLine();
                    string[] separador = linea.Split(',');

                    identificacion = separador[0];
                    correo = separador[1];
                    telefono = separador[2];

                    if (string.IsNullOrEmpty(linea))
                    {
                        continue;
                    }

                    lsvMantServicios.Items.Add(identificacion);
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


        private void frmMantenimientoContactos_Load(object sender, EventArgs e)
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
    }
}
