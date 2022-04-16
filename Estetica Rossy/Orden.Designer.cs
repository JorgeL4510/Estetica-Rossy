
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orden));
            this.dGOrden = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEsteticaRossy = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgReset = new System.Windows.Forms.PictureBox();
            this.ImgImprimir = new System.Windows.Forms.PictureBox();
            this.ImgCancelar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.NUDCliente = new System.Windows.Forms.NumericUpDown();
            this.lblProducto = new System.Windows.Forms.Label();
            this.NUDProducto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.IMGLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dGOrden
            // 
            this.dGOrden.AllowUserToAddRows = false;
            this.dGOrden.AllowUserToDeleteRows = false;
            this.dGOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dGOrden.Location = new System.Drawing.Point(19, 430);
            this.dGOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGOrden.MultiSelect = false;
            this.dGOrden.Name = "dGOrden";
            this.dGOrden.ReadOnly = true;
            this.dGOrden.RowHeadersWidth = 51;
            this.dGOrden.RowTemplate.Height = 24;
            this.dGOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGOrden.Size = new System.Drawing.Size(842, 345);
            this.dGOrden.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdProducto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SubTotal";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // lblEsteticaRossy
            // 
            this.lblEsteticaRossy.AutoSize = true;
            this.lblEsteticaRossy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsteticaRossy.Location = new System.Drawing.Point(291, 38);
            this.lblEsteticaRossy.Name = "lblEsteticaRossy";
            this.lblEsteticaRossy.Size = new System.Drawing.Size(309, 51);
            this.lblEsteticaRossy.TabIndex = 27;
            this.lblEsteticaRossy.Text = "Estética Rossy";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Enabled = false;
            this.txtNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreP.Location = new System.Drawing.Point(585, 271);
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
            // NUDCantidad
            // 
            this.NUDCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDCantidad.Location = new System.Drawing.Point(141, 323);
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
            this.lblCantidad.Location = new System.Drawing.Point(12, 323);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(99, 25);
            this.lblCantidad.TabIndex = 56;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(14, 218);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(98, 25);
            this.lblIdCliente.TabIndex = 57;
            this.lblIdCliente.Text = "IdCliente";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(451, 274);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(98, 25);
            this.lblNombreProducto.TabIndex = 58;
            this.lblNombreProducto.Text = "Producto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.ImgReset);
            this.panel1.Controls.Add(this.ImgImprimir);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.ImgCancelar);
            this.panel1.Controls.Add(this.lblEsteticaRossy);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 148);
            this.panel1.TabIndex = 50;
            // 
            // ImgReset
            // 
            this.ImgReset.Image = global::Estetica_Rossy.Properties.Resources.reset;
            this.ImgReset.Location = new System.Drawing.Point(805, 95);
            this.ImgReset.Name = "ImgReset";
            this.ImgReset.Size = new System.Drawing.Size(44, 43);
            this.ImgReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgReset.TabIndex = 68;
            this.ImgReset.TabStop = false;
            this.ImgReset.Click += new System.EventHandler(this.ImgReset_Click);
            // 
            // ImgImprimir
            // 
            this.ImgImprimir.Image = global::Estetica_Rossy.Properties.Resources.imprimir;
            this.ImgImprimir.Location = new System.Drawing.Point(682, 95);
            this.ImgImprimir.Name = "ImgImprimir";
            this.ImgImprimir.Size = new System.Drawing.Size(45, 44);
            this.ImgImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgImprimir.TabIndex = 67;
            this.ImgImprimir.TabStop = false;
            this.ImgImprimir.Click += new System.EventHandler(this.ImgImprimir_Click);
            // 
            // ImgCancelar
            // 
            this.ImgCancelar.Image = global::Estetica_Rossy.Properties.Resources.cancelar;
            this.ImgCancelar.Location = new System.Drawing.Point(748, 95);
            this.ImgCancelar.Name = "ImgCancelar";
            this.ImgCancelar.Size = new System.Drawing.Size(42, 42);
            this.ImgCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCancelar.TabIndex = 65;
            this.ImgCancelar.TabStop = false;
            this.ImgCancelar.Click += new System.EventHandler(this.ImgCancelar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivioToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 28);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivioToolStripMenuItem
            // 
            this.archivioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirOrdenToolStripMenuItem,
            this.añadirProductoToolStripMenuItem,
            this.imprimirOrdenesToolStripMenuItem});
            this.archivioToolStripMenuItem.Name = "archivioToolStripMenuItem";
            this.archivioToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.archivioToolStripMenuItem.Text = "Opciones";
            // 
            // añadirOrdenToolStripMenuItem
            // 
            this.añadirOrdenToolStripMenuItem.Name = "añadirOrdenToolStripMenuItem";
            this.añadirOrdenToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.añadirOrdenToolStripMenuItem.Text = "Crear Orden";
            this.añadirOrdenToolStripMenuItem.Click += new System.EventHandler(this.añadirOrdenToolStripMenuItem_Click);
            // 
            // añadirProductoToolStripMenuItem
            // 
            this.añadirProductoToolStripMenuItem.Name = "añadirProductoToolStripMenuItem";
            this.añadirProductoToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.añadirProductoToolStripMenuItem.Text = "Añadir Producto";
            this.añadirProductoToolStripMenuItem.Click += new System.EventHandler(this.añadirProductoToolStripMenuItem_Click);
            // 
            // imprimirOrdenesToolStripMenuItem
            // 
            this.imprimirOrdenesToolStripMenuItem.Name = "imprimirOrdenesToolStripMenuItem";
            this.imprimirOrdenesToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.imprimirOrdenesToolStripMenuItem.Text = "Imprimir Ordenes";
            this.imprimirOrdenesToolStripMenuItem.Click += new System.EventHandler(this.imprimirOrdenesToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.citasToolStripMenuItem.Text = "Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.productoToolStripMenuItem.Text = "Inventario";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(585, 220);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(276, 28);
            this.txtCliente.TabIndex = 60;
            // 
            // NUDCliente
            // 
            this.NUDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDCliente.Location = new System.Drawing.Point(141, 218);
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
            this.lblProducto.Location = new System.Drawing.Point(14, 271);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(116, 25);
            this.lblProducto.TabIndex = 57;
            this.lblProducto.Text = "IdProducto";
            // 
            // NUDProducto
            // 
            this.NUDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDProducto.Location = new System.Drawing.Point(141, 271);
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
            this.label2.Location = new System.Drawing.Point(451, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Cliente";
            // 
            // NUDPrecio
            // 
            this.NUDPrecio.Enabled = false;
            this.NUDPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDPrecio.Location = new System.Drawing.Point(585, 323);
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
            this.lblPrecio.Location = new System.Drawing.Point(451, 325);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 25);
            this.lblPrecio.TabIndex = 65;
            this.lblPrecio.Text = "Precio";
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.Location = new System.Drawing.Point(7, 151);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(131, 44);
            this.lblOrden.TabIndex = 67;
            this.lblOrden.Text = "Orden";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(580, 380);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 25);
            this.lblTotal.TabIndex = 65;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(660, 374);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(201, 34);
            this.txtTotal.TabIndex = 60;
            // 
            // IMGLogo
            // 
            this.IMGLogo.Image = global::Estetica_Rossy.Properties.Resources.Estetica_Rossy_Logo;
            this.IMGLogo.Location = new System.Drawing.Point(234, 155);
            this.IMGLogo.Name = "IMGLogo";
            this.IMGLogo.Size = new System.Drawing.Size(398, 274);
            this.IMGLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMGLogo.TabIndex = 68;
            this.IMGLogo.TabStop = false;
            // 
            // Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 787);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.NUDPrecio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.NUDCantidad);
            this.Controls.Add(this.NUDCliente);
            this.Controls.Add(this.NUDProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGOrden);
            this.Controls.Add(this.IMGLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Orden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden";
            this.Load += new System.EventHandler(this.Orden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGLogo)).EndInit();
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
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirOrdenToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.NumericUpDown NUDCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.NumericUpDown NUDProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ToolStripMenuItem añadirProductoToolStripMenuItem;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.PictureBox ImgImprimir;
        private System.Windows.Forms.PictureBox ImgReset;
        private System.Windows.Forms.PictureBox IMGLogo;
        private System.Windows.Forms.ToolStripMenuItem imprimirOrdenesToolStripMenuItem;
    }
}