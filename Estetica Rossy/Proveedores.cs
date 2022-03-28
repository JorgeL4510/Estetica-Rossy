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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();

        DataTable dt;

        Categoria cat = new Categoria();

        int IdProveedor = 0;
        string NombreProveedor;
        int Telefono;
        string Direccion;

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
            dGProveedores.DataSource = GetData("MostrarProveedores");
            dGProveedores.Columns["IdProveedor"].Visible = false;
        }

        private void LimpiarCampos()
        {
            this.txtNombre.Text = string.Empty;
            this.NUDProveedores.Value = 0;
            this.txtDireccion.Text = string.Empty;
        }

        private void SeleccionarDatos()
        {//(IdProveedor, Nombre, Telefono, Direccion)

            IdProveedor = (int)dGProveedores.SelectedRows[0].Cells[0].Value;
            NombreProveedor = dGProveedores.SelectedRows[0].Cells[1].Value.ToString();
            Telefono = (int)dGProveedores.SelectedRows[0].Cells[2].Value;
            Direccion = dGProveedores.SelectedRows[0].Cells[3].Value.ToString();

            this.txtNombre.Text = NombreProveedor;
            this.NUDProveedores.Value = Telefono;
            this.txtDireccion.Text = Direccion;

            añadirProveedorToolStripMenuItem.Enabled = false;
        }

        private void Buscar()
        {
            try
            {
                cm = new SqlCommand("Buscar_Proveedor", DB_CONN.DB_CONN);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtBuscar.Text;

                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                dGProveedores.DataSource = dt;
                dGProveedores.Columns["IdProveedor"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
        }

        private void ImgCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            añadirProveedorToolStripMenuItem.Enabled = true;
            IdProveedor = 0;
        }

        private void ImgActualiar_Click(object sender, EventArgs e)
        {
            dGProveedores.DataSource = GetData("MostrarProveedores");
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dGProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarDatos();
        }

        private void añadirProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || NUDProveedores.Value == 0 || txtDireccion.Text == "")
            {
                MessageBox.Show("Datos ingresados incorrectamente");
            }
            else
            {
                try
                {
                    //Guardar info del proveedor
                    //(IdProveedor, Nombre, Telefono, Direccion)
                    cm = new SqlCommand("AgregarProveedor", DB_CONN.DB_CONN);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombre.Text; //Guardar el nombre del proveedor
                    cm.Parameters.Add("@Telefono", SqlDbType.Int).Value = NUDProveedores.Value; //Guardar el telefono del proveedor
                    cm.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text; //Guardar la direccion del proveedor
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    cm.Dispose();
                    MessageBox.Show("Se registro el proveedor exitosamente");
                    LimpiarCampos(); //Limpiar los campos
                    LlenarGrid(); //Mostrar el registro en el Grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error " + ex.Message);
                }
            }
        }
        
        private void editarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer actualizar el proveedor?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtNombre.Text == "" || NUDProveedores.Value == 0 || txtDireccion.Text == "" || IdProveedor == 0)
                {
                    MessageBox.Show("No se ha seleccionado ningún campo o los datos se han ingresado incorrectamente");
                }
                else
                {
                    try
                    {
                        //(IdProducto, NombreP, IdMarca, Costo, Precio, Inventario, IdProveedor)
                        cm = new SqlCommand("ActualizarProveedor", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = IdProveedor; // Enviar el Id de la marca a editar
                        cm.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombre.Text; //Enviar el nombre de la marca
                        cm.Parameters.Add("@Telefono", SqlDbType.Int).Value = NUDProveedores.Value; //Enviar el telefono del proveedor
                        cm.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text; //Enviar la direccion del proveedor

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                        MessageBox.Show("Los datos del proveedor se han actualizado correctamente");

                        IdProveedor = 0;
                        añadirProveedorToolStripMenuItem.Enabled = true;
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer eliminar el proveedor?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtNombre.Text == "" || NUDProveedores.Value == 0 || txtDireccion.Text == "" || IdProveedor == 0)
                {
                    MessageBox.Show("No se ha seleccionado ningún campo o los datos se han ingresado incorrectamente");
                }
                else
                {
                    try
                    {
                        cm = new SqlCommand("EliminarProveedor", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = IdProveedor; // Enviar el Id del proveedor a eliminar

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                        MessageBox.Show("El producto se ha eliminado correctamente");

                        IdProveedor = 0;
                        añadirProveedorToolStripMenuItem.Enabled = true;
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
    }
}
