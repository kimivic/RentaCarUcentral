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
    public partial class frmMantenimientoVehiculos : Form
    {
        //Código de clase. Valor numérico y llave primaria compartida en la tabla.
        //Placa del vehículo.Valor alfanumérico y llave primaria compartida en la tabla.
        //Marca.Solamente debe de aceptar letras y espacios.
        //Modelo.Solamente debe de aceptar letras y espacios.
        //Transmisión.Valor de un solo carácter.
        //Capacidad de pasajeros.Valor numérico.
        //Capacidad de puertas.Valor numérico.
        //Capacidad de maletas.Valor numérico.
        //Para el caso de la transmisión M es para manual y A para automático.
        
        
        string archivo;
        string ruta = @"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Archivos\";

        public frmMantenimientoVehiculos()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FileStream flujo; // para decir que concete la memoria con el disco duro

            //Variables
            archivo = "MantVehiculos.txt";

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

        private void grbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void lstMantVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMantenimientoVehiculos_Load(object sender, EventArgs e)
        {

        }
    }
}
