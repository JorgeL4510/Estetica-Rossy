﻿
namespace Estetica_Rossy
{
    partial class Inventario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEsteticaRossy = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.CMBProveedor = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dGInventario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.CMBMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImgActualiar = new System.Windows.Forms.PictureBox();
            this.ImgLupa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGInventario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.lblEsteticaRossy);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 148);
            this.panel1.TabIndex = 0;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(10, 115);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(66, 25);
            this.lblCargo.TabIndex = 46;
            this.lblCargo.Text = "Cargo";
            // 
            // lblEsteticaRossy
            // 
            this.lblEsteticaRossy.AutoSize = true;
            this.lblEsteticaRossy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsteticaRossy.Location = new System.Drawing.Point(280, 25);
            this.lblEsteticaRossy.Name = "lblEsteticaRossy";
            this.lblEsteticaRossy.Size = new System.Drawing.Size(309, 51);
            this.lblEsteticaRossy.TabIndex = 27;
            this.lblEsteticaRossy.Text = "Estética Rossy";
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
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(12, 247);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(87, 25);
            this.lblNombreProducto.TabIndex = 32;
            this.lblNombreProducto.Text = "Nombre";
            // 
            // CMBProveedor
            // 
            this.CMBProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBProveedor.FormattingEnabled = true;
            this.CMBProveedor.Location = new System.Drawing.Point(588, 291);
            this.CMBProveedor.Name = "CMBProveedor";
            this.CMBProveedor.Size = new System.Drawing.Size(250, 33);
            this.CMBProveedor.TabIndex = 31;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(131, 359);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(648, 30);
            this.txtBuscar.TabIndex = 35;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(13, 360);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(87, 29);
            this.lblBuscar.TabIndex = 34;
            this.lblBuscar.Text = "Buscar";
            // 
            // dGInventario
            // 
            this.dGInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGInventario.Location = new System.Drawing.Point(12, 406);
            this.dGInventario.Name = "dGInventario";
            this.dGInventario.RowHeadersWidth = 51;
            this.dGInventario.RowTemplate.Height = 24;
            this.dGInventario.Size = new System.Drawing.Size(826, 318);
            this.dGInventario.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 44);
            this.label2.TabIndex = 36;
            this.label2.Text = "Inventario";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(131, 247);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(303, 28);
            this.txtNombreProducto.TabIndex = 37;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 296);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 25);
            this.lblPrecio.TabIndex = 32;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(131, 296);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(303, 28);
            this.txtPrecio.TabIndex = 37;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(467, 296);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(111, 25);
            this.lblProveedor.TabIndex = 32;
            this.lblProveedor.Text = "Proveedor";
            // 
            // CMBMarca
            // 
            this.CMBMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBMarca.FormattingEnabled = true;
            this.CMBMarca.Location = new System.Drawing.Point(588, 244);
            this.CMBMarca.Name = "CMBMarca";
            this.CMBMarca.Size = new System.Drawing.Size(250, 33);
            this.CMBMarca.TabIndex = 31;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(467, 247);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 25);
            this.lblMarca.TabIndex = 32;
            this.lblMarca.Text = "Marca";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.inicioCitasToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 28);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirProductoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // añadirProductoToolStripMenuItem
            // 
            this.añadirProductoToolStripMenuItem.Name = "añadirProductoToolStripMenuItem";
            this.añadirProductoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.añadirProductoToolStripMenuItem.Text = "Añadir Producto";
            // 
            // inicioCitasToolStripMenuItem
            // 
            this.inicioCitasToolStripMenuItem.Name = "inicioCitasToolStripMenuItem";
            this.inicioCitasToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.inicioCitasToolStripMenuItem.Text = "Citas";
            this.inicioCitasToolStripMenuItem.Click += new System.EventHandler(this.inicioCitasToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // ImgActualiar
            // 
            this.ImgActualiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgActualiar.Image = global::Estetica_Rossy.Properties.Resources.Actualizar;
            this.ImgActualiar.Location = new System.Drawing.Point(784, 181);
            this.ImgActualiar.Name = "ImgActualiar";
            this.ImgActualiar.Size = new System.Drawing.Size(45, 44);
            this.ImgActualiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgActualiar.TabIndex = 42;
            this.ImgActualiar.TabStop = false;
            this.ImgActualiar.Click += new System.EventHandler(this.ImgActualiar_Click);
            // 
            // ImgLupa
            // 
            this.ImgLupa.Image = global::Estetica_Rossy.Properties.Resources.lupa;
            this.ImgLupa.Location = new System.Drawing.Point(795, 359);
            this.ImgLupa.Name = "ImgLupa";
            this.ImgLupa.Size = new System.Drawing.Size(43, 42);
            this.ImgLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLupa.TabIndex = 44;
            this.ImgLupa.TabStop = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(854, 736);
            this.Controls.Add(this.ImgLupa);
            this.Controls.Add(this.ImgActualiar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.dGInventario);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.CMBMarca);
            this.Controls.Add(this.CMBProveedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGInventario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEsteticaRossy;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.ComboBox CMBProveedor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dGInventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox CMBMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.PictureBox ImgActualiar;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox ImgLupa;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem añadirProductoToolStripMenuItem;
    }
}