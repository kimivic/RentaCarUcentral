namespace Proyecto
{
    partial class frmMantenimientoEstados
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
            this.lstMantEstados = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtDescripciónPerfil = new System.Windows.Forms.TextBox();
            this.lblDescripciónEstado = new System.Windows.Forms.Label();
            this.lblCódEstadoUsuario = new System.Windows.Forms.Label();
            this.txtCódEstadoUsuario = new System.Windows.Forms.TextBox();
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
            this.btnInhabilitar.TabIndex = 59;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // lstMantEstados
            // 
            this.lstMantEstados.HideSelection = false;
            this.lstMantEstados.Location = new System.Drawing.Point(12, 133);
            this.lstMantEstados.Name = "lstMantEstados";
            this.lstMantEstados.Size = new System.Drawing.Size(1002, 253);
            this.lstMantEstados.TabIndex = 58;
            this.lstMantEstados.UseCompatibleStateImageBehavior = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(833, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 57;
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
            this.btnRegresar.TabIndex = 56;
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
            this.btnActualizar.TabIndex = 55;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtDescripciónPerfil);
            this.grbDatos.Controls.Add(this.lblDescripciónEstado);
            this.grbDatos.Controls.Add(this.lblCódEstadoUsuario);
            this.grbDatos.Controls.Add(this.txtCódEstadoUsuario);
            this.grbDatos.Controls.Add(this.btnConsultar);
            this.grbDatos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(1002, 115);
            this.grbDatos.TabIndex = 54;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // txtDescripciónPerfil
            // 
            this.txtDescripciónPerfil.Location = new System.Drawing.Point(229, 68);
            this.txtDescripciónPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripciónPerfil.Name = "txtDescripciónPerfil";
            this.txtDescripciónPerfil.Size = new System.Drawing.Size(740, 29);
            this.txtDescripciónPerfil.TabIndex = 33;
            // 
            // lblDescripciónEstado
            // 
            this.lblDescripciónEstado.AutoSize = true;
            this.lblDescripciónEstado.Location = new System.Drawing.Point(11, 75);
            this.lblDescripciónEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripciónEstado.Name = "lblDescripciónEstado";
            this.lblDescripciónEstado.Size = new System.Drawing.Size(210, 22);
            this.lblDescripciónEstado.TabIndex = 32;
            this.lblDescripciónEstado.Text = "Descripción del estado:";
            // 
            // lblCódEstadoUsuario
            // 
            this.lblCódEstadoUsuario.AutoSize = true;
            this.lblCódEstadoUsuario.Location = new System.Drawing.Point(11, 30);
            this.lblCódEstadoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódEstadoUsuario.Name = "lblCódEstadoUsuario";
            this.lblCódEstadoUsuario.Size = new System.Drawing.Size(370, 22);
            this.lblCódEstadoUsuario.TabIndex = 29;
            this.lblCódEstadoUsuario.Text = "Código del estado del usuario del sistema:";
            // 
            // txtCódEstadoUsuario
            // 
            this.txtCódEstadoUsuario.Location = new System.Drawing.Point(389, 23);
            this.txtCódEstadoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtCódEstadoUsuario.Name = "txtCódEstadoUsuario";
            this.txtCódEstadoUsuario.Size = new System.Drawing.Size(336, 29);
            this.txtCódEstadoUsuario.TabIndex = 30;
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
            this.btnCrear.Location = new System.Drawing.Point(27, 392);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(146, 46);
            this.btnCrear.TabIndex = 53;
            this.btnCrear.Text = "Crear registro";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmMantenimientoEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.lstMantEstados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmMantenimientoEstados";
            this.Text = "MANTENIMIENTO DE ESTADOS";
            this.Load += new System.EventHandler(this.frmMantenimientoEstados_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.ListView lstMantEstados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtDescripciónPerfil;
        private System.Windows.Forms.Label lblDescripciónEstado;
        private System.Windows.Forms.Label lblCódEstadoUsuario;
        private System.Windows.Forms.TextBox txtCódEstadoUsuario;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCrear;
    }
}