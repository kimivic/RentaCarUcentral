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
    public partial class frmMantenimientoLocalidades : Form
    {
        // Código de la localidad.Valor numérico y llave primaria en la tabla.
        // Nombre de la localidad. Solamente debe de aceptar letras y espacios.
        //Actualmente Hertz tiene oficinas en el Aeropuerto Juan Santamaría, San José Downtown, Quepos, Tamarindo, Liberia, Jaco, Uvita.Los códigos se determinan en el análisis al gusto.
        string archivo;
        string ruta = @"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Archivos\";


        public frmMantenimientoLocalidades()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FileStream flujo; // para decir que concete la memoria con el disco duro

            //Variables
            archivo = "MantenimientLocalidades.txt";

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
                    if (txtCódLocalidad.Text.Equals("") || txtNombreLocalidad.Text.Equals(""))
                    {
                        MessageBox.Show("Datos incompletos completos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCódLocalidad.Focus();
                    }
                    else
                    {
                        escribir.WriteLine(txtCódLocalidad.Text + "," + txtNombreLocalidad.Text + ",");
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

        public void leerArchivo()
        {

            try
            {
                StreamReader leer = new StreamReader(ruta + archivo);

                string codLocalidad, descripNombreLocalidad;

                cargarListView();

                while (leer.Peek() != -1) //.pkeek trae ultima l[inea
                {
                    string linea = leer.ReadLine();
                    string[] separador = linea.Split(',');

                    codLocalidad = separador[0];
                    descripNombreLocalidad = separador[1];


                    if (string.IsNullOrEmpty(linea))
                    {
                        continue;
                    }

                    lsvMantLocalidades.Items.Add(codLocalidad);
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
            lsvMantLocalidades.Clear();
            lsvMantLocalidades.Columns.Add("CODIGO LOCALIDAD").Width = 100;
            lsvMantLocalidades.Columns.Add("DESCRIPCION").Width = 100;
        }


        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            string archivoTemporal = "temp.txt";
            string linea;

            StreamReader leer = new StreamReader(ruta + archivo);
            StreamWriter escribir = new StreamWriter(ruta + archivoTemporal);

            if (txtCódLocalidad.Text.Equals("") || txtNombreLocalidad.Text.Equals(""))
            {
                MessageBox.Show("ingresar datos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCódLocalidad.Focus();

            }
            else
            {
                while (leer.Peek() != -1) // vamos a hacer la lectura de la linea
                {
                    linea = leer.ReadLine();

                    string[] separador = linea.Split(',');

                    if (separador[0] != txtCódLocalidad.Text || separador[1] != txtNombreLocalidad.Text)
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

        private void frmMantenimientoLocalidades_Load(object sender, EventArgs e)
        {

        }
    }
}
