namespace Proyecto.Mantenimientos
{
    partial class frmMantClases
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
            this.lstMantClases = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.lblCódClaseVehiculo = new System.Windows.Forms.Label();
            this.txtCódClaseVehículo = new System.Windows.Forms.TextBox();
            this.lblCostoxDia = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.txtCostoxDía = new System.Windows.Forms.TextBox();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMantClases
            // 
            this.lstMantClases.HideSelection = false;
            this.lstMantClases.Location = new System.Drawing.Point(12, 165);
            this.lstMantClases.Name = "lstMantClases";
            this.lstMantClases.Size = new System.Drawing.Size(1002, 221);
            this.lstMantClases.TabIndex = 48;
            this.lstMantClases.UseCompatibleStateImageBehavior = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(833, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnRegresar.Location = new System.Drawing.Point(646, 392);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 46);
            this.btnRegresar.TabIndex = 46;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnActualizar.Location = new System.Drawing.Point(164, 392);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(146, 46);
            this.btnActualizar.TabIndex = 45;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtCostoxDía);
            this.grbDatos.Controls.Add(this.txtCilindrada);
            this.grbDatos.Controls.Add(this.btnConsultar);
            this.grbDatos.Controls.Add(this.lblCilindrada);
            this.grbDatos.Controls.Add(this.lblCódClaseVehiculo);
            this.grbDatos.Controls.Add(this.txtCódClaseVehículo);
            this.grbDatos.Controls.Add(this.lblCostoxDia);
            this.grbDatos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(1002, 147);
            this.grbDatos.TabIndex = 44;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
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
            // txtCódClaseVehículo
            // 
            this.txtCódClaseVehículo.Location = new System.Drawing.Point(280, 27);
            this.txtCódClaseVehículo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCódClaseVehículo.Name = "txtCódClaseVehículo";
            this.txtCódClaseVehículo.Size = new System.Drawing.Size(253, 29);
            this.txtCódClaseVehículo.TabIndex = 30;
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
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnCrear.Location = new System.Drawing.Point(12, 392);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(146, 46);
            this.btnCrear.TabIndex = 43;
            this.btnCrear.Text = "Crear registro";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.button1.Location = new System.Drawing.Point(316, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 49;
            this.button1.Text = "Inhabilitar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(119, 104);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(153, 29);
            this.txtCilindrada.TabIndex = 43;
            // 
            // txtCostoxDía
            // 
            this.txtCostoxDía.Location = new System.Drawing.Point(280, 69);
            this.txtCostoxDía.Name = "txtCostoxDía";
            this.txtCostoxDía.Size = new System.Drawing.Size(253, 29);
            this.txtCostoxDía.TabIndex = 44;
            // 
            // frmMantClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstMantClases);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmMantClases";
            this.Text = "MANTENIMIENTO DE CLASES";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstMantClases;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.Label lblCódClaseVehiculo;
        private System.Windows.Forms.TextBox txtCódClaseVehículo;
        private System.Windows.Forms.Label lblCostoxDia;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCostoxDía;
        private System.Windows.Forms.TextBox txtCilindrada;
    }
}