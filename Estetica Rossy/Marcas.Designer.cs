
namespace Estetica_Rossy
{
    partial class Marcas
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
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.lblNombreMarcas = new System.Windows.Forms.Label();
            this.dGMarcas = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImgCancelar = new System.Windows.Forms.PictureBox();
            this.ImgActualiar = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEsteticaRossy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGMarcas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreM
            // 
            this.txtNombreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreM.Location = new System.Drawing.Point(107, 154);
            this.txtNombreM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(351, 28);
            this.txtNombreM.TabIndex = 39;
            // 
            // lblNombreMarcas
            // 
            this.lblNombreMarcas.AutoSize = true;
            this.lblNombreMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMarcas.Location = new System.Drawing.Point(14, 154);
            this.lblNombreMarcas.Name = "lblNombreMarcas";
            this.lblNombreMarcas.Size = new System.Drawing.Size(87, 25);
            this.lblNombreMarcas.TabIndex = 38;
            this.lblNombreMarcas.Text = "Nombre";
            // 
            // dGMarcas
            // 
            this.dGMarcas.AllowUserToAddRows = false;
            this.dGMarcas.AllowUserToDeleteRows = false;
            this.dGMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGMarcas.Location = new System.Drawing.Point(12, 266);
            this.dGMarcas.Name = "dGMarcas";
            this.dGMarcas.ReadOnly = true;
            this.dGMarcas.RowHeadersWidth = 51;
            this.dGMarcas.RowTemplate.Height = 24;
            this.dGMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGMarcas.Size = new System.Drawing.Size(446, 247);
            this.dGMarcas.TabIndex = 40;
            this.dGMarcas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGMarcas_CellDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(107, 224);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(351, 28);
            this.txtBuscar.TabIndex = 41;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 28);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirMarcaToolStripMenuItem,
            this.editarMarcaToolStripMenuItem,
            this.eliminarMarcaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // añadirMarcaToolStripMenuItem
            // 
            this.añadirMarcaToolStripMenuItem.Name = "añadirMarcaToolStripMenuItem";
            this.añadirMarcaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.añadirMarcaToolStripMenuItem.Text = "Añadir Marca";
            this.añadirMarcaToolStripMenuItem.Click += new System.EventHandler(this.añadirMarcaToolStripMenuItem_Click);
            // 
            // editarMarcaToolStripMenuItem
            // 
            this.editarMarcaToolStripMenuItem.Name = "editarMarcaToolStripMenuItem";
            this.editarMarcaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.editarMarcaToolStripMenuItem.Text = "Editar Marca";
            this.editarMarcaToolStripMenuItem.Click += new System.EventHandler(this.editarMarcaToolStripMenuItem_Click);
            // 
            // eliminarMarcaToolStripMenuItem
            // 
            this.eliminarMarcaToolStripMenuItem.Name = "eliminarMarcaToolStripMenuItem";
            this.eliminarMarcaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.eliminarMarcaToolStripMenuItem.Text = "Eliminar Marca";
            this.eliminarMarcaToolStripMenuItem.Click += new System.EventHandler(this.eliminarMarcaToolStripMenuItem_Click);
            // 
            // ImgCancelar
            // 
            this.ImgCancelar.BackColor = System.Drawing.Color.Gold;
            this.ImgCancelar.Image = global::Estetica_Rossy.Properties.Resources.cancelar;
            this.ImgCancelar.Location = new System.Drawing.Point(361, 50);
            this.ImgCancelar.Name = "ImgCancelar";
            this.ImgCancelar.Size = new System.Drawing.Size(42, 42);
            this.ImgCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCancelar.TabIndex = 51;
            this.ImgCancelar.TabStop = false;
            this.ImgCancelar.Click += new System.EventHandler(this.ImgCancelar_Click);
            // 
            // ImgActualiar
            // 
            this.ImgActualiar.BackColor = System.Drawing.Color.Gold;
            this.ImgActualiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgActualiar.Image = global::Estetica_Rossy.Properties.Resources.Actualizar;
            this.ImgActualiar.Location = new System.Drawing.Point(413, 50);
            this.ImgActualiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImgActualiar.Name = "ImgActualiar";
            this.ImgActualiar.Size = new System.Drawing.Size(45, 44);
            this.ImgActualiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgActualiar.TabIndex = 50;
            this.ImgActualiar.TabStop = false;
            this.ImgActualiar.Click += new System.EventHandler(this.ImgActualiar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(13, 224);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(87, 29);
            this.lblBuscar.TabIndex = 52;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.BackColor = System.Drawing.Color.Gold;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(12, 48);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(151, 44);
            this.lblMarcas.TabIndex = 53;
            this.lblMarcas.Text = "Marcas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblEsteticaRossy);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 102);
            this.panel1.TabIndex = 55;
            // 
            // lblEsteticaRossy
            // 
            this.lblEsteticaRossy.AutoSize = true;
            this.lblEsteticaRossy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsteticaRossy.Location = new System.Drawing.Point(625, 41);
            this.lblEsteticaRossy.Name = "lblEsteticaRossy";
            this.lblEsteticaRossy.Size = new System.Drawing.Size(309, 51);
            this.lblEsteticaRossy.TabIndex = 27;
            this.lblEsteticaRossy.Text = "Estética Rossy";
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 525);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.ImgCancelar);
            this.Controls.Add(this.ImgActualiar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dGMarcas);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.lblNombreMarcas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Marcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGMarcas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label lblNombreMarcas;
        private System.Windows.Forms.DataGridView dGMarcas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarcaToolStripMenuItem;
        private System.Windows.Forms.PictureBox ImgCancelar;
        private System.Windows.Forms.PictureBox ImgActualiar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEsteticaRossy;
    }
}