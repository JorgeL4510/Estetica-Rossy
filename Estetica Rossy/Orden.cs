using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Estetica_Rossy
{
    public partial class Orden : Form
    {
        string UsuarioN;
        string CargoN;

        public Orden(string Usuario, string Cargo)
        {
            InitializeComponent();
            DatosUsuario(Usuario, Cargo);
        }

        private void Orden_Load(object sender, EventArgs e)
        {
            OrdenAñadida(0);
            añadirOrdenToolStripMenuItem.Enabled = false;
        }

        //Cambiar ventana
        #region
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario minv = new Inventario(UsuarioN, CargoN);
            this.Hide();
            minv.ShowDialog();
            this.Close();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas mc = new Citas(UsuarioN, CargoN);
            this.Hide();
            mc.ShowDialog();
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente mic = new Cliente(UsuarioN, CargoN);
            this.Hide();
            mic.ShowDialog();
            this.Close();
        }
        #endregion

        //Metodos
        #region

        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();


        DataTable dt;

        Categoria cat = new Categoria();

        int indice = 0;
        DataGridViewRow row;
        string IdOrden = "";
        string NProducto = "";
        string NSubtotal = "";
        int SubTotal = 0;
        float Total = 0;

        public void DatosUsuario(string Usuario, string Cargo)
        {
            lblUsuario.Text = "Usuario: " + Usuario;
            lblCargo.Text = Cargo;
            UsuarioN = Usuario;
            CargoN = Cargo;
        }

        private void LimpiarCampos()
        {
            this.txtCliente.Text = string.Empty;
            this.txtNombreP.Text = string.Empty;
            this.txtTotal.Text = string.Empty;
            NUDCliente.Value = 0;
            NUDProducto.Value = 0;
            NUDCantidad.Value = 0;
        }

        public void Add()
        {

            cm = new SqlCommand("ObtenerIdOrden", DB_CONN.DB_CONN);
            cm.CommandType = CommandType.StoredProcedure;
            string Identity = Convert.ToString(cm.ExecuteScalar());
            IdOrden = Identity;
            cm.Parameters.Clear();
            cm.Dispose();

            cm = new SqlCommand("AgregarOrden", DB_CONN.DB_CONN);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("IdOrden", SqlDbType.Int).Value = IdOrden;
            cm.Parameters.Add("@IdCliente", SqlDbType.Int).Value = NUDCliente.Value;
            cm.Parameters.Add("@Total", SqlDbType.Int).Value = Total;

            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cm.Dispose();

            try
            {

                if (Identity != null)
                {
                    IdOrden = Identity.ToString();

                    cm.Parameters.Clear();
                    cm.Dispose();

                    int i;
                    for (i = 0; i < (this.dGOrden.Rows.Count); i++)
                    {
                        cm = new SqlCommand("AgregarOrdenDetalle", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;

                        cm.Parameters.Add("@IdOrden", SqlDbType.VarChar).Value = IdOrden;
                        cm.Parameters.Add("@IdProducto", SqlDbType.Int).Value = Convert.ToInt32(this.dGOrden.Rows[i].Cells["Column1"].Value);
                        cm.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Convert.ToInt32(this.dGOrden.Rows[i].Cells["Column4"].Value);
                        cm.Parameters.Add("@Subtotal", SqlDbType.Int).Value = Convert.ToInt32(this.dGOrden.Rows[i].Cells["Column5"].Value);

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();

                        cm = new SqlCommand("RestarInventario", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;

                        cm.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(this.dGOrden.Rows[i].Cells["Column1"].Value);
                        cm.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Convert.ToInt32(this.dGOrden.Rows[i].Cells["Column4"].Value);

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                    }
                    MessageBox.Show("Se ha agregado la Orden con el ID " + IdOrden);
                    NUDProducto.Enabled = false;
                    NUDCantidad.Enabled = false;

                    añadirProductoToolStripMenuItem.Enabled = false;
                    añadirOrdenToolStripMenuItem.Enabled = false;
                    ImgCancelar.Enabled = false;
                    ImgCancelar.BackColor = Color.Gray;
                    OrdenAñadida(1);



                }
                else
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error al Agregar" + e.Message);
            }


        }

        private void Cancelar()
        {
            IdOrden = "";
            SubTotal = 0;
            Total = 0;
            dGOrden.Rows.Clear();
            LimpiarCampos();
            NUDCliente.Enabled = true;
            añadirProductoToolStripMenuItem.Enabled = true;
            añadirOrdenToolStripMenuItem.Enabled = false;
            OrdenAñadida(0);
        }

        private void OrdenAñadida(int i)
        {
            if (i == 0)
            {
                ImgReset.Enabled = false;
                ImgReset.BackColor = Color.Gray;
                ImgImprimir.Enabled = false;
                ImgImprimir.BackColor = Color.Gray;
            }
            if (i == 1)
            {
                ImgReset.Enabled = true;
                ImgReset.BackColor = Color.Transparent;
                ImgImprimir.Enabled = true;
                ImgImprimir.BackColor = Color.Transparent;
            }
        }

        private void Reset()
        {
            Cancelar();
            LimpiarCampos();
            OrdenAñadida(0);
            NUDCliente.Enabled = true;
            NUDProducto.Enabled = true;
            NUDCantidad.Enabled = true;
            ImgCancelar.Enabled = true;
            ImgCancelar.BackColor = Color.Transparent;
        }

        private void Imprimir()
        {
            cm = new SqlCommand("MostrarOrdenId", DB_CONN.DB_CONN);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@Id", SqlDbType.Int).Value = IdOrden;

            SqlDataAdapter adp = new SqlDataAdapter(cm);
            dt = new DataTable();
            adp.Fill(dt);

            Reporte Reporte = new Reporte();
            CrystalReport1 Reporte1 = new CrystalReport1();
            Reporte1.SetDataSource(dt);
            Reporte.ReportExporta = Reporte1;
            Reporte.ShowDialog();
            Reporte.Focus();

            cm.Parameters.Clear();
            cm.Dispose();
        }

        #endregion

        //Funciones pantalla
        #region

        private void añadirProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NUDCliente.Value == 0 || NUDCantidad.Value == 0 || NUDProducto.Value == 0)
            {
                MessageBox.Show("Datos ingresados incorrectamente");
            }
            else
            {
                cm = new SqlCommand("CalcularSubtotal", DB_CONN.DB_CONN);
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.Add("@Id", SqlDbType.Int).Value = NUDProducto.Value;
                cm.Parameters.Add("@Cantidad", SqlDbType.Int).Value = NUDCantidad.Value;
                SubTotal = Convert.ToInt32(cm.ExecuteScalar());
                cm.Parameters.Clear();
                cm.Dispose();

                dGOrden.Rows.Add(NUDProducto.Value, txtNombreP.Text, NUDPrecio.Value, NUDCantidad.Value, SubTotal);

                Total += SubTotal;
                txtTotal.Text = Total.ToString();

                NUDCliente.Enabled = false;
                añadirOrdenToolStripMenuItem.Enabled = true;
            }
        }

        private void añadirOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void NUDCliente_ValueChanged(object sender, EventArgs e)
        {
            cm = new SqlCommand("NombreClientes", DB_CONN.DB_CONN);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@Id", SqlDbType.Int).Value = NUDCliente.Value; //Guardar el nombre del proveedor
            txtCliente.Text = Convert.ToString(cm.ExecuteScalar());
            cm.Parameters.Clear();
            cm.Dispose();
        }

        private void NUDProducto_ValueChanged(object sender, EventArgs e)
        {
            cm = new SqlCommand("NombreProductos", DB_CONN.DB_CONN);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@Id", SqlDbType.Int).Value = NUDProducto.Value; //Guardar el nombre del proveedor
            txtNombreP.Text = Convert.ToString(cm.ExecuteScalar());
            cm.Parameters.Clear();
            cm.Dispose();

            cm = new SqlCommand("ProductosPrecio", DB_CONN.DB_CONN);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@Id", SqlDbType.Int).Value = NUDProducto.Value; //Guardar el nombre del proveedor

            NUDPrecio.Value = Convert.ToInt32(cm.ExecuteScalar());
            cm.Parameters.Clear();
            cm.Dispose();
        }

        private void ImgCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void ImgImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void ImgReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void imprimirOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimirOrden io = new ImprimirOrden(UsuarioN, CargoN);
            io.ShowDialog();
        }
    }

    #endregion




}
