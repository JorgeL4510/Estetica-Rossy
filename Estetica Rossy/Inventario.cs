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
        String IdVisi;
        public Inventario(string Usuario, string Cargo)
        {
            InitializeComponent();
            DatosUsuario(Usuario, Cargo);
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            CargarComboBox();
        }

        //Cambiar ventana
        #region
        private void inicioCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas mc = new Citas(UsuarioN, CargoN);
            this.Hide();
            mc.ShowDialog();
            this.Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente mic = new Cliente(UsuarioN, CargoN);
            this.Hide();
            mic.ShowDialog();
            this.Close();
        }

        private void ordenToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Orden or = new Orden(UsuarioN, CargoN);
            this.Hide();
            or.ShowDialog();
            this.Close();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcas m = new Marcas();
            m.ShowDialog();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores cp = new Proveedores();
            cp.ShowDialog();
        }

        #endregion

        //Metodos
        #region

        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();

        DataTable dt;

        Categoria cat = new Categoria();

        int IdProducto = 0;
        string NombreProducto;
        int IdMarca;
        decimal Costo;
        decimal Precio;
        int Cantidad;
        int IdProveedor;

        public DataTable GetData(string consulta)
        {
            cm = new SqlCommand(consulta, DB_CONN.DB_CONN);
            SqlDataAdapter adp = new SqlDataAdapter(cm);
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public void DatosUsuario(string Usuario, string Cargo)
        {
            lblUsuario.Text = "Usuario: " + Usuario;
            lblCargo.Text = Cargo;
            UsuarioN = Usuario;
            CargoN = Cargo;
        }

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
            Cantidad = (int)dGInventario.SelectedRows[0].Cells[7].Value;
            //Proveedor = (int)dGInventario.SelectedRows[0].Cells[8].Value;

            this.txtNombreP.Text = NombreProducto;
            this.CMBMarca.SelectedValue = IdMarca;
            this.NUDCosto.Value = (int)Costo;
            this.NUDPrecio.Value = (int)Precio;
            this.NUDCantidad.Value = (int)Cantidad;
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
            if (txtNombreP.Text == ""  ||NUDCosto.Value == 0)
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
                if (txtNombreP.Text == "" || NUDCosto.Value == 0 || IdProducto == 0)
                {
                    MessageBox.Show("No se ha seleccionado ningún campo o los datos se han ingresado incorrectamente");
                }
                else
                {
                    try
                    {
                        //(IdProducto, NombreP, IdMarca, Costo, Precio, Inventario, IdProveedor)
                        cm = new SqlCommand("ActualizarProducto", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.Add("@idProducto", SqlDbType.Int).Value = IdProducto; // Enviar el Id del producto a modificar
                        cm.Parameters.Add("@NombreP", SqlDbType.VarChar).Value = txtNombreP.Text; //Guardar el nombre del producto
                        cm.Parameters.Add("@IdMarca", SqlDbType.Int).Value = CMBMarca.SelectedValue; //Guardar el id de la marca
                        cm.Parameters.Add("@Costo", SqlDbType.Money).Value = NUDCosto.Value; //Guardar costo del producto
                        cm.Parameters.Add("@Precio", SqlDbType.Money).Value = NUDPrecio.Value; //Guardar el precio del producto, en caso de venderse a los clientes
                        cm.Parameters.Add("@Inventario", SqlDbType.Int).Value = NUDCantidad.Value; //Guardar la cantidad de inventario
                        cm.Parameters.Add("IdProveedor", SqlDbType.Int).Value = CMBProveedor.SelectedValue; //Guardar el Id del proveedor

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                        MessageBox.Show("Los datos del producto se han actualizado correctamente");

                        IdProducto = 0;                        
                        añadirProductoToolStripMenuItem.Enabled = true;
                        LimpiarCampos(); //Limpiar los campos
                        LlenarGrid(); //Mostrar el registro en el Grid                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error " + ex.Message);
                    }
                }
            }
            else 
            { 
                
            }
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer eliminar el producto?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtNombreP.Text == "" || IdProducto == 0)
                {
                    MessageBox.Show("No se ha seleccionado ningún campo o los datos se han ingresado incorrectamente");
                }
                else
                {
                    try
                    {
                        cm = new SqlCommand("EliminarProducto", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.Add("@idProducto", SqlDbType.Int).Value = IdProducto; // Enviar el Id del producto a eliminar

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                        MessageBox.Show("El producto se ha eliminado correctamente");

                        IdProducto = 0;
                        añadirProductoToolStripMenuItem.Enabled = true;
                        LimpiarCampos(); //Limpiar los campos
                        LlenarGrid(); //Mostrar el registro en el Grid                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                    }
                }
            }
            else
            {

            }
        }

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

        private void ImgImprimir_Click(object sender, EventArgs e)
        {
            Reporte Reporte = new Reporte();
            CrystalReport Reporte1 = new CrystalReport();
            Reporte1.SetDataSource(GetData("EXEC Mostrar_Inventario"));
            Reporte.ReportExporta = Reporte1;
            Reporte.ShowDialog();
            Reporte.Focus();
        }

        #endregion




    }
}
