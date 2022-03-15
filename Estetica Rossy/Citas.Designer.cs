
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
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasDeHoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasCanceladasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasLasCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCitas = new System.Windows.Forms.Label();
            this.dTPBuscar = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.CBCancelacion = new System.Windows.Forms.CheckBox();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.ImgActualiar = new System.Windows.Forms.PictureBox();
            this.ImgCancelar = new System.Windows.Forms.PictureBox();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.imprimirCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasDeHoyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citasDeLaSemanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGCitas)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // dGCitas
            // 
            this.dGCitas.AllowUserToAddRows = false;
            this.dGCitas.AllowUserToDeleteRows = false;
            this.dGCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGCitas.Location = new System.Drawing.Point(8, 466);
            this.dGCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGCitas.MultiSelect = false;
            this.dGCitas.Name = "dGCitas";
            this.dGCitas.ReadOnly = true;
            this.dGCitas.RowHeadersWidth = 51;
            this.dGCitas.RowTemplate.Height = 24;
            this.dGCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGCitas.Size = new System.Drawing.Size(885, 318);
            this.dGCitas.TabIndex = 0;
            this.dGCitas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGCitas_CellDoubleClick);
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
            this.lblEsteticaRossy.Location = new System.Drawing.Point(298, 18);
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
            this.lblFecha.Location = new System.Drawing.Point(16, 246);
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
            this.panel1.Location = new System.Drawing.Point(1, 30);
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
            this.eliminarToolStripMenuItem,
            this.mostrarToolStripMenuItem,
            this.imprimirCitasToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // añadirCitaToolStripMenuItem
            // 
            this.añadirCitaToolStripMenuItem.Name = "añadirCitaToolStripMenuItem";
            this.añadirCitaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.añadirCitaToolStripMenuItem.Text = "Añadir Cita";
            this.añadirCitaToolStripMenuItem.Click += new System.EventHandler(this.añadirCitaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificarToolStripMenuItem.Text = "Modificar datos";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar cita";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasDeHoyToolStripMenuItem,
            this.citasCanceladasToolStripMenuItem,
            this.todasLasCitasToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mostrarToolStripMenuItem.Text = "Mostrar...";
            // 
            // citasDeHoyToolStripMenuItem
            // 
            this.citasDeHoyToolStripMenuItem.Name = "citasDeHoyToolStripMenuItem";
            this.citasDeHoyToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.citasDeHoyToolStripMenuItem.Text = "Citas de hoy";
            this.citasDeHoyToolStripMenuItem.Click += new System.EventHandler(this.citasDeHoyToolStripMenuItem_Click);
            // 
            // citasCanceladasToolStripMenuItem
            // 
            this.citasCanceladasToolStripMenuItem.Name = "citasCanceladasToolStripMenuItem";
            this.citasCanceladasToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.citasCanceladasToolStripMenuItem.Text = "Citas canceladas";
            this.citasCanceladasToolStripMenuItem.Click += new System.EventHandler(this.citasCanceladasToolStripMenuItem_Click);
            // 
            // todasLasCitasToolStripMenuItem
            // 
            this.todasLasCitasToolStripMenuItem.Name = "todasLasCitasToolStripMenuItem";
            this.todasLasCitasToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.todasLasCitasToolStripMenuItem.Text = "Todas las citas";
            this.todasLasCitasToolStripMenuItem.Click += new System.EventHandler(this.todasLasCitasToolStripMenuItem_Click);
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
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(561, 309);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(115, 25);
            this.lblHoraInicio.TabIndex = 44;
            this.lblHoraInicio.Text = "Hora Inicio";
            // 
            // CBCancelacion
            // 
            this.CBCancelacion.AutoSize = true;
            this.CBCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCancelacion.Location = new System.Drawing.Point(21, 361);
            this.CBCancelacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBCancelacion.Name = "CBCancelacion";
            this.CBCancelacion.Size = new System.Drawing.Size(151, 33);
            this.CBCancelacion.TabIndex = 46;
            this.CBCancelacion.Text = "Cancelado";
            this.CBCancelacion.UseVisualStyleBackColor = true;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamiento.Location = new System.Drawing.Point(149, 303);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(385, 30);
            this.txtTratamiento.TabIndex = 47;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.Location = new System.Drawing.Point(12, 306);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(127, 25);
            this.lblTratamiento.TabIndex = 31;
            this.lblTratamiento.Text = "Tratamiento";
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
            // ImgCancelar
            // 
            this.ImgCancelar.Image = global::Estetica_Rossy.Properties.Resources.cancelar;
            this.ImgCancelar.Location = new System.Drawing.Point(789, 190);
            this.ImgCancelar.Name = "ImgCancelar";
            this.ImgCancelar.Size = new System.Drawing.Size(42, 42);
            this.ImgCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCancelar.TabIndex = 48;
            this.ImgCancelar.TabStop = false;
            this.ImgCancelar.Click += new System.EventHandler(this.ImgCancelar_Click);
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraInicio.Location = new System.Drawing.Point(710, 306);
            this.txtHoraInicio.MaxLength = 10;
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(183, 30);
            this.txtHoraInicio.TabIndex = 47;
            // 
            // imprimirCitasToolStripMenuItem
            // 
            this.imprimirCitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasDeHoyToolStripMenuItem1,
            this.citasDeLaSemanaToolStripMenuItem});
            this.imprimirCitasToolStripMenuItem.Name = "imprimirCitasToolStripMenuItem";
            this.imprimirCitasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imprimirCitasToolStripMenuItem.Text = "Imprimir Citas...";
            // 
            // citasDeHoyToolStripMenuItem1
            // 
            this.citasDeHoyToolStripMenuItem1.Name = "citasDeHoyToolStripMenuItem1";
            this.citasDeHoyToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.citasDeHoyToolStripMenuItem1.Text = "Citas de Hoy";
            // 
            // citasDeLaSemanaToolStripMenuItem
            // 
            this.citasDeLaSemanaToolStripMenuItem.Name = "citasDeLaSemanaToolStripMenuItem";
            this.citasDeLaSemanaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.citasDeLaSemanaToolStripMenuItem.Text = "Citas de la semana";
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(909, 795);
            this.Controls.Add(this.ImgCancelar);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.CBCancelacion);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.dTPBuscar);
            this.Controls.Add(this.ImgActualiar);
            this.Controls.Add(this.lblCitas);
            this.Controls.Add(this.dTFechaCita);
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
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).EndInit();
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
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.CheckBox CBCancelacion;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.PictureBox ImgCancelar;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasDeHoyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasCanceladasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasLasCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasDeHoyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citasDeLaSemanaToolStripMenuItem;
    }
}