using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoRentaCar1
{
    public partial class frmRegistro : Form
    {

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombreUsuarioNuevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuarioNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void txtNombreUsuarioNuevo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
            proyectoRentaCar1 validarLetrasYNumeros = new proyectoRentaCar1();
            validarLetrasYNumeros.validarAlphanumericos(e) ;
            



        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            RegistroClase newUser= new RegistroClase();// se crea un objeto de la clase RegistroClase
            newUser.NombreUsuario = txtNomUNew.Text; // se guarda en la variable por medio de constructor NombreUsuario
            newUser.ContraseñaUsuario = txtPassUNew.Text;
            newUser.ContraseñaUsuarioConfirmacion= txtPassUNewConf.Text;


            if (newUser.ContraseñaUsuario != newUser.ContraseñaUsuarioConfirmacion)//si contraseña nueva y confirmacion de contraseña son diferentes, vuelve a pedir la contraseña
            {
                MessageBox.Show("Las contraseñas no son iguales, favor de corregir");
                txtPassUNew.Clear();//vacia la caja de texto PassUNew
                txtPassUNewConf.Clear();//vacia la caja de texto PassUNewConf
            
            }
            else
            {
                //essageBox.Show("usuario creado con éxito " + newUser.NombreUsuario);// prueba de comprobacion de salida
                MessageBox.Show("Usuario creado");// mensaje desplegado en pantalla


                txtNomUNew.Clear(); //vacia la caja de texto txtNomUNew
                txtPassUNew.Clear();//vacia la caja de texto txtPassUNew
                txtPassUNewConf.Clear();//vacia la caja de texto txtPassUNewConf
                Close();//cierra la ventana
            }
        }

        private void txtContraseñaNueva_TextChanged(object sender, EventArgs e)
        {

        
        }

        private void txtContraseñaNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            proyectoRentaCar1 contraseña = new proyectoRentaCar1();//evento generico par validar contraseña
            contraseña.validarContrasena(e);//evento generico par validar contraseña
        }

        private void txtConfirmarContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            proyectoRentaCar1 contraseña = new proyectoRentaCar1();//evento generico par validar contraseña
            contraseña.validarContrasena(e);//evento generico par validar contraseña


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
