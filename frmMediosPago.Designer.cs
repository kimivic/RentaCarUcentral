namespace Proyecto
{
    partial class frmMediosPago
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
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.lsvManttMedioPago = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtDDescripciónMedioPago = new System.Windows.Forms.TextBox();
            this.lblDescripciónMedioPago = new System.Windows.Forms.Label();
            this.lblCódMedioPago = new System.Windows.Forms.Label();
            this.txtCódMedioPago = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnInhabilitar.Location = new System.Drawing.Point(337, 392);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(146, 46);
            this.btnInhabilitar.TabIndex = 73;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // lsvManttMedioPago
            // 
            this.lsvManttMedioPago.HideSelection = false;
            this.lsvManttMedioPago.Location = new System.Drawing.Point(12, 133);
            this.lsvManttMedioPago.Name = "lsvManttMedioPago";
            this.lsvManttMedioPago.Size = new System.Drawing.Size(1002, 253);
            this.lsvManttMedioPago.TabIndex = 72;
            this.lsvManttMedioPago.UseCompatibleStateImageBehavior = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(833, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 71;
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
            this.btnRegresar.TabIndex = 70;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnActualizar.Location = new System.Drawing.Point(185, 392);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(146, 46);
            this.btnActualizar.TabIndex = 69;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtDDescripciónMedioPago);
            this.grbDatos.Controls.Add(this.lblDescripciónMedioPago);
            this.grbDatos.Controls.Add(this.lblCódMedioPago);
            this.grbDatos.Controls.Add(this.txtCódMedioPago);
            this.grbDatos.Controls.Add(this.btnConsultar);
            this.grbDatos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(1002, 115);
            this.grbDatos.TabIndex = 68;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // txtDDescripciónMedioPago
            // 
            this.txtDDescripciónMedioPago.Location = new System.Drawing.Point(299, 68);
            this.txtDDescripciónMedioPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtDDescripciónMedioPago.Name = "txtDDescripciónMedioPago";
            this.txtDDescripciónMedioPago.Size = new System.Drawing.Size(670, 29);
            this.txtDDescripciónMedioPago.TabIndex = 33;
            // 
            // lblDescripciónMedioPago
            // 
            this.lblDescripciónMedioPago.AutoSize = true;
            this.lblDescripciónMedioPago.Location = new System.Drawing.Point(11, 75);
            this.lblDescripciónMedioPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripciónMedioPago.Name = "lblDescripciónMedioPago";
            this.lblDescripciónMedioPago.Size = new System.Drawing.Size(280, 22);
            this.lblDescripciónMedioPago.TabIndex = 32;
            this.lblDescripciónMedioPago.Text = "Descripción del medio de pago:";
            // 
            // lblCódMedioPago
            // 
            this.lblCódMedioPago.AutoSize = true;
            this.lblCódMedioPago.Location = new System.Drawing.Point(11, 30);
            this.lblCódMedioPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódMedioPago.Name = "lblCódMedioPago";
            this.lblCódMedioPago.Size = new System.Drawing.Size(241, 22);
            this.lblCódMedioPago.TabIndex = 29;
            this.lblCódMedioPago.Text = "Código del medio de pago:";
            // 
            // txtCódMedioPago
            // 
            this.txtCódMedioPago.Location = new System.Drawing.Point(260, 27);
            this.txtCódMedioPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtCódMedioPago.Name = "txtCódMedioPago";
            this.txtCódMedioPago.Size = new System.Drawing.Size(336, 29);
            this.txtCódMedioPago.TabIndex = 30;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(741, 18);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(155, 38);
            this.btnConsultar.TabIndex = 31;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnCrear.Location = new System.Drawing.Point(20, 392);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(146, 46);
            this.btnCrear.TabIndex = 67;
            this.btnCrear.Text = "Crear registro";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmMediosPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.lsvManttMedioPago);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmMediosPago";
            this.Text = "CATÁLOGO MEDIOS DE PAGOS";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.ListView lsvManttMedioPago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtDDescripciónMedioPago;
        private System.Windows.Forms.Label lblDescripciónMedioPago;
        private System.Windows.Forms.Label lblCódMedioPago;
        private System.Windows.Forms.TextBox txtCódMedioPago;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCrear;
    }
}