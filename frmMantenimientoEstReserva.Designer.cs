namespace Proyecto
{
    partial class frmMantenimientoEstReserva
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
            this.lsvMantEstadoReserva = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtDescripEstadoReserva = new System.Windows.Forms.TextBox();
            this.lblDescripEstadoReserva = new System.Windows.Forms.Label();
            this.lblCódReserva = new System.Windows.Forms.Label();
            this.txtCódEstadoReserva = new System.Windows.Forms.TextBox();
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
            this.btnInhabilitar.TabIndex = 66;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // lsvMantEstadoReserva
            // 
            this.lsvMantEstadoReserva.HideSelection = false;
            this.lsvMantEstadoReserva.Location = new System.Drawing.Point(12, 133);
            this.lsvMantEstadoReserva.Name = "lsvMantEstadoReserva";
            this.lsvMantEstadoReserva.Size = new System.Drawing.Size(1002, 253);
            this.lsvMantEstadoReserva.TabIndex = 65;
            this.lsvMantEstadoReserva.UseCompatibleStateImageBehavior = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(833, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 64;
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
            this.btnRegresar.TabIndex = 63;
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
            this.btnActualizar.TabIndex = 62;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtDescripEstadoReserva);
            this.grbDatos.Controls.Add(this.lblDescripEstadoReserva);
            this.grbDatos.Controls.Add(this.lblCódReserva);
            this.grbDatos.Controls.Add(this.txtCódEstadoReserva);
            this.grbDatos.Controls.Add(this.btnConsultar);
            this.grbDatos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(1002, 115);
            this.grbDatos.TabIndex = 61;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // txtDescripEstadoReserva
            // 
            this.txtDescripEstadoReserva.Location = new System.Drawing.Point(343, 68);
            this.txtDescripEstadoReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripEstadoReserva.Name = "txtDescripEstadoReserva";
            this.txtDescripEstadoReserva.Size = new System.Drawing.Size(626, 29);
            this.txtDescripEstadoReserva.TabIndex = 33;
            // 
            // lblDescripEstadoReserva
            // 
            this.lblDescripEstadoReserva.AutoSize = true;
            this.lblDescripEstadoReserva.Location = new System.Drawing.Point(11, 75);
            this.lblDescripEstadoReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripEstadoReserva.Name = "lblDescripEstadoReserva";
            this.lblDescripEstadoReserva.Size = new System.Drawing.Size(324, 22);
            this.lblDescripEstadoReserva.TabIndex = 32;
            this.lblDescripEstadoReserva.Text = "Descripción del estado de la reserva:";
            // 
            // lblCódReserva
            // 
            this.lblCódReserva.AutoSize = true;
            this.lblCódReserva.Location = new System.Drawing.Point(11, 30);
            this.lblCódReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódReserva.Name = "lblCódReserva";
            this.lblCódReserva.Size = new System.Drawing.Size(285, 22);
            this.lblCódReserva.TabIndex = 29;
            this.lblCódReserva.Text = "Código del estado de la reserva:";
            // 
            // txtCódEstadoReserva
            // 
            this.txtCódEstadoReserva.Location = new System.Drawing.Point(298, 27);
            this.txtCódEstadoReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtCódEstadoReserva.Name = "txtCódEstadoReserva";
            this.txtCódEstadoReserva.Size = new System.Drawing.Size(305, 29);
            this.txtCódEstadoReserva.TabIndex = 30;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(610, 22);
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
            this.btnCrear.TabIndex = 60;
            this.btnCrear.Text = "Crear registro";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmMantenimientoEstReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.lsvMantEstadoReserva);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmMantenimientoEstReserva";
            this.Text = "MANTENIMIENTO DE ESTADO DE RESERVA";
            this.Load += new System.EventHandler(this.frmMantenimientoEstReserva_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.ListView lsvMantEstadoReserva;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtDescripEstadoReserva;
        private System.Windows.Forms.Label lblDescripEstadoReserva;
        private System.Windows.Forms.Label lblCódReserva;
        private System.Windows.Forms.TextBox txtCódEstadoReserva;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCrear;
    }
}