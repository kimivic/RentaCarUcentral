namespace Proyecto.Mantenimientos
{
    partial class frmMantVehiculos
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtIdentificación = new System.Windows.Forms.TextBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTransmsión = new System.Windows.Forms.Label();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAutomático = new System.Windows.Forms.RadioButton();
            this.lblCapacidadpasajeros = new System.Windows.Forms.Label();
            this.txtCapacidadPasajeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCapacidadMaletas = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lstMantVehiculos = new System.Windows.Forms.ListView();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(829, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnRegresar.Location = new System.Drawing.Point(642, 392);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 46);
            this.btnRegresar.TabIndex = 40;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnActualizar.Location = new System.Drawing.Point(173, 392);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(146, 46);
            this.btnActualizar.TabIndex = 39;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.textBox2);
            this.grbDatos.Controls.Add(this.lblCapacidadMaletas);
            this.grbDatos.Controls.Add(this.textBox1);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.txtCapacidadPasajeros);
            this.grbDatos.Controls.Add(this.lblCapacidadpasajeros);
            this.grbDatos.Controls.Add(this.rbAutomático);
            this.grbDatos.Controls.Add(this.rbManual);
            this.grbDatos.Controls.Add(this.lblTransmsión);
            this.grbDatos.Controls.Add(this.comboBox1);
            this.grbDatos.Controls.Add(this.cmbModelo);
            this.grbDatos.Controls.Add(this.cmbMarca);
            this.grbDatos.Controls.Add(this.btnConsultar);
            this.grbDatos.Controls.Add(this.lblMarca);
            this.grbDatos.Controls.Add(this.lblPlaca);
            this.grbDatos.Controls.Add(this.txtIdentificación);
            this.grbDatos.Controls.Add(this.lblClase);
            this.grbDatos.Controls.Add(this.lblModelo);
            this.grbDatos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.grbDatos.Location = new System.Drawing.Point(8, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(1002, 201);
            this.grbDatos.TabIndex = 38;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(11, 75);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(66, 22);
            this.lblMarca.TabIndex = 32;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(11, 30);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(62, 22);
            this.lblPlaca.TabIndex = 29;
            this.lblPlaca.Text = "Placa:";
            // 
            // txtIdentificación
            // 
            this.txtIdentificación.Location = new System.Drawing.Point(96, 27);
            this.txtIdentificación.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificación.Name = "txtIdentificación";
            this.txtIdentificación.Size = new System.Drawing.Size(253, 29);
            this.txtIdentificación.TabIndex = 30;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(11, 117);
            this.lblClase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(64, 22);
            this.lblClase.TabIndex = 24;
            this.lblClase.Text = "Clase:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(373, 75);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(78, 22);
            this.lblModelo.TabIndex = 25;
            this.lblModelo.Text = "Modelo:";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnCrear.Location = new System.Drawing.Point(8, 392);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(146, 46);
            this.btnCrear.TabIndex = 37;
            this.btnCrear.Text = "Crear registro";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(356, 22);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(155, 38);
            this.btnConsultar.TabIndex = 34;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(96, 72);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(253, 30);
            this.cmbMarca.TabIndex = 35;
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(458, 73);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(253, 30);
            this.cmbModelo.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 30);
            this.comboBox1.TabIndex = 37;
            // 
            // lblTransmsión
            // 
            this.lblTransmsión.AutoSize = true;
            this.lblTransmsión.Location = new System.Drawing.Point(373, 125);
            this.lblTransmsión.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransmsión.Name = "lblTransmsión";
            this.lblTransmsión.Size = new System.Drawing.Size(117, 22);
            this.lblTransmsión.TabIndex = 38;
            this.lblTransmsión.Text = "Transmisión:";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(497, 121);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(90, 26);
            this.rbManual.TabIndex = 39;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbAutomático
            // 
            this.rbAutomático.AutoSize = true;
            this.rbAutomático.Location = new System.Drawing.Point(593, 118);
            this.rbAutomático.Name = "rbAutomático";
            this.rbAutomático.Size = new System.Drawing.Size(126, 26);
            this.rbAutomático.TabIndex = 40;
            this.rbAutomático.TabStop = true;
            this.rbAutomático.Text = "Automático";
            this.rbAutomático.UseVisualStyleBackColor = true;
            // 
            // lblCapacidadpasajeros
            // 
            this.lblCapacidadpasajeros.AutoSize = true;
            this.lblCapacidadpasajeros.Location = new System.Drawing.Point(13, 166);
            this.lblCapacidadpasajeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacidadpasajeros.Name = "lblCapacidadpasajeros";
            this.lblCapacidadpasajeros.Size = new System.Drawing.Size(221, 22);
            this.lblCapacidadpasajeros.TabIndex = 41;
            this.lblCapacidadpasajeros.Text = "Capacidad de pasajeros:";
            // 
            // txtCapacidadPasajeros
            // 
            this.txtCapacidadPasajeros.Location = new System.Drawing.Point(249, 159);
            this.txtCapacidadPasajeros.Name = "txtCapacidadPasajeros";
            this.txtCapacidadPasajeros.Size = new System.Drawing.Size(100, 29);
            this.txtCapacidadPasajeros.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "Puertas:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 44;
            // 
            // lblCapacidadMaletas
            // 
            this.lblCapacidadMaletas.AutoSize = true;
            this.lblCapacidadMaletas.Location = new System.Drawing.Point(586, 162);
            this.lblCapacidadMaletas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacidadMaletas.Name = "lblCapacidadMaletas";
            this.lblCapacidadMaletas.Size = new System.Drawing.Size(204, 22);
            this.lblCapacidadMaletas.TabIndex = 45;
            this.lblCapacidadMaletas.Text = "Capacidad de maletas:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(797, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 46;
            // 
            // lstMantVehiculos
            // 
            this.lstMantVehiculos.HideSelection = false;
            this.lstMantVehiculos.Location = new System.Drawing.Point(8, 219);
            this.lstMantVehiculos.Name = "lstMantVehiculos";
            this.lstMantVehiculos.Size = new System.Drawing.Size(1002, 167);
            this.lstMantVehiculos.TabIndex = 42;
            this.lstMantVehiculos.UseCompatibleStateImageBehavior = false;
            // 
            // frmMantVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lstMantVehiculos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmMantVehiculos";
            this.Text = "MANTENIMIENTO DE VEHÍCULOS";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtIdentificación;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCapacidadPasajeros;
        private System.Windows.Forms.Label lblCapacidadpasajeros;
        private System.Windows.Forms.RadioButton rbAutomático;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Label lblTransmsión;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCapacidadMaletas;
        private System.Windows.Forms.ListView lstMantVehiculos;
    }
}