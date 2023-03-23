namespace Proyecto
{
    partial class frmMantenimientoClases
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
            this.lsvMantClases = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.cmbCodClase = new System.Windows.Forms.ComboBox();
            this.txtCostoxDía = new System.Windows.Forms.TextBox();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.lblCódClaseVehiculo = new System.Windows.Forms.Label();
            this.lblCostoxDia = new System.Windows.Forms.Label();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvMantClases
            // 
            this.lsvMantClases.HideSelection = false;
            this.lsvMantClases.Location = new System.Drawing.Point(12, 165);
            this.lsvMantClases.Name = "lsvMantClases";
            this.lsvMantClases.Size = new System.Drawing.Size(1002, 194);
            this.lsvMantClases.TabIndex = 55;
            this.lsvMantClases.UseCompatibleStateImageBehavior = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(833, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 54;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnRegresar.Location = new System.Drawing.Point(646, 392);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 46);
            this.btnRegresar.TabIndex = 53;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnActualizar.Location = new System.Drawing.Point(164, 392);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(146, 46);
            this.btnActualizar.TabIndex = 52;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.cmbCodClase);
            this.grbDatos.Controls.Add(this.txtCostoxDía);
            this.grbDatos.Controls.Add(this.txtCilindrada);
            this.grbDatos.Controls.Add(this.btnConsultar);
            this.grbDatos.Controls.Add(this.lblCilindrada);
            this.grbDatos.Controls.Add(this.lblCódClaseVehiculo);
            this.grbDatos.Controls.Add(this.lblCostoxDia);
            this.grbDatos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(1002, 147);
            this.grbDatos.TabIndex = 51;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // cmbCodClase
            // 
            this.cmbCodClase.FormattingEnabled = true;
            this.cmbCodClase.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbCodClase.Location = new System.Drawing.Point(280, 22);
            this.cmbCodClase.Name = "cmbCodClase";
            this.cmbCodClase.Size = new System.Drawing.Size(121, 30);
            this.cmbCodClase.TabIndex = 45;
            // 
            // txtCostoxDía
            // 
            this.txtCostoxDía.Location = new System.Drawing.Point(280, 69);
            this.txtCostoxDía.Name = "txtCostoxDía";
            this.txtCostoxDía.Size = new System.Drawing.Size(253, 29);
            this.txtCostoxDía.TabIndex = 44;
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(119, 104);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(153, 29);
            this.txtCilindrada.TabIndex = 43;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(540, 22);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(155, 38);
            this.btnConsultar.TabIndex = 34;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Location = new System.Drawing.Point(13, 107);
            this.lblCilindrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(99, 22);
            this.lblCilindrada.TabIndex = 32;
            this.lblCilindrada.Text = "Cilindrada:";
            // 
            // lblCódClaseVehiculo
            // 
            this.lblCódClaseVehiculo.AutoSize = true;
            this.lblCódClaseVehiculo.Location = new System.Drawing.Point(11, 30);
            this.lblCódClaseVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódClaseVehiculo.Name = "lblCódClaseVehiculo";
            this.lblCódClaseVehiculo.Size = new System.Drawing.Size(261, 22);
            this.lblCódClaseVehiculo.TabIndex = 29;
            this.lblCódClaseVehiculo.Text = "Código de clase del vehículo:";
            // 
            // lblCostoxDia
            // 
            this.lblCostoxDia.AutoSize = true;
            this.lblCostoxDia.Location = new System.Drawing.Point(13, 69);
            this.lblCostoxDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoxDia.Name = "lblCostoxDia";
            this.lblCostoxDia.Size = new System.Drawing.Size(221, 22);
            this.lblCostoxDia.TabIndex = 24;
            this.lblCostoxDia.Text = "Costo del día de alquiler:";
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnInhabilitar.Location = new System.Drawing.Point(316, 392);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(146, 46);
            this.btnInhabilitar.TabIndex = 56;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnGuardar.Location = new System.Drawing.Point(12, 392);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 46);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmMantenimientoClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lsvMantClases);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmMantenimientoClases";
            this.Text = "MANTENIMIENTO DE CLASES";
            this.Load += new System.EventHandler(this.frmMantenimientoClases_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvMantClases;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.ComboBox cmbCodClase;
        private System.Windows.Forms.TextBox txtCostoxDía;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.Label lblCódClaseVehiculo;
        private System.Windows.Forms.Label lblCostoxDia;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnGuardar;
    }
}