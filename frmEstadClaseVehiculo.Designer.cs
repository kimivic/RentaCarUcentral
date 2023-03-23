namespace Proyecto
{
    partial class frmEstadClaseVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadClaseVehiculo));
            this.imgEstadística = new System.Windows.Forms.PictureBox();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblTítuloEstadística = new System.Windows.Forms.Label();
            this.lblSubtítuloEstadística = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstadística)).BeginInit();
            this.SuspendLayout();
            // 
            // imgEstadística
            // 
            this.imgEstadística.Image = ((System.Drawing.Image)(resources.GetObject("imgEstadística.Image")));
            this.imgEstadística.Location = new System.Drawing.Point(304, 208);
            this.imgEstadística.Name = "imgEstadística";
            this.imgEstadística.Size = new System.Drawing.Size(146, 116);
            this.imgEstadística.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEstadística.TabIndex = 31;
            this.imgEstadística.TabStop = false;
            this.imgEstadística.Click += new System.EventHandler(this.imgEstadística_Click);
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.Location = new System.Drawing.Point(160, 160);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(461, 20);
            this.lblIndicaciones.TabIndex = 27;
            this.lblIndicaciones.Text = "Seleccione la imagen para la generación de las estadísticas:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(586, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnRegresar.Location = new System.Drawing.Point(399, 386);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 46);
            this.btnRegresar.TabIndex = 25;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cmbAño
            // 
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(548, 96);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(192, 24);
            this.cmbAño.TabIndex = 24;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(190, 96);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(192, 24);
            this.cmbMes.TabIndex = 23;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(396, 96);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(146, 20);
            this.lblAño.TabIndex = 22;
            this.lblAño.Text = "Seleccione el año:";
            // 
            // lblTítuloEstadística
            // 
            this.lblTítuloEstadística.AutoSize = true;
            this.lblTítuloEstadística.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítuloEstadística.Location = new System.Drawing.Point(313, 18);
            this.lblTítuloEstadística.Name = "lblTítuloEstadística";
            this.lblTítuloEstadística.Size = new System.Drawing.Size(152, 22);
            this.lblTítuloEstadística.TabIndex = 21;
            this.lblTítuloEstadística.Text = "ESTADÍSTICAS";
            // 
            // lblSubtítuloEstadística
            // 
            this.lblSubtítuloEstadística.AutoSize = true;
            this.lblSubtítuloEstadística.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtítuloEstadística.Location = new System.Drawing.Point(244, 49);
            this.lblSubtítuloEstadística.Name = "lblSubtítuloEstadística";
            this.lblSubtítuloEstadística.Size = new System.Drawing.Size(298, 20);
            this.lblSubtítuloEstadística.TabIndex = 20;
            this.lblSubtítuloEstadística.Text = "Estadísticas por clase de vehículo";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(33, 96);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(151, 20);
            this.lblMes.TabIndex = 19;
            this.lblMes.Text = "Seleccione el mes:";
            // 
            // frmEstadClaseVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.imgEstadística);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblTítuloEstadística);
            this.Controls.Add(this.lblSubtítuloEstadística);
            this.Controls.Add(this.lblMes);
            this.Name = "frmEstadClaseVehiculo";
            this.Text = "ESTADÍSTICAS POR CLASE DE VEHÍCULO";
            this.Load += new System.EventHandler(this.frmEstadClaseVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgEstadística)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgEstadística;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblTítuloEstadística;
        private System.Windows.Forms.Label lblSubtítuloEstadística;
        private System.Windows.Forms.Label lblMes;
    }
}