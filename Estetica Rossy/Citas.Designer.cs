
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
            this.dTFechaCita = new System.Windows.Forms.DateTimePicker();
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
            this.CMBHoraInicio_AMPM = new System.Windows.Forms.ComboBox();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.CMBHoraFin_AMPM = new System.Windows.Forms.ComboBox();
            this.CMBHoraFin_Hora = new System.Windows.Forms.ComboBox();
            this.lblHoraFin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGCitas)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).BeginInit();
            this.SuspendLayout();
            // 
            // dGCitas
            // 
            this.dGCitas.AllowUserToAddRows = false;
            this.dGCitas.AllowUserToDeleteRows = false;
            this.dGCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGCitas.Location = new System.Drawing.Point(8, 466);
            this.dGCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGCitas.Name = "dGCitas";
            this.dGCitas.ReadOnly = true;
            this.dGCitas.RowHeadersWidth = 51;
            this.dGCitas.RowTemplate.Height = 24;
            this.dGCitas.Size = new System.Drawing.Size(885, 318);
            this.dGCitas.TabIndex = 0;
            this.dGCitas.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGCitas_RowHeaderMouseDoubleClick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(12, 415);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(93, 29);
            this.lblBuscar.TabIndex = 24;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblEsteticaRossy
            // 
            this.lblEsteticaRossy.AutoSize = true;
            this.lblEsteticaRossy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsteticaRossy.Location = new System.Drawing.Point(291, 18);
            this.lblEsteticaRossy.Name = "lblEsteticaRossy";
            this.lblEsteticaRossy.Size = new System.Drawing.Size(309, 51);
            this.lblEsteticaRossy.TabIndex = 26;
            this.lblEsteticaRossy.Text = "Estética Rossy";
            // 
            // CMBCliente
            // 
            this.CMBCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBCliente.FormattingEnabled = true;
            this.CMBCliente.Location = new System.Drawing.Point(653, 242);
            this.CMBCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBCliente.Name = "CMBCliente";
            this.CMBCliente.Size = new System.Drawing.Size(243, 33);
            this.CMBCliente.TabIndex = 29;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(561, 246);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(80, 25);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(15, 241);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 25);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha";
            // 
            // dTFechaCita
            // 
            this.dTFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTFechaCita.Location = new System.Drawing.Point(115, 241);
            this.dTFechaCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTFechaCita.Name = "dTFechaCita";
            this.dTFechaCita.Size = new System.Drawing.Size(423, 30);
            this.dTFechaCita.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblEsteticaRossy);
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 143);
            this.panel1.TabIndex = 38;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(13, 108);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(66, 25);
            this.lblCargo.TabIndex = 44;
            this.lblCargo.Text = "Cargo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(11, 74);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 25);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(909, 28);
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
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // añadirCitaToolStripMenuItem
            // 
            this.añadirCitaToolStripMenuItem.Name = "añadirCitaToolStripMenuItem";
            this.añadirCitaToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.añadirCitaToolStripMenuItem.Text = "Añadir Cita";
            this.añadirCitaToolStripMenuItem.Click += new System.EventHandler(this.añadirCitaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.Location = new System.Drawing.Point(12, 177);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(112, 44);
            this.lblCitas.TabIndex = 40;
            this.lblCitas.Text = "Citas";
            // 
            // ImgActualiar
            // 
            this.ImgActualiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgActualiar.Image = global::Estetica_Rossy.Properties.Resources.Actualizar;
            this.ImgActualiar.Location = new System.Drawing.Point(851, 188);
            this.ImgActualiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImgActualiar.Name = "ImgActualiar";
            this.ImgActualiar.Size = new System.Drawing.Size(45, 44);
            this.ImgActualiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgActualiar.TabIndex = 41;
            this.ImgActualiar.TabStop = false;
            this.ImgActualiar.Click += new System.EventHandler(this.ImgActualiar_Click);
            // 
            // dTPBuscar
            // 
            this.dTPBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPBuscar.Location = new System.Drawing.Point(131, 415);
            this.dTPBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPBuscar.Name = "dTPBuscar";
            this.dTPBuscar.Size = new System.Drawing.Size(762, 30);
            this.dTPBuscar.TabIndex = 42;
            this.dTPBuscar.ValueChanged += new System.EventHandler(this.dTPBuscar_ValueChanged);
            // 
            // CMBHoraInicio_Hora
            // 
            this.CMBHoraInicio_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHoraInicio_Hora.FormattingEnabled = true;
            this.CMBHoraInicio_Hora.Location = new System.Drawing.Point(675, 301);
            this.CMBHoraInicio_Hora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBHoraInicio_Hora.Name = "CMBHoraInicio_Hora";
            this.CMBHoraInicio_Hora.Size = new System.Drawing.Size(115, 33);
            this.CMBHoraInicio_Hora.TabIndex = 45;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(542, 311);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(115, 25);
            this.lblHoraInicio.TabIndex = 44;
            this.lblHoraInicio.Text = "Hora Inicio";
            // 
            // CBCancelacion
            // 
            this.CBCancelacion.AutoSize = true;
            this.CBCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCancelacion.Location = new System.Drawing.Point(20, 300);
            this.CBCancelacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBCancelacion.Name = "CBCancelacion";
            this.CBCancelacion.Size = new System.Drawing.Size(151, 33);
            this.CBCancelacion.TabIndex = 46;
            this.CBCancelacion.Text = "Cancelado";
            this.CBCancelacion.UseVisualStyleBackColor = true;
            // 
            // CMBHoraInicio_AMPM
            // 
            this.CMBHoraInicio_AMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHoraInicio_AMPM.FormattingEnabled = true;
            this.CMBHoraInicio_AMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.CMBHoraInicio_AMPM.Location = new System.Drawing.Point(796, 303);
            this.CMBHoraInicio_AMPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBHoraInicio_AMPM.Name = "CMBHoraInicio_AMPM";
            this.CMBHoraInicio_AMPM.Size = new System.Drawing.Size(97, 33);
            this.CMBHoraInicio_AMPM.TabIndex = 45;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamiento.Location = new System.Drawing.Point(17, 363);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(385, 30);
            this.txtTratamiento.TabIndex = 47;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.Location = new System.Drawing.Point(16, 335);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(127, 25);
            this.lblTratamiento.TabIndex = 31;
            this.lblTratamiento.Text = "Tratamiento";
            // 
            // CMBHoraFin_AMPM
            // 
            this.CMBHoraFin_AMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHoraFin_AMPM.FormattingEnabled = true;
            this.CMBHoraFin_AMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.CMBHoraFin_AMPM.Location = new System.Drawing.Point(796, 362);
            this.CMBHoraFin_AMPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBHoraFin_AMPM.Name = "CMBHoraFin_AMPM";
            this.CMBHoraFin_AMPM.Size = new System.Drawing.Size(97, 33);
            this.CMBHoraFin_AMPM.TabIndex = 37;
            // 
            // CMBHoraFin_Hora
            // 
            this.CMBHoraFin_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHoraFin_Hora.FormattingEnabled = true;
            this.CMBHoraFin_Hora.Location = new System.Drawing.Point(675, 360);
            this.CMBHoraFin_Hora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBHoraFin_Hora.Name = "CMBHoraFin_Hora";
            this.CMBHoraFin_Hora.Size = new System.Drawing.Size(115, 33);
            this.CMBHoraFin_Hora.TabIndex = 37;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(566, 364);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(94, 25);
            this.lblHoraFin.TabIndex = 34;
            this.lblHoraFin.Text = "Hora Fin";
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(909, 795);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.CBCancelacion);
            this.Controls.Add(this.CMBHoraInicio_AMPM);
            this.Controls.Add(this.CMBHoraInicio_Hora);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.dTPBuscar);
            this.Controls.Add(this.ImgActualiar);
            this.Controls.Add(this.lblCitas);
            this.Controls.Add(this.CMBHoraFin_Hora);
            this.Controls.Add(this.CMBHoraFin_AMPM);
            this.Controls.Add(this.dTFechaCita);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblTratamiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.CMBCliente);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dGCitas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DateTimePicker dTFechaCita;
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
        private System.Windows.Forms.ComboBox CMBHoraInicio_AMPM;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.ComboBox CMBHoraFin_AMPM;
        private System.Windows.Forms.ComboBox CMBHoraFin_Hora;
        private System.Windows.Forms.Label lblHoraFin;
    }
}