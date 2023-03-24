using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoRentaCar1
{
    


    internal class proyectoRentaCar1// clase igual que nombre del proyecto, clase padre

    {
  
        public proyectoRentaCar1()
        { // se crea el constructor con el mismo nombre de la clase

        }

        public KeyPressEventArgs validarNumeros(KeyPressEventArgs e) //valida solo numeros


        {

            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (e.KeyChar == ',') { e.Handled = false; }
            else { e.Handled = true; }
            return e;
        }


        
       
        public KeyPressEventArgs validarAlphanumericos(KeyPressEventArgs e) {// por medio del codico ascii solo se permiten numeros y letras

            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122)
            {
                //MessageBox.Show("es permitido");
            }
            else {

                MessageBox.Show(" Solo letras y Numeros son permitios", "Alerta",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled= true;
                return e;
            }
  
            return e;
                
                }

        public KeyPressEventArgs validarContrasena(KeyPressEventArgs e)
        {// por medio del codico ascii solo se permiten numero y letras

            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122)
            {
                //MessageBox.Show("es permitido");
            }
            else
            {

                MessageBox.Show(" Solo letras y Numeros son permitidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return e;
            }

            return e;

        }

        private bool contraseñaSegura(String password) {

            bool mayuscula = false, minuscula = false, numero = false;

            for (int j = 0; j < password.Length; j++) {

                if (Char.IsUpper(password, j))
                {

                    mayuscula = true;
                }
                else if (Char.IsLower(password, j))
                {
                    minuscula = true;
                }
                else if (Char.IsDigit(password, j))
                {
                    minuscula = true;
                }



            }
            if (mayuscula && minuscula && numero && password.Length >= 8 && password.Length <=15) 
            {
                return true;
            
            }
            return false;
        
        }




        

        

    }





}
