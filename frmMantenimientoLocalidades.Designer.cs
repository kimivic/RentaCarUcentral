namespace Proyecto
{
    partial class frmMantenimientoLocalidades
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
            this.lsvMantLocalidades = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.lblCódLocalidad = new System.Windows.Forms.Label();
            this.txtCódLocalidad = new System.Windows.Forms.TextBox();
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
            // lsvMantLocalidades
            // 
            this.lsvMantLocalidades.HideSelection = false;
            this.lsvMantLocalidades.Location = new System.Drawing.Point(12, 133);
            this.lsvMantLocalidades.Name = "lsvMantLocalidades";
            this.lsvMantLocalidades.Size = new System.Drawing.Size(1002, 253);
            this.lsvMantLocalidades.TabIndex = 65;
            this.lsvMantLocalidades.UseCompatibleStateImageBehavior = false;
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
            this.grbDatos.Controls.Add(this.txtNombreLocalidad);
            this.grbDatos.Controls.Add(this.lblNombreLocalidad);
            this.grbDatos.Controls.Add(this.lblCódLocalidad);
            this.grbDatos.Controls.Add(this.txtCódLocalidad);
            this.grbDatos.Controls.Add(this.btnConsultar);
            this.grbDatos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(1002, 115);
            this.grbDatos.TabIndex = 61;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Location = new System.Drawing.Point(229, 68);
            this.txtNombreLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(740, 29);
            this.txtNombreLocalidad.TabIndex = 33;
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.Location = new System.Drawing.Point(11, 75);
            this.lblNombreLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(204, 22);
            this.lblNombreLocalidad.TabIndex = 32;
            this.lblNombreLocalidad.Text = "Nombre de lalocalidad:";
            // 
            // lblCódLocalidad
            // 
            this.lblCódLocalidad.AutoSize = true;
            this.lblCódLocalidad.Location = new System.Drawing.Point(11, 30);
            this.lblCódLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódLocalidad.Name = "lblCódLocalidad";
            this.lblCódLocalidad.Size = new System.Drawing.Size(198, 22);
            this.lblCódLocalidad.TabIndex = 29;
            this.lblCódLocalidad.Text = "Código de la localidad";
            // 
            // txtCódLocalidad
            // 
            this.txtCódLocalidad.Location = new System.Drawing.Point(389, 23);
            this.txtCódLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCódLocalidad.Name = "txtCódLocalidad";
            this.txtCódLocalidad.Size = new System.Drawing.Size(336, 29);
            this.txtCódLocalidad.TabIndex = 30;
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
            this.btnCrear.TabIndex = 60;
            this.btnCrear.Text = "Crear registro";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmMantenimientoLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.lsvMantLocalidades);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmMantenimientoLocalidades";
            this.Text = "MANTENIMIENTO DE LOCALIDADES";
            this.Load += new System.EventHandler(this.frmMantenimientoLocalidades_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.ListView lsvMantLocalidades;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.Label lblCódLocalidad;
        private System.Windows.Forms.TextBox txtCódLocalidad;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCrear;
    }
}