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
    public partial class frmMantenimientoUSuarios : Form
    {
        //Usuario. Valor alfanumérico y llave primaria compartida en la tabla.
        //Cedula, DNI o Pasaporte.Valor alfanumérico y llave primaria compartida en la tabla
        //Código de perfil de usuario del sistema.Valor numérico.
       // Contraseña.Valor alfanumérico sensible a mayúsculas y minúsculas, debe tener una longitud mínima de 8 caracteres y máxima de 15. De no cumplirse se le debe de indicar al cliente para que ingrese un valor con esas características.
        //Código del estado del usuario del sistema.Valor numérico


       string archivo;
        string ruta = @"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Archivos\";

        public frmMantenimientoUSuarios()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FileStream flujo; // para decir que concete la memoria con el disco duro

            //Variables
            archivo = "MantServicios.txt";

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
            lsvMantUsuarios.Clear();
            lsvMantUsuarios.Columns.Add("CODIGO DE CLASE").Width = 100;
            lsvMantUsuarios.Columns.Add("COSTO POR DIA").Width = 100;
            lsvMantUsuarios.Columns.Add("CILINDRADA").Width = 50;

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

                    lsvMantUsuarios.Items.Add(codigoClase);
                    //lsvMantUsuarios.Items.Add[lsvMantServicios.Items.Count - 1].SubItems.Add(costoxDia);
                    //lsvMantUsuarios.Items.Add[lsvMantServicios.Items.Count - 1].SubItems.Add(cilindrada); 
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
                    if (txtIdentificación.Text.Equals("") || txtUsuario.Text.Equals("") || txtCódEstado.Text.Equals("") || txtContraseña.Text.Equals(""))
                    {
                        MessageBox.Show("Datos incompletos completos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIdentificación.Focus();
                    }
                    else
                    {
                        escribir.WriteLine(txtIdentificación.Text + "," + txtUsuario.Text + "," + txtCódEstado.Text + "," + txtContraseña.Text);
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
