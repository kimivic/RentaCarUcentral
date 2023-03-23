namespace Proyecto
{
    partial class frmMantenimientoUSuarios
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtCódPerfil = new System.Windows.Forms.TextBox();
            this.txtIdentificación = new System.Windows.Forms.TextBox();
            this.lblIdentificación = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblCódEstado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtCódEstado = new System.Windows.Forms.TextBox();
            this.lblCódPerfil = new System.Windows.Forms.Label();
            this.lsvMantUsuarios = new System.Windows.Forms.ListView();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnCrear.Location = new System.Drawing.Point(30, 392);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(146, 46);
            this.btnCrear.TabIndex = 46;
            this.btnCrear.Text = "Crear registro";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtCódPerfil
            // 
            this.txtCódPerfil.Location = new System.Drawing.Point(428, 70);
            this.txtCódPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.txtCódPerfil.Name = "txtCódPerfil";
            this.txtCódPerfil.Size = new System.Drawing.Size(146, 29);
            this.txtCódPerfil.TabIndex = 36;
            // 
            // txtIdentificación
            // 
            this.txtIdentificación.Location = new System.Drawing.Point(245, 27);
            this.txtIdentificación.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificación.Name = "txtIdentificación";
            this.txtIdentificación.Size = new System.Drawing.Size(253, 29);
            this.txtIdentificación.TabIndex = 35;
            // 
            // lblIdentificación
            // 
            this.lblIdentificación.AutoSize = true;
            this.lblIdentificación.Location = new System.Drawing.Point(11, 34);
            this.lblIdentificación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificación.Name = "lblIdentificación";
            this.lblIdentificación.Size = new System.Drawing.Size(226, 22);
            this.lblIdentificación.TabIndex = 34;
            this.lblIdentificación.Text = "Cedula, DNI o Pasaporte:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(102, 72);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(146, 29);
            this.txtUsuario.TabIndex = 33;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(843, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnRegresar.Location = new System.Drawing.Point(656, 392);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 46);
            this.btnRegresar.TabIndex = 49;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnActualizar.Location = new System.Drawing.Point(195, 392);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(146, 46);
            this.btnActualizar.TabIndex = 48;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblCódEstado
            // 
            this.lblCódEstado.AutoSize = true;
            this.lblCódEstado.Location = new System.Drawing.Point(588, 79);
            this.lblCódEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódEstado.Name = "lblCódEstado";
            this.lblCódEstado.Size = new System.Drawing.Size(167, 22);
            this.lblCódEstado.TabIndex = 32;
            this.lblCódEstado.Text = "Código de estado:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(11, 79);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 22);
            this.lblUsuario.TabIndex = 29;
            this.lblUsuario.Text = "Usuario:";
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
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(131, 120);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(285, 29);
            this.txtContraseña.TabIndex = 27;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(11, 123);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(112, 22);
            this.lblContraseña.TabIndex = 24;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtCódEstado
            // 
            this.txtCódEstado.Location = new System.Drawing.Point(763, 76);
            this.txtCódEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtCódEstado.Name = "txtCódEstado";
            this.txtCódEstado.Size = new System.Drawing.Size(146, 29);
            this.txtCódEstado.TabIndex = 26;
            // 
            // lblCódPerfil
            // 
            this.lblCódPerfil.AutoSize = true;
            this.lblCódPerfil.Location = new System.Drawing.Point(265, 79);
            this.lblCódPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódPerfil.Name = "lblCódPerfil";
            this.lblCódPerfil.Size = new System.Drawing.Size(151, 22);
            this.lblCódPerfil.TabIndex = 25;
            this.lblCódPerfil.Text = "Código de perfil:";
            // 
            // lsvMantUsuarios
            // 
            this.lsvMantUsuarios.HideSelection = false;
            this.lsvMantUsuarios.Location = new System.Drawing.Point(21, 188);
            this.lsvMantUsuarios.Name = "lsvMantUsuarios";
            this.lsvMantUsuarios.Size = new System.Drawing.Size(1002, 198);
            this.lsvMantUsuarios.TabIndex = 51;
            this.lsvMantUsuarios.UseCompatibleStateImageBehavior = false;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtCódPerfil);
            this.grbDatos.Controls.Add(this.txtIdentificación);
            this.grbDatos.Controls.Add(this.lblIdentificación);
            this.grbDatos.Controls.Add(this.txtUsuario);
            this.grbDatos.Controls.Add(this.lblCódEstado);
            this.grbDatos.Controls.Add(this.lblUsuario);
            this.grbDatos.Controls.Add(this.btnConsultar);
            this.grbDatos.Controls.Add(this.txtContraseña);
            this.grbDatos.Controls.Add(this.lblContraseña);
            this.grbDatos.Controls.Add(this.txtCódEstado);
            this.grbDatos.Controls.Add(this.lblCódPerfil);
            this.grbDatos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.grbDatos.Location = new System.Drawing.Point(22, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(1002, 169);
            this.grbDatos.TabIndex = 47;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // frmMantenimientoUSuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lsvMantUsuarios);
            this.Controls.Add(this.grbDatos);
            this.Name = "frmMantenimientoUSuarios";
            this.Text = "MANTENIMIENTO DE USUARIOS";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtCódPerfil;
        private System.Windows.Forms.TextBox txtIdentificación;
        private System.Windows.Forms.Label lblIdentificación;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblCódEstado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtCódEstado;
        private System.Windows.Forms.Label lblCódPerfil;
        private System.Windows.Forms.ListView lsvMantUsuarios;
        private System.Windows.Forms.GroupBox grbDatos;
    }
}