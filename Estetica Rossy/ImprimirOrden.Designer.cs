
namespace Estetica_Rossy
{
    partial class ImprimirOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirOrden));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCargo = new System.Windows.Forms.Label();
            this.ImgCancelar = new System.Windows.Forms.PictureBox();
            this.lblEsteticaRossy = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.ImgImprimir = new System.Windows.Forms.PictureBox();
            this.IMGLogo = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dGOrden = new System.Windows.Forms.DataGridView();
            this.NUDOrden = new System.Windows.Forms.NumericUpDown();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.ImgActualiar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.ImgActualiar);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.ImgCancelar);
            this.panel1.Controls.Add(this.lblEsteticaRossy);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 148);
            this.panel1.TabIndex = 69;
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
            this.ImgCancelar.Location = new System.Drawing.Point(1094, 98);
            this.ImgCancelar.Name = "ImgCancelar";
            this.ImgCancelar.Size = new System.Drawing.Size(42, 42);
            this.ImgCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCancelar.TabIndex = 65;
            this.ImgCancelar.TabStop = false;
            this.ImgCancelar.Click += new System.EventHandler(this.ImgCancelar_Click);
            // 
            // lblEsteticaRossy
            // 
            this.lblEsteticaRossy.AutoSize = true;
            this.lblEsteticaRossy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsteticaRossy.Location = new System.Drawing.Point(400, 16);
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
            // ImgImprimir
            // 
            this.ImgImprimir.Image = global::Estetica_Rossy.Properties.Resources.imprimir;
            this.ImgImprimir.Location = new System.Drawing.Point(1154, 202);
            this.ImgImprimir.Name = "ImgImprimir";
            this.ImgImprimir.Size = new System.Drawing.Size(45, 44);
            this.ImgImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgImprimir.TabIndex = 67;
            this.ImgImprimir.TabStop = false;
            this.ImgImprimir.Click += new System.EventHandler(this.ImgImprimir_Click);
            // 
            // IMGLogo
            // 
            this.IMGLogo.Image = global::Estetica_Rossy.Properties.Resources.Estetica_Rossy_Logo;
            this.IMGLogo.Location = new System.Drawing.Point(716, 271);
            this.IMGLogo.Name = "IMGLogo";
            this.IMGLogo.Size = new System.Drawing.Size(472, 306);
            this.IMGLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMGLogo.TabIndex = 70;
            this.IMGLogo.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(101, 207);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(482, 28);
            this.txtBuscar.TabIndex = 77;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(7, 207);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(79, 25);
            this.lblBuscar.TabIndex = 74;
            this.lblBuscar.Text = "Buscar";
            // 
            // dGOrden
            // 
            this.dGOrden.AllowUserToAddRows = false;
            this.dGOrden.AllowUserToDeleteRows = false;
            this.dGOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGOrden.Location = new System.Drawing.Point(16, 335);
            this.dGOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGOrden.MultiSelect = false;
            this.dGOrden.Name = "dGOrden";
            this.dGOrden.ReadOnly = true;
            this.dGOrden.RowHeadersWidth = 51;
            this.dGOrden.RowTemplate.Height = 24;
            this.dGOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGOrden.Size = new System.Drawing.Size(651, 228);
            this.dGOrden.TabIndex = 86;
            // 
            // NUDOrden
            // 
            this.NUDOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDOrden.Location = new System.Drawing.Point(860, 208);
            this.NUDOrden.Margin = new System.Windows.Forms.Padding(4);
            this.NUDOrden.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDOrden.Name = "NUDOrden";
            this.NUDOrden.Size = new System.Drawing.Size(276, 30);
            this.NUDOrden.TabIndex = 89;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(751, 213);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(90, 25);
            this.lblIdCliente.TabIndex = 88;
            this.lblIdCliente.Text = "IdOrden";
            // 
            // DTPFecha
            // 
            this.DTPFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFecha.Location = new System.Drawing.Point(16, 260);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(567, 34);
            this.DTPFecha.TabIndex = 90;
            this.DTPFecha.ValueChanged += new System.EventHandler(this.DTPFecha_ValueChanged);
            // 
            // ImgActualiar
            // 
            this.ImgActualiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgActualiar.Image = global::Estetica_Rossy.Properties.Resources.Actualizar;
            this.ImgActualiar.Location = new System.Drawing.Point(1154, 98);
            this.ImgActualiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImgActualiar.Name = "ImgActualiar";
            this.ImgActualiar.Size = new System.Drawing.Size(45, 44);
            this.ImgActualiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgActualiar.TabIndex = 91;
            this.ImgActualiar.TabStop = false;
            this.ImgActualiar.Click += new System.EventHandler(this.ImgActualiar_Click);
            // 
            // ImprimirOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1226, 585);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.ImgImprimir);
            this.Controls.Add(this.NUDOrden);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.dGOrden);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IMGLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImprimirOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImprimirOrden";
            this.Load += new System.EventHandler(this.ImprimirOrden_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgActualiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgImprimir;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.PictureBox ImgCancelar;
        private System.Windows.Forms.Label lblEsteticaRossy;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox IMGLogo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dGOrden;
        private System.Windows.Forms.NumericUpDown NUDOrden;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.PictureBox ImgActualiar;
    }
}