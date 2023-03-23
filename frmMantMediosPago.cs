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

namespace Proyecto.Mantenimientos
{
    public partial class frmMantMediosPago : Form
    {
        //Código del medio de pago. Valor de un solo carácter y llave primaria en la tabla.
        //Descripción del medio de pago.Solamente debe de aceptar letras y espacios.
        //Para el caso de pagos efectuados por los clientes E es para efectivo y T para uso de tarjeta de crédito o débito.
        string archivo;
        string ruta = @"C:\Users\kimiv\Downloads\Proyecto\Proyecto\Archivos\";


        public frmMantMediosPago()
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

        private void frmMantMediosPago_Load(object sender, EventArgs e)
        {

        }
    }
}
