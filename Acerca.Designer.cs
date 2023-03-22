namespace Proyecto
{
    partial class frmAcerca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcerca));
            this.lblTítulo = new System.Windows.Forms.Label();
            this.lblTítuloManual = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.lblIndicacionesManual = new System.Windows.Forms.Label();
            this.imgManual = new System.Windows.Forms.PictureBox();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgManual)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.Location = new System.Drawing.Point(90, 36);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(667, 25);
            this.lblTítulo.TabIndex = 0;
            this.lblTítulo.Text = "Proyecto programado para el curso II-60 Sistemas Computacionales";
            // 
            // lblTítuloManual
            // 
            this.lblTítuloManual.AutoSize = true;
            this.lblTítuloManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítuloManual.Location = new System.Drawing.Point(474, 119);
            this.lblTítuloManual.Name = "lblTítuloManual";
            this.lblTítuloManual.Size = new System.Drawing.Size(205, 20);
            this.lblTítuloManual.TabIndex = 1;
            this.lblTítuloManual.Text = "MANUAL DE USUARIO";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(30, 138);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(217, 160);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "\n- Joseph Fernández Murillo.\r\n\r\n- Gustavo Sánchez Gamez.\r\n\r\n- Abraham Vargas Hida" +
    "lgo. \r\n\r\n- Kimberly Víctor Castro.";
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProyecto.Location = new System.Drawing.Point(278, 71);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(214, 25);
            this.lblNombreProyecto.TabIndex = 3;
            this.lblNombreProyecto.Text = "Renta de un vehículo";
            // 
            // lblIndicacionesManual
            // 
            this.lblIndicacionesManual.AutoSize = true;
            this.lblIndicacionesManual.Location = new System.Drawing.Point(417, 143);
            this.lblIndicacionesManual.Name = "lblIndicacionesManual";
            this.lblIndicacionesManual.Size = new System.Drawing.Size(325, 16);
            this.lblIndicacionesManual.TabIndex = 4;
            this.lblIndicacionesManual.Text = "Seleccione la imagen para abrir el manual de usuario";
            // 
            // imgManual
            // 
            this.imgManual.Image = ((System.Drawing.Image)(resources.GetObject("imgManual.Image")));
            this.imgManual.Location = new System.Drawing.Point(529, 174);
            this.imgManual.Name = "imgManual";
            this.imgManual.Size = new System.Drawing.Size(110, 112);
            this.imgManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgManual.TabIndex = 5;
            this.imgManual.TabStop = false;
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.AutoSize = true;
            this.lblEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiantes.Location = new System.Drawing.Point(62, 119);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(142, 40);
            this.lblEstudiantes.TabIndex = 6;
            this.lblEstudiantes.Text = "ESTUDIANTES:\r\n\r\n";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnRegresar.Location = new System.Drawing.Point(445, 308);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 46);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar al menú";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(632, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 46);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAcerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(836, 366);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblEstudiantes);
            this.Controls.Add(this.imgManual);
            this.Controls.Add(this.lblIndicacionesManual);
            this.Controls.Add(this.lblNombreProyecto);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblTítuloManual);
            this.Controls.Add(this.lblTítulo);
            this.Name = "frmAcerca";
            this.Text = "ACERCA DE";
            ((System.ComponentModel.ISupportInitialize)(this.imgManual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Label lblTítuloManual;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Label lblIndicacionesManual;
        private System.Windows.Forms.PictureBox imgManual;
        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
    }
}