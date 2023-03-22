﻿namespace Proyecto
{
    partial class frmEstadística
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadística));
            this.lblMes = new System.Windows.Forms.Label();
            this.lblTítuloEstadística = new System.Windows.Forms.Label();
            this.lblSubtítuloEstadística = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTipoEstadística = new System.Windows.Forms.Label();
            this.rbEstadClaseVeh = new System.Windows.Forms.RadioButton();
            this.rbIngresosTotalesMes = new System.Windows.Forms.RadioButton();
            this.imgEstadística = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstadística)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(30, 102);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(151, 20);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Seleccione el mes:";
            // 
            // lblTítuloEstadística
            // 
            this.lblTítuloEstadística.AutoSize = true;
            this.lblTítuloEstadística.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítuloEstadística.Location = new System.Drawing.Point(310, 24);
            this.lblTítuloEstadística.Name = "lblTítuloEstadística";
            this.lblTítuloEstadística.Size = new System.Drawing.Size(152, 22);
            this.lblTítuloEstadística.TabIndex = 3;
            this.lblTítuloEstadística.Text = "ESTADÍSTICAS";
            // 
            // lblSubtítuloEstadística
            // 
            this.lblSubtítuloEstadística.AutoSize = true;
            this.lblSubtítuloEstadística.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtítuloEstadística.Location = new System.Drawing.Point(120, 55);
            this.lblSubtítuloEstadística.Name = "lblSubtítuloEstadística";
            this.lblSubtítuloEstadística.Size = new System.Drawing.Size(529, 20);
            this.lblSubtítuloEstadística.TabIndex = 2;
            this.lblSubtítuloEstadística.Text = "Estadísticas por clase de vehículo o ingresos totales por mes\r\n";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(393, 102);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(146, 20);
            this.lblAño.TabIndex = 4;
            this.lblAño.Text = "Seleccione el año:";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(187, 102);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(192, 24);
            this.cmbMes.TabIndex = 5;
            // 
            // cmbAño
            // 
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(545, 102);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(192, 24);
            this.cmbAño.TabIndex = 6;
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.Location = new System.Drawing.Point(153, 234);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(461, 20);
            this.lblIndicaciones.TabIndex = 14;
            this.lblIndicaciones.Text = "Seleccione la imagen para la generación de las estadísticas:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(583, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnRegresar.Location = new System.Drawing.Point(396, 392);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 46);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lblTipoEstadística
            // 
            this.lblTipoEstadística.AutoSize = true;
            this.lblTipoEstadística.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipoEstadística.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEstadística.Location = new System.Drawing.Point(30, 144);
            this.lblTipoEstadística.Name = "lblTipoEstadística";
            this.lblTipoEstadística.Size = new System.Drawing.Size(337, 20);
            this.lblTipoEstadística.TabIndex = 15;
            this.lblTipoEstadística.Text = "Seleccione el tipo de estadística que desea:";
            // 
            // rbEstadClaseVeh
            // 
            this.rbEstadClaseVeh.AutoSize = true;
            this.rbEstadClaseVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEstadClaseVeh.Location = new System.Drawing.Point(172, 163);
            this.rbEstadClaseVeh.Name = "rbEstadClaseVeh";
            this.rbEstadClaseVeh.Size = new System.Drawing.Size(280, 24);
            this.rbEstadClaseVeh.TabIndex = 16;
            this.rbEstadClaseVeh.TabStop = true;
            this.rbEstadClaseVeh.Text = "Estadística por clase de vehículo.";
            this.rbEstadClaseVeh.UseVisualStyleBackColor = true;
            // 
            // rbIngresosTotalesMes
            // 
            this.rbIngresosTotalesMes.AutoSize = true;
            this.rbIngresosTotalesMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngresosTotalesMes.Location = new System.Drawing.Point(172, 189);
            this.rbIngresosTotalesMes.Name = "rbIngresosTotalesMes";
            this.rbIngresosTotalesMes.Size = new System.Drawing.Size(330, 24);
            this.rbIngresosTotalesMes.TabIndex = 17;
            this.rbIngresosTotalesMes.TabStop = true;
            this.rbIngresosTotalesMes.Text = "Estadística de ingresos totales por mes.";
            this.rbIngresosTotalesMes.UseVisualStyleBackColor = true;
            // 
            // imgEstadística
            // 
            this.imgEstadística.Image = ((System.Drawing.Image)(resources.GetObject("imgEstadística.Image")));
            this.imgEstadística.Location = new System.Drawing.Point(306, 257);
            this.imgEstadística.Name = "imgEstadística";
            this.imgEstadística.Size = new System.Drawing.Size(146, 116);
            this.imgEstadística.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEstadística.TabIndex = 18;
            this.imgEstadística.TabStop = false;
            // 
            // frmEstadística
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.imgEstadística);
            this.Controls.Add(this.rbIngresosTotalesMes);
            this.Controls.Add(this.rbEstadClaseVeh);
            this.Controls.Add(this.lblTipoEstadística);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblTítuloEstadística);
            this.Controls.Add(this.lblSubtítuloEstadística);
            this.Controls.Add(this.lblMes);
            this.Name = "frmEstadística";
            this.Text = "ESTADÍSTICAS";
            ((System.ComponentModel.ISupportInitialize)(this.imgEstadística)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblTítuloEstadística;
        private System.Windows.Forms.Label lblSubtítuloEstadística;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTipoEstadística;
        private System.Windows.Forms.RadioButton rbEstadClaseVeh;
        private System.Windows.Forms.RadioButton rbIngresosTotalesMes;
        private System.Windows.Forms.PictureBox imgEstadística;
    }
}