
namespace Estetica_Rossy
{
    partial class Orden
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
            this.dGOrden = new System.Windows.Forms.DataGridView();
            this.lblEsteticaRossy = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.ImgCancelar = new System.Windows.Forms.PictureBox();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.ImgActualiar = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.NUDCliente = new System.Windows.Forms.NumericUpDown();
            this.lblProducto = new System.Windows.Forms.Label();
            this.NUDProducto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.dGOrdenDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGOrdenDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dGOrden
            // 
            this.dGOrden.AllowUserToAddRows = false;
            this.dGOrden.AllowUserToDeleteRows = false;
            this.dGOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGOrden.Location = new System.Drawing.Point(15, 380);
            this.dGOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGOrden.MultiSelect = false;
            this.dGOrden.Name = "dGOrden";
            this.dGOrden.ReadOnly = true;
            this.dGOrden.RowHeadersWidth = 51;
            this.dGOrden.RowTemplate.Height = 24;
            this.dGOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGOrden.Size = new System.Drawing.Size(669, 345);
            this.dGOrden.TabIndex = 34;
            // 
            // lblEsteticaRossy
            // 
            this.lblEsteticaRossy.AutoSize = true;
            this.lblEsteticaRossy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsteticaRossy.Location = new System.Drawing.Point(514, 37);
            this.lblEsteticaRossy.Name = "lblEsteticaRossy";
            this.lblEsteticaRossy.Size = new System.Drawing.Size(309, 51);
            this.lblEsteticaRossy.TabIndex = 27;
            this.lblEsteticaRossy.Text = "Estética Rossy";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Enabled = false;
            this.txtNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreP.Location = new System.Drawing.Point(585, 227);
            this.txtNombreP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(276, 28);
            this.txtNombreP.TabIndex = 60;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(11, 114);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(66, 25);
            this.lblCargo.TabIndex = 46;
            this.lblCargo.Text = "Cargo";
            // 
            // ImgCancelar
            // 
            this.ImgCancelar.Image = global::Estetica_Rossy.Properties.Resources.cancelar;
            this.ImgCancelar.Location = new System.Drawing.Point(1066, 97);
            this.ImgCancelar.Name = "ImgCancelar";
            this.ImgCancelar.Size = new System.Drawing.Size(42, 42);
            this.ImgCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCancelar.TabIndex = 65;
            this.ImgCancelar.TabStop = false;
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDCantidad.Location = new System.Drawing.Point(141, 279);
            this.NUDCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.NUDCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(276, 30);
            this.NUDCantidad.TabIndex = 64;
            // 
            // ImgActualiar
            // 
            this.ImgActualiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgActualiar.Image = global::Estetica_Rossy.Properties.Resources.Actualizar;
            this.ImgActualiar.Location = new System.Drawing.Point(1125, 95);
            this.ImgActualiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImgActualiar.Name = "ImgActualiar";
            this.ImgActualiar.Size = new System.Drawing.Size(45, 44);
            this.ImgActualiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgActualiar.TabIndex = 61;
            this.ImgActualiar.TabStop = false;
            this.ImgActualiar.Click += new System.EventHandler(this.ImgActualiar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(19, 334);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(801, 30);
            this.txtBuscar.TabIndex = 59;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(475, 170);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 25);
            this.lblMarca.TabIndex = 53;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(7, 81);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 25);
            this.lblUsuario.TabIndex = 45;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 279);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(99, 25);
            this.lblCantidad.TabIndex = 56;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(14, 174);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(98, 25);
            this.lblIdCliente.TabIndex = 57;
            this.lblIdCliente.Text = "IdCliente";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(451, 230);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(98, 25);
            this.lblNombreProducto.TabIndex = 58;
            this.lblNombreProducto.Text = "Producto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.ImgCancelar);
            this.panel1.Controls.Add(this.lblEsteticaRossy);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.ImgActualiar);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 148);
            this.panel1.TabIndex = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 28);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivioToolStripMenuItem
            // 
            this.archivioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.añadirProductoToolStripMenuItem});
            this.archivioToolStripMenuItem.Name = "archivioToolStripMenuItem";
            this.archivioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivioToolStripMenuItem.Text = "Archivo";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.añadirToolStripMenuItem.Text = "Crear Orden";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // añadirProductoToolStripMenuItem
            // 
            this.añadirProductoToolStripMenuItem.Name = "añadirProductoToolStripMenuItem";
            this.añadirProductoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.añadirProductoToolStripMenuItem.Text = "Añadir Producto";
            this.añadirProductoToolStripMenuItem.Click += new System.EventHandler(this.añadirProductoToolStripMenuItem_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(585, 176);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(276, 28);
            this.txtCliente.TabIndex = 60;
            // 
            // NUDCliente
            // 
            this.NUDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDCliente.Location = new System.Drawing.Point(141, 174);
            this.NUDCliente.Margin = new System.Windows.Forms.Padding(4);
            this.NUDCliente.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDCliente.Name = "NUDCliente";
            this.NUDCliente.Size = new System.Drawing.Size(276, 30);
            this.NUDCliente.TabIndex = 62;
            this.NUDCliente.ValueChanged += new System.EventHandler(this.NUDCliente_ValueChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(14, 227);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(116, 25);
            this.lblProducto.TabIndex = 57;
            this.lblProducto.Text = "IdProducto";
            // 
            // NUDProducto
            // 
            this.NUDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDProducto.Location = new System.Drawing.Point(141, 227);
            this.NUDProducto.Margin = new System.Windows.Forms.Padding(4);
            this.NUDProducto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDProducto.Name = "NUDProducto";
            this.NUDProducto.Size = new System.Drawing.Size(276, 30);
            this.NUDProducto.TabIndex = 62;
            this.NUDProducto.ValueChanged += new System.EventHandler(this.NUDProducto_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Cliente";
            // 
            // NUDPrecio
            // 
            this.NUDPrecio.Enabled = false;
            this.NUDPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDPrecio.Location = new System.Drawing.Point(585, 279);
            this.NUDPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.NUDPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDPrecio.Name = "NUDPrecio";
            this.NUDPrecio.Size = new System.Drawing.Size(276, 30);
            this.NUDPrecio.TabIndex = 66;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(451, 281);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 25);
            this.lblPrecio.TabIndex = 65;
            this.lblPrecio.Text = "Precio";
            // 
            // dGOrdenDetalle
            // 
            this.dGOrdenDetalle.AllowUserToAddRows = false;
            this.dGOrdenDetalle.AllowUserToDeleteRows = false;
            this.dGOrdenDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGOrdenDetalle.Location = new System.Drawing.Point(690, 380);
            this.dGOrdenDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGOrdenDetalle.MultiSelect = false;
            this.dGOrdenDetalle.Name = "dGOrdenDetalle";
            this.dGOrdenDetalle.ReadOnly = true;
            this.dGOrdenDetalle.RowHeadersWidth = 51;
            this.dGOrdenDetalle.RowTemplate.Height = 24;
            this.dGOrdenDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGOrdenDetalle.Size = new System.Drawing.Size(628, 345);
            this.dGOrdenDetalle.TabIndex = 34;
            this.dGOrdenDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1355, 733);
            this.Controls.Add(this.NUDPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.NUDCantidad);
            this.Controls.Add(this.NUDCliente);
            this.Controls.Add(this.NUDProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGOrdenDetalle);
            this.Controls.Add(this.dGOrden);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Orden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden";
            this.Load += new System.EventHandler(this.Orden_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Orden_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dGOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGOrdenDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGOrden;
        private System.Windows.Forms.Label lblEsteticaRossy;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.PictureBox ImgCancelar;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private System.Windows.Forms.PictureBox ImgActualiar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.NumericUpDown NUDCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.NumericUpDown NUDProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ToolStripMenuItem añadirProductoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dGOrdenDetalle;
    }
}