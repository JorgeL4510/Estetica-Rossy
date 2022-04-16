
namespace Estetica_Rossy
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.lblProveedores = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.ImgCancelar = new System.Windows.Forms.PictureBox();
            this.ImgActualiar = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dGProveedores = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreMarcas = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.NUDProveedores = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IMGLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProveedores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMGLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(12, 42);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(246, 44);
            this.lblProveedores.TabIndex = 62;
            this.lblProveedores.Text = "Proveedores";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(14, 358);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(87, 29);
            this.lblBuscar.TabIndex = 61;
            this.lblBuscar.Text = "Buscar";
            // 
            // ImgCancelar
            // 
            this.ImgCancelar.BackColor = System.Drawing.Color.NavajoWhite;
            this.ImgCancelar.Image = global::Estetica_Rossy.Properties.Resources.cancelar;
            this.ImgCancelar.Location = new System.Drawing.Point(457, 44);
            this.ImgCancelar.Name = "ImgCancelar";
            this.ImgCancelar.Size = new System.Drawing.Size(42, 42);
            this.ImgCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCancelar.TabIndex = 60;
            this.ImgCancelar.TabStop = false;
            this.ImgCancelar.Click += new System.EventHandler(this.ImgCancelar_Click);
            // 
            // ImgActualiar
            // 
            this.ImgActualiar.BackColor = System.Drawing.Color.NavajoWhite;
            this.ImgActualiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgActualiar.Image = global::Estetica_Rossy.Properties.Resources.Actualizar;
            this.ImgActualiar.Location = new System.Drawing.Point(518, 42);
            this.ImgActualiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImgActualiar.Name = "ImgActualiar";
            this.ImgActualiar.Size = new System.Drawing.Size(45, 44);
            this.ImgActualiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgActualiar.TabIndex = 59;
            this.ImgActualiar.TabStop = false;
            this.ImgActualiar.Click += new System.EventHandler(this.ImgActualiar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(144, 358);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(419, 28);
            this.txtBuscar.TabIndex = 57;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dGProveedores
            // 
            this.dGProveedores.AllowUserToAddRows = false;
            this.dGProveedores.AllowUserToDeleteRows = false;
            this.dGProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGProveedores.Location = new System.Drawing.Point(12, 399);
            this.dGProveedores.Name = "dGProveedores";
            this.dGProveedores.ReadOnly = true;
            this.dGProveedores.RowHeadersWidth = 51;
            this.dGProveedores.RowTemplate.Height = 24;
            this.dGProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGProveedores.Size = new System.Drawing.Size(551, 247);
            this.dGProveedores.TabIndex = 56;
            this.dGProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGProveedores_CellDoubleClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(144, 148);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(419, 28);
            this.txtNombre.TabIndex = 55;
            // 
            // lblNombreMarcas
            // 
            this.lblNombreMarcas.AutoSize = true;
            this.lblNombreMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMarcas.Location = new System.Drawing.Point(14, 148);
            this.lblNombreMarcas.Name = "lblNombreMarcas";
            this.lblNombreMarcas.Size = new System.Drawing.Size(87, 25);
            this.lblNombreMarcas.TabIndex = 54;
            this.lblNombreMarcas.Text = "Nombre";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(144, 253);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(419, 87);
            this.txtDireccion.TabIndex = 64;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 253);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(102, 25);
            this.lblDireccion.TabIndex = 63;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(13, 205);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(97, 25);
            this.lblTelefono.TabIndex = 65;
            this.lblTelefono.Text = "Teléfono";
            // 
            // NUDProveedores
            // 
            this.NUDProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDProveedores.Location = new System.Drawing.Point(144, 205);
            this.NUDProveedores.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NUDProveedores.Name = "NUDProveedores";
            this.NUDProveedores.Size = new System.Drawing.Size(419, 28);
            this.NUDProveedores.TabIndex = 66;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 67;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirProveedorToolStripMenuItem,
            this.editarProveedorToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // añadirProveedorToolStripMenuItem
            // 
            this.añadirProveedorToolStripMenuItem.Name = "añadirProveedorToolStripMenuItem";
            this.añadirProveedorToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.añadirProveedorToolStripMenuItem.Text = "Añadir Proveedor";
            this.añadirProveedorToolStripMenuItem.Click += new System.EventHandler(this.añadirProveedorToolStripMenuItem_Click);
            // 
            // editarProveedorToolStripMenuItem
            // 
            this.editarProveedorToolStripMenuItem.Name = "editarProveedorToolStripMenuItem";
            this.editarProveedorToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.editarProveedorToolStripMenuItem.Text = "Editar Proveedor";
            this.editarProveedorToolStripMenuItem.Click += new System.EventHandler(this.editarProveedorToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar Proveedor";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 97);
            this.panel1.TabIndex = 70;
            // 
            // IMGLogo
            // 
            this.IMGLogo.Image = global::Estetica_Rossy.Properties.Resources.Estetica_Rossy_Logo;
            this.IMGLogo.Location = new System.Drawing.Point(120, 129);
            this.IMGLogo.Name = "IMGLogo";
            this.IMGLogo.Size = new System.Drawing.Size(319, 244);
            this.IMGLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMGLogo.TabIndex = 71;
            this.IMGLogo.TabStop = false;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 658);
            this.Controls.Add(this.NUDProveedores);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.ImgCancelar);
            this.Controls.Add(this.ImgActualiar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dGProveedores);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreMarcas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IMGLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProveedores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMGLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox ImgCancelar;
        private System.Windows.Forms.PictureBox ImgActualiar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dGProveedores;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreMarcas;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.NumericUpDown NUDProveedores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox IMGLogo;
    }
}