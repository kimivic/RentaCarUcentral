using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoRentaCar1
{
    public partial class frmSesion : Form
    {
        public frmSesion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();//cierra la pantalla de sesion
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            proyectoRentaCar1 usuario = new proyectoRentaCar1();//se crea un objeto de la clase proyectoRentaCar1
            usuario.validarAlphanumericos(e);//valida que el usuario solo contenga letras y numeros
        
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           





        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            proyectoRentaCar1 contraseña = new proyectoRentaCar1();//evento generico par validar contraseña
            contraseña.validarContrasena(e);//evento generico par validar contraseña
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            sesionClase usuarioUno = new sesionClase();
            RegistroClase usuarioDos = new RegistroClase();
            usuarioUno.Usuario = txtU.Text;
            usuarioUno.Contrasena = txtPass.Text;
            MessageBox.Show("el traido de sesion es " + usuarioUno.Usuario );
            MessageBox.Show(" el usuario traido de registro " + usuarioDos.NombreUsuario);
            MessageBox.Show(" la contraseña traida de sesion es " + usuarioUno.Contrasena);
            MessageBox.Show(" la contraseña traida de registro " + usuarioDos.ContraseñaUsuario);
            
            if (usuarioUno.Usuario == usuarioDos.NombreUsuario && usuarioUno.Contrasena == usuarioDos.ContraseñaUsuario)
            {

                MessageBox.Show(" Bienvenido ");
                Close();

            }
            else  
            {
                MessageBox.Show(" El usuario o contraseña no es correcta! ");
                MessageBox.Show(" Volver a intentarlo ");
                txtU.Clear();
                txtPass.Clear();
            }
        }
    }
}
