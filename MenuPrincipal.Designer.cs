namespace Proyecto
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prereservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoContactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoVehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoLocalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoMediosDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoEstadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoEstadoDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaPorCalseDeVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaDeIngresosTotalesPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNformesDeEstadoDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.estadísticaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1067, 28);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip1";
            this.menuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuPrincipal_ItemClicked);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prereservaToolStripMenuItem,
            this.facturarReservaToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // prereservaToolStripMenuItem
            // 
            this.prereservaToolStripMenuItem.Name = "prereservaToolStripMenuItem";
            this.prereservaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.prereservaToolStripMenuItem.Text = "Pre-reserva";
            this.prereservaToolStripMenuItem.Click += new System.EventHandler(this.prereservaToolStripMenuItem_Click);
            // 
            // facturarReservaToolStripMenuItem
            // 
            this.facturarReservaToolStripMenuItem.Name = "facturarReservaToolStripMenuItem";
            this.facturarReservaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.facturarReservaToolStripMenuItem.Text = "Facturar reserva";
            this.facturarReservaToolStripMenuItem.Click += new System.EventHandler(this.facturarReservaToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogoPersonasToolStripMenuItem,
            this.catalogoContactosToolStripMenuItem,
            this.catálogoPerfilesToolStripMenuItem,
            this.catálogoClasesToolStripMenuItem,
            this.catálogoVehículosToolStripMenuItem,
            this.catálogoServiciosToolStripMenuItem,
            this.catálogoLocalidadesToolStripMenuItem,
            this.catálogoUsuariosToolStripMenuItem,
            this.catalogoMediosDePagoToolStripMenuItem,
            this.catálogoEstadosToolStripMenuItem,
            this.catálogoEstadoDeReservasToolStripMenuItem,
            this.catálogoReservasToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // catálogoPersonasToolStripMenuItem
            // 
            this.catálogoPersonasToolStripMenuItem.Name = "catálogoPersonasToolStripMenuItem";
            this.catálogoPersonasToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catálogoPersonasToolStripMenuItem.Text = "Catálogo personas";
            this.catálogoPersonasToolStripMenuItem.Click += new System.EventHandler(this.catálogoPersonasToolStripMenuItem_Click);
            // 
            // catalogoContactosToolStripMenuItem
            // 
            this.catalogoContactosToolStripMenuItem.Name = "catalogoContactosToolStripMenuItem";
            this.catalogoContactosToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catalogoContactosToolStripMenuItem.Text = "Catálogo contactos";
            this.catalogoContactosToolStripMenuItem.Click += new System.EventHandler(this.catalogoContactosToolStripMenuItem_Click);
            // 
            // catálogoPerfilesToolStripMenuItem
            // 
            this.catálogoPerfilesToolStripMenuItem.Name = "catálogoPerfilesToolStripMenuItem";
            this.catálogoPerfilesToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catálogoPerfilesToolStripMenuItem.Text = "Catálogo perfiles";
            this.catálogoPerfilesToolStripMenuItem.Click += new System.EventHandler(this.catálogoPerfilesToolStripMenuItem_Click);
            // 
            // catálogoClasesToolStripMenuItem
            // 
            this.catálogoClasesToolStripMenuItem.Name = "catálogoClasesToolStripMenuItem";
            this.catálogoClasesToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catálogoClasesToolStripMenuItem.Text = "Catálogo clases";
            this.catálogoClasesToolStripMenuItem.Click += new System.EventHandler(this.catálogoClasesToolStripMenuItem_Click);
            // 
            // catálogoVehículosToolStripMenuItem
            // 
            this.catálogoVehículosToolStripMenuItem.Name = "catálogoVehículosToolStripMenuItem";
            this.catálogoVehículosToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catálogoVehículosToolStripMenuItem.Text = "Catálogo vehículos";
            this.catálogoVehículosToolStripMenuItem.Click += new System.EventHandler(this.catálogoVehículosToolStripMenuItem_Click);
            // 
            // catálogoServiciosToolStripMenuItem
            // 
            this.catálogoServiciosToolStripMenuItem.Name = "catálogoServiciosToolStripMenuItem";
            this.catálogoServiciosToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catálogoServiciosToolStripMenuItem.Text = "Catálogo servicios";
            this.catálogoServiciosToolStripMenuItem.Click += new System.EventHandler(this.catálogoServiciosToolStripMenuItem_Click);
            // 
            // catálogoLocalidadesToolStripMenuItem
            // 
            this.catálogoLocalidadesToolStripMenuItem.Name = "catálogoLocalidadesToolStripMenuItem";
            this.catálogoLocalidadesToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catálogoLocalidadesToolStripMenuItem.Text = "Catálogo localidades";
            this.catálogoLocalidadesToolStripMenuItem.Click += new System.EventHandler(this.catálogoLocalidadesToolStripMenuItem_Click);
            // 
            // catálogoUsuariosToolStripMenuItem
            // 
            this.catálogoUsuariosToolStripMenuItem.Name = "catálogoUsuariosToolStripMenuItem";
            this.catálogoUsuariosToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catálogoUsuariosToolStripMenuItem.Text = "Catálogo usuarios";
            this.catálogoUsuariosToolStripMenuItem.Click += new System.EventHandler(this.catálogoUsuariosToolStripMenuItem_Click);
            // 
            // catalogoMediosDePagoToolStripMenuItem
            // 
            this.catalogoMediosDePagoToolStripMenuItem.Name = "catalogoMediosDePagoToolStripMenuItem";
            this.catalogoMediosDePagoToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catalogoMediosDePagoToolStripMenuItem.Text = "Catálogo medios de pago";
            this.catalogoMediosDePagoToolStripMenuItem.Click += new System.EventHandler(this.catalogoMediosDePagoToolStripMenuItem_Click);
            // 
            // catálogoEstadosToolStripMenuItem
            // 
            this.catálogoEstadosToolStripMenuItem.Name = "catálogoEstadosToolStripMenuItem";
            this.catálogoEstadosToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catálogoEstadosToolStripMenuItem.Text = "Catálogo estados";
            this.catálogoEstadosToolStripMenuItem.Click += new System.EventHandler(this.catálogoEstadosToolStripMenuItem_Click);
            // 
            // catálogoEstadoDeReservasToolStripMenuItem
            // 
            this.catálogoEstadoDeReservasToolStripMenuItem.Name = "catálogoEstadoDeReservasToolStripMenuItem";
            this.catálogoEstadoDeReservasToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catálogoEstadoDeReservasToolStripMenuItem.Text = "Catálogo estado de reservas";
            this.catálogoEstadoDeReservasToolStripMenuItem.Click += new System.EventHandler(this.catálogoEstadoDeReservasToolStripMenuItem_Click);
            // 
            // catálogoReservasToolStripMenuItem
            // 
            this.catálogoReservasToolStripMenuItem.Name = "catálogoReservasToolStripMenuItem";
            this.catálogoReservasToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.catálogoReservasToolStripMenuItem.Text = "Catálogo reservas";
            this.catálogoReservasToolStripMenuItem.Click += new System.EventHandler(this.catálogoReservasToolStripMenuItem_Click);
            // 
            // estadísticaToolStripMenuItem
            // 
            this.estadísticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadísticaPorCalseDeVehículoToolStripMenuItem,
            this.estadísticaDeIngresosTotalesPorMesToolStripMenuItem});
            this.estadísticaToolStripMenuItem.Name = "estadísticaToolStripMenuItem";
            this.estadísticaToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.estadísticaToolStripMenuItem.Text = "Estadística";
            // 
            // estadísticaPorCalseDeVehículoToolStripMenuItem
            // 
            this.estadísticaPorCalseDeVehículoToolStripMenuItem.Name = "estadísticaPorCalseDeVehículoToolStripMenuItem";
            this.estadísticaPorCalseDeVehículoToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.estadísticaPorCalseDeVehículoToolStripMenuItem.Text = "Estadística por clase de vehículo";
            this.estadísticaPorCalseDeVehículoToolStripMenuItem.Click += new System.EventHandler(this.estadísticaPorCalseDeVehículoToolStripMenuItem_Click);
            // 
            // estadísticaDeIngresosTotalesPorMesToolStripMenuItem
            // 
            this.estadísticaDeIngresosTotalesPorMesToolStripMenuItem.Name = "estadísticaDeIngresosTotalesPorMesToolStripMenuItem";
            this.estadísticaDeIngresosTotalesPorMesToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.estadísticaDeIngresosTotalesPorMesToolStripMenuItem.Text = "Estadística de ingresos totales por mes";
            this.estadísticaDeIngresosTotalesPorMesToolStripMenuItem.Click += new System.EventHandler(this.estadísticaDeIngresosTotalesPorMesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNformesDeEstadoDeReservasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // iNformesDeEstadoDeReservasToolStripMenuItem
            // 
            this.iNformesDeEstadoDeReservasToolStripMenuItem.Name = "iNformesDeEstadoDeReservasToolStripMenuItem";
            this.iNformesDeEstadoDeReservasToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.iNformesDeEstadoDeReservasToolStripMenuItem.Text = "Informes de estado de reservas";
            this.iNformesDeEstadoDeReservasToolStripMenuItem.Click += new System.EventHandler(this.iNformesDeEstadoDeReservasToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditosToolStripMenuItem,
            this.manualDeUsuarioToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.créditosToolStripMenuItem.Text = "Créditos";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prereservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoContactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoPerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoVehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoLocalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoMediosDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoEstadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoEstadoDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaPorCalseDeVehículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaDeIngresosTotalesPorMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNformesDeEstadoDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}