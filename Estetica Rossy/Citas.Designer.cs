﻿
namespace Estetica_Rossy
{
    partial class Citas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGCitas = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblEsteticaRossy = new System.Windows.Forms.Label();
            this.CMBCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dTFechaCita = new System.Windows.Forms.DateTimePicker();
            this.CMBHoraFin_AMPM = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCitas = new System.Windows.Forms.Label();
            this.ImgActualiar = new System.Windows.Forms.PictureBox();
            this.dTPBuscar = new System.Windows.Forms.DateTimePicker();
            this.CMBHoraInicio_Hora = new System.Windows.Forms.ComboBox();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.CBCancelacion = new System.Windows.Forms.CheckBox();
            this.CMBHoraInicio_Minuto = new System.Windows.Forms.ComboBox();
            this.CMBHoraInicio_AMPM = new System.Windows.Forms.ComboBox();
            this.CMBHoraFin_Hora = new System.Windows.Forms.ComboBox();
            this.CMBHoraFin_Minuto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGCitas)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).BeginInit();
            this.SuspendLayout();
            // 
            // dGCitas
            // 
            this.dGCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGCitas.Location = new System.Drawing.Point(9, 377);
            this.dGCitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGCitas.Name = "dGCitas";
            this.dGCitas.RowHeadersWidth = 51;
            this.dGCitas.RowTemplate.Height = 24;
            this.dGCitas.Size = new System.Drawing.Size(664, 258);
            this.dGCitas.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(9, 337);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(74, 24);
            this.lblBuscar.TabIndex = 24;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblEsteticaRossy
            // 
            this.lblEsteticaRossy.AutoSize = true;
            this.lblEsteticaRossy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsteticaRossy.Location = new System.Drawing.Point(218, 15);
            this.lblEsteticaRossy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEsteticaRossy.Name = "lblEsteticaRossy";
            this.lblEsteticaRossy.Size = new System.Drawing.Size(249, 39);
            this.lblEsteticaRossy.TabIndex = 26;
            this.lblEsteticaRossy.Text = "Estética Rossy";
            // 
            // CMBCliente
            // 
            this.CMBCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBCliente.FormattingEnabled = true;
            this.CMBCliente.Location = new System.Drawing.Point(490, 197);
            this.CMBCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMBCliente.Name = "CMBCliente";
            this.CMBCliente.Size = new System.Drawing.Size(183, 28);
            this.CMBCliente.TabIndex = 29;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(421, 200);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(65, 20);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(11, 196);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 20);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(333, 297);
            this.lblHoraFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(78, 20);
            this.lblHoraFin.TabIndex = 34;
            this.lblHoraFin.Text = "Hora Fin";
            // 
            // dTFechaCita
            // 
            this.dTFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTFechaCita.Location = new System.Drawing.Point(86, 196);
            this.dTFechaCita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTFechaCita.Name = "dTFechaCita";
            this.dTFechaCita.Size = new System.Drawing.Size(318, 26);
            this.dTFechaCita.TabIndex = 36;
            // 
            // CMBHoraFin_AMPM
            // 
            this.CMBHoraFin_AMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHoraFin_AMPM.FormattingEnabled = true;
            this.CMBHoraFin_AMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.CMBHoraFin_AMPM.Location = new System.Drawing.Point(597, 294);
            this.CMBHoraFin_AMPM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMBHoraFin_AMPM.Name = "CMBHoraFin_AMPM";
            this.CMBHoraFin_AMPM.Size = new System.Drawing.Size(74, 28);
            this.CMBHoraFin_AMPM.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblEsteticaRossy);
            this.panel1.Location = new System.Drawing.Point(2, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 116);
            this.panel1.TabIndex = 38;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(10, 88);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 20);
            this.lblCargo.TabIndex = 44;
            this.lblCargo.Text = "Cargo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(8, 60);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 20);
            this.lblUsuario.TabIndex = 27;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirCitaToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // añadirCitaToolStripMenuItem
            // 
            this.añadirCitaToolStripMenuItem.Name = "añadirCitaToolStripMenuItem";
            this.añadirCitaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.añadirCitaToolStripMenuItem.Text = "Añadir Cita";
            this.añadirCitaToolStripMenuItem.Click += new System.EventHandler(this.añadirCitaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.Location = new System.Drawing.Point(9, 144);
            this.lblCitas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(87, 36);
            this.lblCitas.TabIndex = 40;
            this.lblCitas.Text = "Citas";
            // 
            // ImgActualiar
            // 
            this.ImgActualiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgActualiar.Image = global::Estetica_Rossy.Properties.Resources.Actualizar;
            this.ImgActualiar.Location = new System.Drawing.Point(638, 153);
            this.ImgActualiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImgActualiar.Name = "ImgActualiar";
            this.ImgActualiar.Size = new System.Drawing.Size(34, 36);
            this.ImgActualiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgActualiar.TabIndex = 41;
            this.ImgActualiar.TabStop = false;
            this.ImgActualiar.Click += new System.EventHandler(this.ImgActualiar_Click);
            // 
            // dTPBuscar
            // 
            this.dTPBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPBuscar.Location = new System.Drawing.Point(98, 337);
            this.dTPBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTPBuscar.Name = "dTPBuscar";
            this.dTPBuscar.Size = new System.Drawing.Size(528, 26);
            this.dTPBuscar.TabIndex = 42;
            this.dTPBuscar.ValueChanged += new System.EventHandler(this.dTPBuscar_ValueChanged);
            // 
            // CMBHoraInicio_Hora
            // 
            this.CMBHoraInicio_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHoraInicio_Hora.FormattingEnabled = true;
            this.CMBHoraInicio_Hora.Location = new System.Drawing.Point(415, 246);
            this.CMBHoraInicio_Hora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMBHoraInicio_Hora.Name = "CMBHoraInicio_Hora";
            this.CMBHoraInicio_Hora.Size = new System.Drawing.Size(87, 28);
            this.CMBHoraInicio_Hora.TabIndex = 45;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(315, 254);
            this.lblHoraInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(96, 20);
            this.lblHoraInicio.TabIndex = 44;
            this.lblHoraInicio.Text = "Hora Inicio";
            // 
            // CBCancelacion
            // 
            this.CBCancelacion.AutoSize = true;
            this.CBCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCancelacion.Location = new System.Drawing.Point(15, 244);
            this.CBCancelacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBCancelacion.Name = "CBCancelacion";
            this.CBCancelacion.Size = new System.Drawing.Size(120, 28);
            this.CBCancelacion.TabIndex = 46;
            this.CBCancelacion.Text = "Cancelado";
            this.CBCancelacion.UseVisualStyleBackColor = true;
            // 
            // CMBHoraInicio_Minuto
            // 
            this.CMBHoraInicio_Minuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHoraInicio_Minuto.FormattingEnabled = true;
            this.CMBHoraInicio_Minuto.Location = new System.Drawing.Point(506, 246);
            this.CMBHoraInicio_Minuto.Margin = new System.Windows.Forms.Padding(2);
            this.CMBHoraInicio_Minuto.Name = "CMBHoraInicio_Minuto";
            this.CMBHoraInicio_Minuto.Size = new System.Drawing.Size(87, 28);
            this.CMBHoraInicio_Minuto.TabIndex = 45;
            // 
            // CMBHoraInicio_AMPM
            // 
            this.CMBHoraInicio_AMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHoraInicio_AMPM.FormattingEnabled = true;
            this.CMBHoraInicio_AMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.CMBHoraInicio_AMPM.Location = new System.Drawing.Point(597, 246);
            this.CMBHoraInicio_AMPM.Margin = new System.Windows.Forms.Padding(2);
            this.CMBHoraInicio_AMPM.Name = "CMBHoraInicio_AMPM";
            this.CMBHoraInicio_AMPM.Size = new System.Drawing.Size(74, 28);
            this.CMBHoraInicio_AMPM.TabIndex = 45;
            // 
            // CMBHoraFin_Hora
            // 
            this.CMBHoraFin_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHoraFin_Hora.FormattingEnabled = true;
            this.CMBHoraFin_Hora.Location = new System.Drawing.Point(415, 294);
            this.CMBHoraFin_Hora.Margin = new System.Windows.Forms.Padding(2);
            this.CMBHoraFin_Hora.Name = "CMBHoraFin_Hora";
            this.CMBHoraFin_Hora.Size = new System.Drawing.Size(87, 28);
            this.CMBHoraFin_Hora.TabIndex = 37;
            // 
            // CMBHoraFin_Minuto
            // 
            this.CMBHoraFin_Minuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHoraFin_Minuto.FormattingEnabled = true;
            this.CMBHoraFin_Minuto.Location = new System.Drawing.Point(506, 294);
            this.CMBHoraFin_Minuto.Margin = new System.Windows.Forms.Padding(2);
            this.CMBHoraFin_Minuto.Name = "CMBHoraFin_Minuto";
            this.CMBHoraFin_Minuto.Size = new System.Drawing.Size(87, 28);
            this.CMBHoraFin_Minuto.TabIndex = 37;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(682, 646);
            this.Controls.Add(this.CBCancelacion);
            this.Controls.Add(this.CMBHoraInicio_AMPM);
            this.Controls.Add(this.CMBHoraInicio_Minuto);
            this.Controls.Add(this.CMBHoraInicio_Hora);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.dTPBuscar);
            this.Controls.Add(this.ImgActualiar);
            this.Controls.Add(this.lblCitas);
            this.Controls.Add(this.CMBHoraFin_Minuto);
            this.Controls.Add(this.CMBHoraFin_Hora);
            this.Controls.Add(this.CMBHoraFin_AMPM);
            this.Controls.Add(this.dTFechaCita);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.CMBCliente);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dGCitas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGCitas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGCitas;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblEsteticaRossy;
        private System.Windows.Forms.ComboBox CMBCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dTFechaCita;
        private System.Windows.Forms.ComboBox CMBHoraFin_AMPM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirCitaToolStripMenuItem;
        private System.Windows.Forms.PictureBox ImgActualiar;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dTPBuscar;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox CMBHoraInicio_Hora;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.CheckBox CBCancelacion;
        private System.Windows.Forms.ComboBox CMBHoraInicio_Minuto;
        private System.Windows.Forms.ComboBox CMBHoraInicio_AMPM;
        private System.Windows.Forms.ComboBox CMBHoraFin_Hora;
        private System.Windows.Forms.ComboBox CMBHoraFin_Minuto;
    }
}