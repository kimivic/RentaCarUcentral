namespace proyectoRentaCar1
{
    partial class frmRegistro
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPassUNewConf = new System.Windows.Forms.TextBox();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.lblIResgistro = new System.Windows.Forms.Label();
            this.txtPassUNew = new System.Windows.Forms.TextBox();
            this.txtNomUNew = new System.Windows.Forms.TextBox();
            this.lblContraseñaNueva = new System.Windows.Forms.Label();
            this.lblUsuarioNuevo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(85, 657);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 28);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 657);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 28);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPassUNewConf
            // 
            this.txtPassUNewConf.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPassUNewConf.Location = new System.Drawing.Point(87, 627);
            this.txtPassUNewConf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassUNewConf.Name = "txtPassUNewConf";
            this.txtPassUNewConf.ShortcutsEnabled = false;
            this.txtPassUNewConf.Size = new System.Drawing.Size(293, 22);
            this.txtPassUNewConf.TabIndex = 26;
            this.txtPassUNewConf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarContraseña_KeyPress);
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(117, 594);
            this.lblConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(267, 29);
            this.lblConfirmarContraseña.TabIndex = 25;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // lblIResgistro
            // 
            this.lblIResgistro.AutoSize = true;
            this.lblIResgistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIResgistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIResgistro.Location = new System.Drawing.Point(124, 93);
            this.lblIResgistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIResgistro.Name = "lblIResgistro";
            this.lblIResgistro.Size = new System.Drawing.Size(291, 29);
            this.lblIResgistro.TabIndex = 24;
            this.lblIResgistro.Text = "Registro Usuario Nuevo";
            // 
            // txtPassUNew
            // 
            this.txtPassUNew.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPassUNew.Location = new System.Drawing.Point(91, 568);
            this.txtPassUNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassUNew.Name = "txtPassUNew";
            this.txtPassUNew.ShortcutsEnabled = false;
            this.txtPassUNew.Size = new System.Drawing.Size(293, 22);
            this.txtPassUNew.TabIndex = 23;
            this.txtPassUNew.TextChanged += new System.EventHandler(this.txtContraseñaNueva_TextChanged);
            this.txtPassUNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseñaNueva_KeyPress);
            // 
            // txtNomUNew
            // 
            this.txtNomUNew.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNomUNew.Location = new System.Drawing.Point(94, 155);
            this.txtNomUNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomUNew.Name = "txtNomUNew";
            this.txtNomUNew.ShortcutsEnabled = false;
            this.txtNomUNew.Size = new System.Drawing.Size(293, 22);
            this.txtNomUNew.TabIndex = 22;
            this.txtNomUNew.TextChanged += new System.EventHandler(this.txtNombreUsuarioNuevo_TextChanged);
            this.txtNomUNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuarioNuevo_KeyPress_1);
            // 
            // lblContraseñaNueva
            // 
            this.lblContraseñaNueva.AutoSize = true;
            this.lblContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaNueva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContraseñaNueva.Location = new System.Drawing.Point(177, 538);
            this.lblContraseñaNueva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaNueva.Name = "lblContraseñaNueva";
            this.lblContraseñaNueva.Size = new System.Drawing.Size(146, 29);
            this.lblContraseñaNueva.TabIndex = 21;
            this.lblContraseñaNueva.Text = "Contraseña";
            // 
            // lblUsuarioNuevo
            // 
            this.lblUsuarioNuevo.AutoSize = true;
            this.lblUsuarioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuarioNuevo.Location = new System.Drawing.Point(89, 122);
            this.lblUsuarioNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioNuevo.Name = "lblUsuarioNuevo";
            this.lblUsuarioNuevo.Size = new System.Drawing.Size(356, 29);
            this.lblUsuarioNuevo.TabIndex = 20;
            this.lblUsuarioNuevo.Text = "Ingrese el nombre de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "txtNomUNew";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 574);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "txtPassUNew";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 636);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "txtPassUNewConf";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(186, 181);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNombre.Location = new System.Drawing.Point(94, 214);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(293, 22);
            this.txtNombre.TabIndex = 31;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellido.Location = new System.Drawing.Point(183, 240);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(110, 29);
            this.lblApellido.TabIndex = 32;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtApellido.Location = new System.Drawing.Point(94, 274);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(293, 22);
            this.txtApellido.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoRentaCar1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtIdentificacion.Location = new System.Drawing.Point(94, 336);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ShortcutsEnabled = false;
            this.txtIdentificacion.Size = new System.Drawing.Size(293, 22);
            this.txtIdentificacion.TabIndex = 36;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdentificacion.Location = new System.Drawing.Point(89, 301);
            this.lblIdentificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(302, 29);
            this.lblIdentificacion.TabIndex = 35;
            this.lblIdentificacion.Text = "Cédula, DNI o Pasaporte";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaNac.Location = new System.Drawing.Point(108, 363);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(256, 29);
            this.lblFechaNac.TabIndex = 37;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 395);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 22);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // txtCorreo
            // 
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCorreo.Location = new System.Drawing.Point(94, 453);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(293, 22);
            this.txtCorreo.TabIndex = 40;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCorreo.Location = new System.Drawing.Point(131, 420);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(233, 29);
            this.lblCorreo.TabIndex = 39;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // txtTelefono
            // 
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTelefono.Location = new System.Drawing.Point(87, 512);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ShortcutsEnabled = false;
            this.txtTelefono.Size = new System.Drawing.Size(293, 22);
            this.txtTelefono.TabIndex = 42;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefono.Location = new System.Drawing.Point(124, 479);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(216, 29);
            this.lblTelefono.TabIndex = 41;
            this.lblTelefono.Text = "Número Contacto";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(544, 694);
            this.ControlBox = false;
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassUNewConf);
            this.Controls.Add(this.lblConfirmarContraseña);
            this.Controls.Add(this.lblIResgistro);
            this.Controls.Add(this.txtPassUNew);
            this.Controls.Add(this.txtNomUNew);
            this.Controls.Add(this.lblContraseñaNueva);
            this.Controls.Add(this.lblUsuarioNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegistro";
            this.Text = "Menu de Registro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPassUNewConf;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.Label lblIResgistro;
        private System.Windows.Forms.TextBox txtPassUNew;
        private System.Windows.Forms.TextBox txtNomUNew;
        private System.Windows.Forms.Label lblContraseñaNueva;
        private System.Windows.Forms.Label lblUsuarioNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
    }
}