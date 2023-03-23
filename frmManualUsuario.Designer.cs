namespace Proyecto
{
    partial class frmManualUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManualUsuario));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.imgManual = new System.Windows.Forms.PictureBox();
            this.lblIndicacionesManual = new System.Windows.Forms.Label();
            this.lblTítuloManual = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(581, 338);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnRegresar.Location = new System.Drawing.Point(394, 338);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 46);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // imgManual
            // 
            this.imgManual.Image = ((System.Drawing.Image)(resources.GetObject("imgManual.Image")));
            this.imgManual.Location = new System.Drawing.Point(311, 170);
            this.imgManual.Name = "imgManual";
            this.imgManual.Size = new System.Drawing.Size(110, 112);
            this.imgManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgManual.TabIndex = 13;
            this.imgManual.TabStop = false;
            this.imgManual.Click += new System.EventHandler(this.imgManual_Click);
            // 
            // lblIndicacionesManual
            // 
            this.lblIndicacionesManual.AutoSize = true;
            this.lblIndicacionesManual.Location = new System.Drawing.Point(217, 132);
            this.lblIndicacionesManual.Name = "lblIndicacionesManual";
            this.lblIndicacionesManual.Size = new System.Drawing.Size(325, 16);
            this.lblIndicacionesManual.TabIndex = 12;
            this.lblIndicacionesManual.Text = "Seleccione la imagen para abrir el manual de usuario";
            // 
            // lblTítuloManual
            // 
            this.lblTítuloManual.AutoSize = true;
            this.lblTítuloManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítuloManual.Location = new System.Drawing.Point(264, 91);
            this.lblTítuloManual.Name = "lblTítuloManual";
            this.lblTítuloManual.Size = new System.Drawing.Size(205, 20);
            this.lblTítuloManual.TabIndex = 10;
            this.lblTítuloManual.Text = "MANUAL DE USUARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmManualUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.imgManual);
            this.Controls.Add(this.lblIndicacionesManual);
            this.Controls.Add(this.lblTítuloManual);
            this.Name = "frmManualUsuario";
            this.Text = "MANUAL DE USUARIO";
            ((System.ComponentModel.ISupportInitialize)(this.imgManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox imgManual;
        private System.Windows.Forms.Label lblIndicacionesManual;
        private System.Windows.Forms.Label lblTítuloManual;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}