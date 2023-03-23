namespace Proyecto
{
    partial class frmMantenimientoPerfiles
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
            this.lsvMantPerfiles = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtDescripciónPerfil = new System.Windows.Forms.TextBox();
            this.lblDescripciónPerfil = new System.Windows.Forms.Label();
            this.lblCódPerfilUsuario = new System.Windows.Forms.Label();
            this.txtCódPerfilUsaurio = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvMantPerfiles
            // 
            this.lsvMantPerfiles.HideSelection = false;
            this.lsvMantPerfiles.Location = new System.Drawing.Point(12, 133);
            this.lsvMantPerfiles.Name = "lsvMantPerfiles";
            this.lsvMantPerfiles.Size = new System.Drawing.Size(1002, 253);
            this.lsvMantPerfiles.TabIndex = 51;
            this.lsvMantPerfiles.UseCompatibleStateImageBehavior = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(833, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnRegresar.Location = new System.Drawing.Point(646, 392);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 46);
            this.btnRegresar.TabIndex = 49;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnActualizar.Location = new System.Drawing.Point(185, 392);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(146, 46);
            this.btnActualizar.TabIndex = 48;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtDescripciónPerfil);
            this.grbDatos.Controls.Add(this.lblDescripciónPerfil);
            this.grbDatos.Controls.Add(this.lblCódPerfilUsuario);
            this.grbDatos.Controls.Add(this.txtCódPerfilUsaurio);
            this.grbDatos.Controls.Add(this.btnConsultar);
            this.grbDatos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(1002, 115);
            this.grbDatos.TabIndex = 47;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // txtDescripciónPerfil
            // 
            this.txtDescripciónPerfil.Location = new System.Drawing.Point(208, 68);
            this.txtDescripciónPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripciónPerfil.Name = "txtDescripciónPerfil";
            this.txtDescripciónPerfil.Size = new System.Drawing.Size(761, 29);
            this.txtDescripciónPerfil.TabIndex = 33;
            // 
            // lblDescripciónPerfil
            // 
            this.lblDescripciónPerfil.AutoSize = true;
            this.lblDescripciónPerfil.Location = new System.Drawing.Point(11, 75);
            this.lblDescripciónPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripciónPerfil.Name = "lblDescripciónPerfil";
            this.lblDescripciónPerfil.Size = new System.Drawing.Size(194, 22);
            this.lblDescripciónPerfil.TabIndex = 32;
            this.lblDescripciónPerfil.Text = "Descripción del perfil:";
            // 
            // lblCódPerfilUsuario
            // 
            this.lblCódPerfilUsuario.AutoSize = true;
            this.lblCódPerfilUsuario.Location = new System.Drawing.Point(11, 30);
            this.lblCódPerfilUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódPerfilUsuario.Name = "lblCódPerfilUsuario";
            this.lblCódPerfilUsuario.Size = new System.Drawing.Size(248, 22);
            this.lblCódPerfilUsuario.TabIndex = 29;
            this.lblCódPerfilUsuario.Text = "Código de perfil del usuario:";
            // 
            // txtCódPerfilUsaurio
            // 
            this.txtCódPerfilUsaurio.Location = new System.Drawing.Point(267, 27);
            this.txtCódPerfilUsaurio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCódPerfilUsaurio.Name = "txtCódPerfilUsaurio";
            this.txtCódPerfilUsaurio.Size = new System.Drawing.Size(336, 29);
            this.txtCódPerfilUsaurio.TabIndex = 30;
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
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnInhabilitar.Location = new System.Drawing.Point(337, 392);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(146, 46);
            this.btnInhabilitar.TabIndex = 52;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnCrear.Location = new System.Drawing.Point(20, 392);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(146, 46);
            this.btnCrear.TabIndex = 46;
            this.btnCrear.Text = "Crear registro";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmMantenimientoPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.lsvMantPerfiles);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmMantenimientoPerfiles";
            this.Text = "MANTENIMIENTO DE PERFILES";
            this.Load += new System.EventHandler(this.frmMantenimientoPerfiles_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvMantPerfiles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtDescripciónPerfil;
        private System.Windows.Forms.Label lblDescripciónPerfil;
        private System.Windows.Forms.Label lblCódPerfilUsuario;
        private System.Windows.Forms.TextBox txtCódPerfilUsaurio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnCrear;
    }
}