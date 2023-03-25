namespace Proyecto
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.lblSubtítuloReporte = new System.Windows.Forms.Label();
            this.lblTítuloReporte = new System.Windows.Forms.Label();
            this.imgReporte = new System.Windows.Forms.PictureBox();
            this.lblDíaReporte = new System.Windows.Forms.Label();
            this.dtpDíaReporte = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubtítuloReporte
            // 
            this.lblSubtítuloReporte.AutoSize = true;
            this.lblSubtítuloReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtítuloReporte.Location = new System.Drawing.Point(101, 60);
            this.lblSubtítuloReporte.Name = "lblSubtítuloReporte";
            this.lblSubtítuloReporte.Size = new System.Drawing.Size(669, 20);
            this.lblSubtítuloReporte.TabIndex = 0;
            this.lblSubtítuloReporte.Text = "Estado de las reservas (facturadas y pagadas), anuladas, pendientes en el día";
            // 
            // lblTítuloReporte
            // 
            this.lblTítuloReporte.AutoSize = true;
            this.lblTítuloReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítuloReporte.Location = new System.Drawing.Point(342, 29);
            this.lblTítuloReporte.Name = "lblTítuloReporte";
            this.lblTítuloReporte.Size = new System.Drawing.Size(118, 22);
            this.lblTítuloReporte.TabIndex = 1;
            this.lblTítuloReporte.Text = "REPORTES";
            // 
            // imgReporte
            // 
            this.imgReporte.Image = ((System.Drawing.Image)(resources.GetObject("imgReporte.Image")));
            this.imgReporte.Location = new System.Drawing.Point(331, 209);
            this.imgReporte.Name = "imgReporte";
            this.imgReporte.Size = new System.Drawing.Size(155, 140);
            this.imgReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReporte.TabIndex = 2;
            this.imgReporte.TabStop = false;
            this.imgReporte.Click += new System.EventHandler(this.imgReporte_Click);
            // 
            // lblDíaReporte
            // 
            this.lblDíaReporte.AutoSize = true;
            this.lblDíaReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDíaReporte.Location = new System.Drawing.Point(12, 106);
            this.lblDíaReporte.Name = "lblDíaReporte";
            this.lblDíaReporte.Size = new System.Drawing.Size(125, 20);
            this.lblDíaReporte.TabIndex = 3;
            this.lblDíaReporte.Text = "Día del reporte:";
            // 
            // dtpDíaReporte
            // 
            this.dtpDíaReporte.Location = new System.Drawing.Point(143, 106);
            this.dtpDíaReporte.Name = "dtpDíaReporte";
            this.dtpDíaReporte.Size = new System.Drawing.Size(273, 22);
            this.dtpDíaReporte.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(605, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnRegresar.Location = new System.Drawing.Point(418, 392);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 46);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.Location = new System.Drawing.Point(211, 168);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(401, 20);
            this.lblIndicaciones.TabIndex = 11;
            this.lblIndicaciones.Text = "Seleccione la imagen para la generación del reporte:";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtpDíaReporte);
            this.Controls.Add(this.lblDíaReporte);
            this.Controls.Add(this.imgReporte);
            this.Controls.Add(this.lblTítuloReporte);
            this.Controls.Add(this.lblSubtítuloReporte);
            this.Name = "frmReportes";
            this.Text = "REPORTES";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtítuloReporte;
        private System.Windows.Forms.Label lblTítuloReporte;
        private System.Windows.Forms.PictureBox imgReporte;
        private System.Windows.Forms.Label lblDíaReporte;
        private System.Windows.Forms.DateTimePicker dtpDíaReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblIndicaciones;
    }
}