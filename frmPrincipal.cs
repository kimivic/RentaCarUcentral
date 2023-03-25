using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            llamarSesion();//llama al metodo sesion
        }

        public void llamarSesion()//llamada al metodo llamado llamarSesion
        {
            frmSesion sesion = new frmSesion();//crea objeto llamado sesion de la clase llamada frmSesion
            sesion.Show();//despliega en pantalla el formulario llamado sesion

        }

        public void llamarRegistro()
        {
            frmRegistro registro = new frmRegistro();//crea objeto llamado registro de la clase llamada frmRegistro
            registro.Show();//despliega en pantalla el formulario llamado regitro

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            llamarRegistro();//llama al metodo registro
        }
    }
}
