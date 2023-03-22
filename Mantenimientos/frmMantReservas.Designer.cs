namespace Proyecto.Mantenimientos
{
    partial class frmMantReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMantPersonas = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.lblLocalidadRecogida = new System.Windows.Forms.Label();
            this.dtpFechaRecogida = new System.Windows.Forms.DateTimePicker();
            this.lblCódReserva = new System.Windows.Forms.Label();
            this.lblFechaRecogida = new System.Windows.Forms.Label();
            this.txtCódReserva = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdadConductor = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.lblLocalidadDevolución = new System.Windows.Forms.Label();
            this.lblFechaDevolución = new System.Windows.Forms.Label();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.lblClaseVehículo = new System.Windows.Forms.Label();
            this.lblEstadoReserva = new System.Windows.Forms.Label();
            this.cmbLocalidadRecogida = new System.Windows.Forms.ComboBox();
            this.cmbLocalidadDevolución = new System.Windows.Forms.ComboBox();
            this.dtpFechaDevolución = new System.Windows.Forms.DateTimePicker();
            this.cmbClaseVehículo = new System.Windows.Forms.ComboBox();
            this.cmbEstadoReserva = new System.Windows.Forms.ComboBox();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMantPersonas
            // 
            this.lstMantPersonas.HideSelection = false;
            this.lstMantPersonas.Location = new System.Drawing.Point(13, 220);
            this.lstMantPersonas.Name = "lstMantPersonas";
            this.lstMantPersonas.Size = new System.Drawing.Size(1002, 166);
            this.lstMantPersonas.TabIndex = 44;
            this.lstMantPersonas.UseCompatibleStateImageBehavior = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(834, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnRegresar.Location = new System.Drawing.Point(647, 392);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 46);
            this.btnRegresar.TabIndex = 42;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnActualizar.Location = new System.Drawing.Point(186, 392);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(146, 46);
            this.btnActualizar.TabIndex = 41;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.cmbMedioPago);
            this.grbDatos.Controls.Add(this.cmbEstadoReserva);
            this.grbDatos.Controls.Add(this.cmbClaseVehículo);
            this.grbDatos.Controls.Add(this.dtpFechaDevolución);
            this.grbDatos.Controls.Add(this.cmbLocalidadDevolución);
            this.grbDatos.Controls.Add(this.cmbLocalidadRecogida);
            this.grbDatos.Controls.Add(this.lblEstadoReserva);
            this.grbDatos.Controls.Add(this.lblClaseVehículo);
            this.grbDatos.Controls.Add(this.lblMedioPago);
            this.grbDatos.Controls.Add(this.lblFechaDevolución);
            this.grbDatos.Controls.Add(this.lblLocalidadDevolución);
            this.grbDatos.Controls.Add(this.lblLocalidadRecogida);
            this.grbDatos.Controls.Add(this.dtpFechaRecogida);
            this.grbDatos.Controls.Add(this.lblCódReserva);
            this.grbDatos.Controls.Add(this.lblFechaRecogida);
            this.grbDatos.Controls.Add(this.txtCódReserva);
            this.grbDatos.Controls.Add(this.btnConsultar);
            this.grbDatos.Controls.Add(this.txtEdad);
            this.grbDatos.Controls.Add(this.lblEdadConductor);
            this.grbDatos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.grbDatos.Location = new System.Drawing.Point(13, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(1002, 202);
            this.grbDatos.TabIndex = 40;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // lblLocalidadRecogida
            // 
            this.lblLocalidadRecogida.AutoSize = true;
            this.lblLocalidadRecogida.Location = new System.Drawing.Point(11, 75);
            this.lblLocalidadRecogida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidadRecogida.Name = "lblLocalidadRecogida";
            this.lblLocalidadRecogida.Size = new System.Drawing.Size(208, 22);
            this.lblLocalidadRecogida.TabIndex = 32;
            this.lblLocalidadRecogida.Text = "Localidad de recogida: ";
            // 
            // dtpFechaRecogida
            // 
            this.dtpFechaRecogida.Location = new System.Drawing.Point(245, 116);
            this.dtpFechaRecogida.Name = "dtpFechaRecogida";
            this.dtpFechaRecogida.Size = new System.Drawing.Size(253, 29);
            this.dtpFechaRecogida.TabIndex = 28;
            // 
            // lblCódReserva
            // 
            this.lblCódReserva.AutoSize = true;
            this.lblCódReserva.Location = new System.Drawing.Point(11, 30);
            this.lblCódReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódReserva.Name = "lblCódReserva";
            this.lblCódReserva.Size = new System.Drawing.Size(191, 22);
            this.lblCódReserva.TabIndex = 29;
            this.lblCódReserva.Text = "Código de la reserva:";
            // 
            // lblFechaRecogida
            // 
            this.lblFechaRecogida.AutoSize = true;
            this.lblFechaRecogida.Location = new System.Drawing.Point(11, 116);
            this.lblFechaRecogida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaRecogida.Name = "lblFechaRecogida";
            this.lblFechaRecogida.Size = new System.Drawing.Size(174, 22);
            this.lblFechaRecogida.TabIndex = 22;
            this.lblFechaRecogida.Text = "Fecha de recogida:";
            // 
            // txtCódReserva
            // 
            this.txtCódReserva.Location = new System.Drawing.Point(245, 27);
            this.txtCódReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtCódReserva.Name = "txtCódReserva";
            this.txtCódReserva.Size = new System.Drawing.Size(253, 29);
            this.txtCódReserva.TabIndex = 30;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(513, 18);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(155, 38);
            this.btnConsultar.TabIndex = 31;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(173, 158);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(46, 29);
            this.txtEdad.TabIndex = 27;
            // 
            // lblEdadConductor
            // 
            this.lblEdadConductor.AutoSize = true;
            this.lblEdadConductor.Location = new System.Drawing.Point(11, 160);
            this.lblEdadConductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdadConductor.Name = "lblEdadConductor";
            this.lblEdadConductor.Size = new System.Drawing.Size(149, 22);
            this.lblEdadConductor.TabIndex = 25;
            this.lblEdadConductor.Text = "Edad conductor:";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnCrear.Location = new System.Drawing.Point(21, 392);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(146, 46);
            this.btnCrear.TabIndex = 39;
            this.btnCrear.Text = "Crear registro";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(461, 159);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 22);
            this.txtNombre.TabIndex = 38;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnInhabilitar.Location = new System.Drawing.Point(337, 392);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(146, 46);
            this.btnInhabilitar.TabIndex = 53;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            // 
            // lblLocalidadDevolución
            // 
            this.lblLocalidadDevolución.AutoSize = true;
            this.lblLocalidadDevolución.Location = new System.Drawing.Point(505, 75);
            this.lblLocalidadDevolución.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidadDevolución.Name = "lblLocalidadDevolución";
            this.lblLocalidadDevolución.Size = new System.Drawing.Size(220, 22);
            this.lblLocalidadDevolución.TabIndex = 34;
            this.lblLocalidadDevolución.Text = "Localidad de devolución:";
            // 
            // lblFechaDevolución
            // 
            this.lblFechaDevolución.AutoSize = true;
            this.lblFechaDevolución.Location = new System.Drawing.Point(512, 121);
            this.lblFechaDevolución.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDevolución.Name = "lblFechaDevolución";
            this.lblFechaDevolución.Size = new System.Drawing.Size(191, 22);
            this.lblFechaDevolución.TabIndex = 35;
            this.lblFechaDevolución.Text = "Fecha de devolución:";
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Location = new System.Drawing.Point(583, 161);
            this.lblMedioPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(142, 22);
            this.lblMedioPago.TabIndex = 36;
            this.lblMedioPago.Text = "Medio de pago:";
            // 
            // lblClaseVehículo
            // 
            this.lblClaseVehículo.AutoSize = true;
            this.lblClaseVehículo.Location = new System.Drawing.Point(241, 161);
            this.lblClaseVehículo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClaseVehículo.Name = "lblClaseVehículo";
            this.lblClaseVehículo.Size = new System.Drawing.Size(171, 22);
            this.lblClaseVehículo.TabIndex = 37;
            this.lblClaseVehículo.Text = "Clase del vehículo:";
            // 
            // lblEstadoReserva
            // 
            this.lblEstadoReserva.AutoSize = true;
            this.lblEstadoReserva.Location = new System.Drawing.Point(675, 30);
            this.lblEstadoReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoReserva.Name = "lblEstadoReserva";
            this.lblEstadoReserva.Size = new System.Drawing.Size(189, 22);
            this.lblEstadoReserva.TabIndex = 38;
            this.lblEstadoReserva.Text = "Estado de la reserva:";
            // 
            // cmbLocalidadRecogida
            // 
            this.cmbLocalidadRecogida.FormattingEnabled = true;
            this.cmbLocalidadRecogida.Location = new System.Drawing.Point(245, 72);
            this.cmbLocalidadRecogida.Name = "cmbLocalidadRecogida";
            this.cmbLocalidadRecogida.Size = new System.Drawing.Size(253, 30);
            this.cmbLocalidadRecogida.TabIndex = 39;
            // 
            // cmbLocalidadDevolución
            // 
            this.cmbLocalidadDevolución.FormattingEnabled = true;
            this.cmbLocalidadDevolución.Location = new System.Drawing.Point(732, 72);
            this.cmbLocalidadDevolución.Name = "cmbLocalidadDevolución";
            this.cmbLocalidadDevolución.Size = new System.Drawing.Size(253, 30);
            this.cmbLocalidadDevolución.TabIndex = 40;
            // 
            // dtpFechaDevolución
            // 
            this.dtpFechaDevolución.Location = new System.Drawing.Point(732, 116);
            this.dtpFechaDevolución.Name = "dtpFechaDevolución";
            this.dtpFechaDevolución.Size = new System.Drawing.Size(253, 29);
            this.dtpFechaDevolución.TabIndex = 41;
            // 
            // cmbClaseVehículo
            // 
            this.cmbClaseVehículo.FormattingEnabled = true;
            this.cmbClaseVehículo.Location = new System.Drawing.Point(419, 157);
            this.cmbClaseVehículo.Name = "cmbClaseVehículo";
            this.cmbClaseVehículo.Size = new System.Drawing.Size(111, 30);
            this.cmbClaseVehículo.TabIndex = 43;
            // 
            // cmbEstadoReserva
            // 
            this.cmbEstadoReserva.FormattingEnabled = true;
            this.cmbEstadoReserva.Location = new System.Drawing.Point(871, 30);
            this.cmbEstadoReserva.Name = "cmbEstadoReserva";
            this.cmbEstadoReserva.Size = new System.Drawing.Size(111, 30);
            this.cmbEstadoReserva.TabIndex = 44;
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(732, 153);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(250, 30);
            this.cmbMedioPago.TabIndex = 45;
            // 
            // frmMantReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.lstMantPersonas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmMantReservas";
            this.Text = "MANTENIMIENTO DE RESERVAS";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstMantPersonas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label lblLocalidadRecogida;
        private System.Windows.Forms.DateTimePicker dtpFechaRecogida;
        private System.Windows.Forms.Label lblCódReserva;
        private System.Windows.Forms.Label lblFechaRecogida;
        private System.Windows.Forms.TextBox txtCódReserva;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdadConductor;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolución;
        private System.Windows.Forms.ComboBox cmbLocalidadDevolución;
        private System.Windows.Forms.ComboBox cmbLocalidadRecogida;
        private System.Windows.Forms.Label lblEstadoReserva;
        private System.Windows.Forms.Label lblClaseVehículo;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.Label lblFechaDevolución;
        private System.Windows.Forms.Label lblLocalidadDevolución;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.ComboBox cmbEstadoReserva;
        private System.Windows.Forms.ComboBox cmbClaseVehículo;
    }
}