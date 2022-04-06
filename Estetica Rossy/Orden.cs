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
        public Orden()
        {
            InitializeComponent();
        }

        private void Orden_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();


        DataTable dt;

        Categoria cat = new Categoria();

        string IdOrden = "";
        string IdProducto = "";
        string Cantidad = "";

        public DataTable GetData(string consulta)
        {
            cm = new SqlCommand(consulta, DB_CONN.DB_CONN);
            SqlDataAdapter adp = new SqlDataAdapter(cm);
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        private void LlenarGrid()
        {
            dGOrden.DataSource = GetData("MostrarOrdenDetalles");
            dGOrdenDetalle.DataSource = GetData("MostrarOrden");
            //dGOrden.Columns["IdProveedor"].Visible = false;
        }

        private void LimpiarCampos()
        {
            this.txtCliente.Text = string.Empty;

        }


        public void Add()
        {
            cm = new SqlCommand("InfoIdentity", DB_CONN.DB_CONN);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@IdCliente", SqlDbType.Int).Value = 1;//this.txtCliente.Text;

            try
             {
                string Identity = Convert.ToString(cm.ExecuteScalar());
                if (Identity != null)
                  {
                    IdOrden = Identity.ToString();
                    cm.Parameters.Clear();
                    cm.Dispose();

                    int i;
                    for(i=0; i < (this.dGOrden.Rows.Count); i++)
                    {
                        cm = new SqlCommand("AgregarOrdenDetalle", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;

                        cm.Parameters.Add("@IdOrden", SqlDbType.VarChar).Value = IdOrden; //Guardar el nombre del proveedor
                        cm.Parameters.Add("@IdProducto", SqlDbType.Int).Value = Convert.ToInt32(this.dGOrden.Rows[i].Cells["IdProducto"].Value); 
                        cm.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Convert.ToInt32(this.dGOrden.Rows[i].Cells["Cantidad"].Value);
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                    }
                    MessageBox.Show("Se ha agregado la Orden con el ID " + IdOrden);
                    LimpiarCampos(); //Limpiar los campos
                    LlenarGrid(); //Mostrar el registro en el Grid
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error al Agregar" + e.Message);
                cm.Parameters.Clear();
                cm.Dispose();
            }
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Orden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == Convert.ToInt16(Keys.Enter))
            {
                
            }
        }

        private void ImgActualiar_Click(object sender, EventArgs e)
        {
            dGOrden.DataSource = GetData("MostrarOrdenDetalles");
            dGOrdenDetalle.DataSource = GetData("MostrarOrden");
        }

        private void añadirProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarNombre(string consulta)
        {
            cm = new SqlCommand("AgregarOrdenDetalle", DB_CONN.DB_CONN);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdOrden; //Guardar el nombre del proveedor
            cm.ExecuteScalar();
            cm.Parameters.Clear();
            cm.Dispose();
        }

        private void NUDCliente_ValueChanged(object sender, EventArgs e)
        { 
            cm = new SqlCommand("NombreClientes", DB_CONN.DB_CONN);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@Id", SqlDbType.VarChar).Value = NUDCliente.Value; //Guardar el nombre del proveedor
            txtCliente.Text = Convert.ToString(cm.ExecuteScalar());
            cm.Parameters.Clear();
            cm.Dispose();
        }

        private void NUDProducto_ValueChanged(object sender, EventArgs e)
        {
            cm = new SqlCommand("NombreProductos", DB_CONN.DB_CONN);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@Id", SqlDbType.VarChar).Value = NUDProducto.Value; //Guardar el nombre del proveedor
            txtNombreP.Text = Convert.ToString(cm.ExecuteScalar());
            cm.Parameters.Clear();
            cm.Dispose();

            cm = new SqlCommand("ProductosPrecio", DB_CONN.DB_CONN);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@Id", SqlDbType.VarChar).Value = NUDProducto.Value; //Guardar el nombre del proveedor
            
            NUDPrecio.Value = Convert.ToInt32(cm.ExecuteScalar());
            cm.Parameters.Clear();
            cm.Dispose();
        }
    }
}
