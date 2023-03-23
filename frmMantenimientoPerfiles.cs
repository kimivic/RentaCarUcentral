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
    public partial class frmMantenimientoPerfiles : Form
    {
        // Código de perfil de usuario del sistema. Valor numérico y llave primaria en la tabla.
        // Descripción del Perfil.Solamente debe de aceptar letras y espacios.
        // Los códigos donde 1 es administrador, 2 mostrador y 3 cliente.
        string archivo;
        string ruta = @"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Archivos\";

        public frmMantenimientoPerfiles()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FileStream flujo; // para decir que concete la memoria con el disco duro

            //Variables
            archivo = "MantPerfiles.txt";

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
                    if (txtCódPerfilUsaurio.Text.Equals("") || txtDescripciónPerfil.Text.Equals(""))
                    {
                        MessageBox.Show("Datos incompletos completos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCódPerfilUsaurio.Focus();
                    }
                    else
                    {
                        escribir.WriteLine(txtCódPerfilUsaurio.Text + "," + txtDescripciónPerfil.Text + ",");
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

                string codPerfilUsuario, descripPerfilUsuario;

                cargarListView();

                while (leer.Peek() != -1) //.pkeek trae ultima l[inea
                {
                    string linea = leer.ReadLine();
                    string[] separador = linea.Split(',');

                    codPerfilUsuario = separador[0];
                    descripPerfilUsuario = separador[1];


                    if (string.IsNullOrEmpty(linea))
                    {
                        continue;
                    }

                    lsvMantPerfiles.Items.Add(codPerfilUsuario);
                    // lsvMantPerfiles.Items.Add[lsvMantServicios.Items.Count - 1].SubItems.Add(descipPerfilUsuario);
                  
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
            lsvMantPerfiles.Clear();
            lsvMantPerfiles.Columns.Add("CODIGO LOCALIDAD").Width = 100;
            lsvMantPerfiles.Columns.Add("DESCRIPCION").Width = 100;
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

        private void frmMantenimientoPerfiles_Load(object sender, EventArgs e)
        {

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            string archivoTemporal = "temp.txt";
            string linea;

            StreamReader leer = new StreamReader(ruta + archivo);
            StreamWriter escribir = new StreamWriter(ruta + archivoTemporal);

            if (txtCódPerfilUsaurio.Text.Equals("") || txtDescripciónPerfil.Text.Equals(""))
            {
                MessageBox.Show("ingresar datos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCódPerfilUsaurio.Focus();

            }
            else
            {
                while (leer.Peek() != -1) // vamos a hacer la lectura de la linea
                {
                    linea = leer.ReadLine();

                    string[] separador = linea.Split(',');

                    if (separador[0] != txtCódPerfilUsaurio.Text || separador[1] != txtDescripciónPerfil.Text)
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

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            Form MenuPrincipal = new frmMenu();
            MenuPrincipal.Show();

            this.Hide();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
