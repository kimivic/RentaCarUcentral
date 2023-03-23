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
    public partial class frmPreReservaVehiculo : Form
    {
        //Código de la reserva. Valor numérico consecutivo y llave primaria compartida en la tabla.
        //Código del servicio adicional que desea el cliente.Valor numérico.
        //Cedula, DNI o Pasaporte.Valor alfanumérico y llave primaria compartida en la tabla
        //Código de la localidad de recogida. Valor numérico.
        //Código de la localidad de devolución. Valor.
        //Fecha de recogida.Valor hora fecha con formato DD/MM/YYYY HH:MM: SS.
        //Fecha de devolución.Valor hora fecha con formato DD/MM/YYYY HH:MM: SS.
        //Edad de conductor.Valor numérico.
        //Código de clase del vehículo.Valor de un solo carácter.
        //Código del estado de la reserva. Valor numérico y llave primaria en la tabla.
        //Código del medio de pago.Valor de un solo carácter.

        //Para la edad del conductor se efectuará un cálculo con la fecha de nacimiento del registro al día de la reserva.
        //El código de la clase de vehículo define el costo por día de la reserva, según las fechas seleccionadas por el cliente, este cálculo se debe de realizar.

        //Una vez creada la cuenta de usuario podrá indicar la localidad de recogida, para este caso solamente será el Aeropuerto Internacional Juan Santamaría y las localidades de
       
//devolución serán las que se indicaron en el apartado localidades.Si el vehículo se deja en otra localidad que no sea el aeropuerto, esto tendrá un cargo por $200 en la reserva.
//De no estar de acuerdo el cliente con el cobro de la multa, podrá retornar a seleccionar la localidad aeropuerto antes de continuar con el proceso.
//Deberá colocar tanto la fecha como la hora de recogida, de igual manera la fecha y hora de devolución, esto indicará la cantidad de días de alquiler. Así también la clase de vehículo a alquilar.
//Acá el dato de edad es muy importante, ya que, a partir de un cálculo con la fecha de nacimiento, se dará trazabilidad a la reserva. De ser menor de 18 años, el sistema deberá mostrar una alerta y no continuar con el proceso, caso contrario remitirá la pre-reserva al catálogo.La reserva quedará en un estado pendiente a la espera que sea tramitada por perfil Mostrador.
//Superando ese paso, la reserva podrá tener agregación de servicios (GPS, silla, asistencia) para así, finalizar la pre-reserva.
//De no estar de acuerdo el cliente con el servicio o querer agregar otro, podrá retornar a seleccionarlo antes de continuar con el proceso.
//Por último, se debe de mostrar un previo de las escogencias del cliente antes del finalizar el proceso, de querer realizar un cambio, podrá retornar para efectuarlo.


        public frmPreReservaVehiculo()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void frmPreReservaVehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
