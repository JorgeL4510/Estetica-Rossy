using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estetica_Rossy
{
    public partial class Inventario : Form
    {
        String UsuarioN;
        String CargoN;
        public Inventario(string Usuario, string Cargo)
        {
            InitializeComponent();
            UsuarioN = Usuario;
            CargoN = Cargo;
            lblUsuario.Text = "Usuario: " + Usuario;
            lblCargo.Text = Cargo;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            CargarComboBox();
        }

        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();

        DataTable dt;

        Categoria cat = new Categoria();
       
        int IdProducto = 0;
        string NombreProducto;
        int IdMarca;
        decimal Costo;
        decimal Precio;
        int stock;
        int IdProveedor;


        public DataTable GetData(string consulta)
        {
            cm = new SqlCommand(consulta, DB_CONN.DB_CONN);
            SqlDataAdapter adp = new SqlDataAdapter(cm);
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }


        //Cambiar ventana
        #region
        private void inicioCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas min = new Citas(UsuarioN, CargoN);
            this.Dispose();
            min.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente mic = new Cliente(UsuarioN, CargoN);
            this.Dispose();
            mic.ShowDialog();
        }


        #endregion

        //Metodos
        #region

        private void Buscar()
        {
            try
            {
                cm = new SqlCommand("Buscar_Producto", DB_CONN.DB_CONN);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@NombreP", SqlDbType.VarChar).Value = txtBuscar.Text;

                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                dGInventario.DataSource = dt;
                dGInventario.Columns["IdProducto"].Visible = false;
                dGInventario.Columns["IdMarca"].Visible = false;
                dGInventario.Columns["IdProveedor"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
        }
        
        private void CargarComboBox()
        {
            try
            {
                CMBMarca.DataSource = cat.CargarCombo_DatosMarcas();
                CMBMarca.DisplayMember = "Marca";
                CMBMarca.ValueMember = "IdMarca";

                CMBProveedor.DataSource = cat.CargarCombo_DatosProveedores();
                CMBProveedor.DisplayMember = "Nombre";
                CMBProveedor.ValueMember = "IdProveedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar algunos datos: " + ex.Message);
            }
        }

        private void LlenarGrid()
        {
            dGInventario.DataSource = GetData("MostrarProductos");
            dGInventario.Columns["IdProducto"].Visible = false;
            dGInventario.Columns["IdMarca"].Visible = false;
            dGInventario.Columns["IdProveedor"].Visible = false;
        }

        private void LimpiarCampos()
        {
            this.txtNombreP.Text = string.Empty;
            this.NUDCantidad.Value = 0;
            this.NUDCosto.Value = 0;
            this.NUDPrecio.Value = 0;
            this.CMBMarca.SelectedIndex = 0;
            this.CMBProveedor.SelectedIndex = 0;
        }


        private void SeleccionarDatos()
        {//(IdProducto, IdMarca, IdProveedor, NombreP, IdMarca, Costo, Precio, Inventario, idProveedor)

            IdProducto = (int)dGInventario.SelectedRows[0].Cells[0].Value;
            IdMarca = (int)dGInventario.SelectedRows[0].Cells[1].Value;
            IdProveedor = (int)dGInventario.SelectedRows[0].Cells[2].Value;

            NombreProducto = dGInventario.SelectedRows[0].Cells[3].Value.ToString();
            //Marca = (int)dGInventario.SelectedRows[0].Cells[4].Value;
            Costo = (decimal)dGInventario.SelectedRows[0].Cells[5].Value;
            Precio = (decimal)dGInventario.SelectedRows[0].Cells[6].Value;
            stock = (int)dGInventario.SelectedRows[0].Cells[7].Value;
            //Proveedor = (int)dGInventario.SelectedRows[0].Cells[8].Value;

            this.txtNombreP.Text = NombreProducto;
            this.CMBMarca.SelectedValue = IdMarca;
            this.NUDCosto.Value = (int)Costo;
            this.NUDPrecio.Value = (int)Precio;
            this.NUDCantidad.Value = (int)stock;
            this.CMBProveedor.SelectedValue = IdProveedor;

            añadirProductoToolStripMenuItem.Enabled = false;
        }

        #endregion

        //Funciones Pantalla
        #region

        private void ImgActualiar_Click(object sender, EventArgs e)
        {
            dGInventario.DataSource = GetData("MostrarProductos");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void añadirProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombreP.Text == "" || NUDCosto.Value == 0)
            {
                MessageBox.Show("Datos ingresados incorrectamente");
            }
            else
            {
                try
                {
                    //Guardar info del producto
                    //(IdProducto, NombreP, IdMarca, Costo, Precio, Inventario, idProveedor)
                    cm = new SqlCommand("AgregarProducto", DB_CONN.DB_CONN);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.Add("@NombreP", SqlDbType.VarChar).Value = txtNombreP.Text; //Guardar el nombre del producto
                    cm.Parameters.Add("@IdMarca", SqlDbType.Int).Value = CMBMarca.SelectedValue; //Guardar el id de la marca
                    cm.Parameters.Add("@Costo", SqlDbType.Money).Value = NUDCosto.Value; //Guardar costo del producto
                    cm.Parameters.Add("@Precio", SqlDbType.Money).Value = NUDPrecio.Value; //Guardar el precio del producto, en caso de venderse a los clientes
                    cm.Parameters.Add("@Inventario", SqlDbType.Int).Value = NUDCantidad.Value; //Guardar la cantidad de inventario
                    cm.Parameters.Add("IdProveedor", SqlDbType.Int).Value = CMBProveedor.SelectedValue; //Guardar el Id del proveedor

                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    cm.Dispose();
                    MessageBox.Show("Se registro el cliente exitosamente");
                    LimpiarCampos(); //Limpiar los campos
                    LlenarGrid(); //Mostrar el registro en el Grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error " + ex.Message);
                }
            }
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer actualizar el producto?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
            else { }
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer eliminar el producto?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
            else { }
        }






        #endregion

        private void dGInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarDatos();
        }

        private void ImgCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            añadirProductoToolStripMenuItem.Enabled = true;
            IdProducto = 0;
            IdMarca = 0;
            IdProveedor = 0;
        }


    }
}
