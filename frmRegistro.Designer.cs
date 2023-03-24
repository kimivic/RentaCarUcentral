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
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(21, 354);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 23);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(196, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPassUNewConf
            // 
            this.txtPassUNewConf.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPassUNewConf.Location = new System.Drawing.Point(42, 247);
            this.txtPassUNewConf.Name = "txtPassUNewConf";
            this.txtPassUNewConf.ShortcutsEnabled = false;
            this.txtPassUNewConf.Size = new System.Drawing.Size(221, 20);
            this.txtPassUNewConf.TabIndex = 26;
            this.txtPassUNewConf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarContraseña_KeyPress);
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(37, 212);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(212, 24);
            this.lblConfirmarContraseña.TabIndex = 25;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // lblIResgistro
            // 
            this.lblIResgistro.AutoSize = true;
            this.lblIResgistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIResgistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIResgistro.Location = new System.Drawing.Point(38, 22);
            this.lblIResgistro.Name = "lblIResgistro";
            this.lblIResgistro.Size = new System.Drawing.Size(231, 24);
            this.lblIResgistro.TabIndex = 24;
            this.lblIResgistro.Text = "Registro Usuario Nuevo";
            // 
            // txtPassUNew
            // 
            this.txtPassUNew.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPassUNew.Location = new System.Drawing.Point(42, 178);
            this.txtPassUNew.Name = "txtPassUNew";
            this.txtPassUNew.ShortcutsEnabled = false;
            this.txtPassUNew.Size = new System.Drawing.Size(221, 20);
            this.txtPassUNew.TabIndex = 23;
            this.txtPassUNew.TextChanged += new System.EventHandler(this.txtContraseñaNueva_TextChanged);
            this.txtPassUNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseñaNueva_KeyPress);
            // 
            // txtNomUNew
            // 
            this.txtNomUNew.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNomUNew.Location = new System.Drawing.Point(42, 105);
            this.txtNomUNew.Name = "txtNomUNew";
            this.txtNomUNew.ShortcutsEnabled = false;
            this.txtNomUNew.Size = new System.Drawing.Size(221, 20);
            this.txtNomUNew.TabIndex = 22;
            this.txtNomUNew.TextChanged += new System.EventHandler(this.txtNombreUsuarioNuevo_TextChanged);
            this.txtNomUNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuarioNuevo_KeyPress_1);
            // 
            // lblContraseñaNueva
            // 
            this.lblContraseñaNueva.AutoSize = true;
            this.lblContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaNueva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContraseñaNueva.Location = new System.Drawing.Point(35, 141);
            this.lblContraseñaNueva.Name = "lblContraseñaNueva";
            this.lblContraseñaNueva.Size = new System.Drawing.Size(116, 24);
            this.lblContraseñaNueva.TabIndex = 21;
            this.lblContraseñaNueva.Text = "Contraseña";
            // 
            // lblUsuarioNuevo
            // 
            this.lblUsuarioNuevo.AutoSize = true;
            this.lblUsuarioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuarioNuevo.Location = new System.Drawing.Point(17, 65);
            this.lblUsuarioNuevo.Name = "lblUsuarioNuevo";
            this.lblUsuarioNuevo.Size = new System.Drawing.Size(286, 24);
            this.lblUsuarioNuevo.TabIndex = 20;
            this.lblUsuarioNuevo.Text = "Ingrese el nombre de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "txtNomUNew";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "txtPassUNew";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "txtPassUNewConf";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(591, 411);
            this.ControlBox = false;
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
            this.Name = "frmRegistro";
            this.Text = "Menu de Registro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
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
    }
}