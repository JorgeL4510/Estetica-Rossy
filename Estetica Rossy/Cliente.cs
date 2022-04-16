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
    public partial class Cliente : Form
    {
        String UsuarioN;
        String CargoN;

        int IdCliente = 0;
        string Nombre;
        string Apellido;
        string Telefono;

        public Cliente(string Usuario, string Cargo)
        {
            InitializeComponent();
            DatosUsuario(Usuario, Cargo);
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();

        DataTable dt;

        //Cambiar ventana
        #region
        private void inicioCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas mc = new Citas(UsuarioN, CargoN);
            this.Hide();
            mc.ShowDialog();
            this.Close();
        }
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario minv = new Inventario(UsuarioN, CargoN);
            this.Hide();
            minv.ShowDialog();
            this.Close();
        }

        private void ordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orden or = new Orden(UsuarioN, CargoN);
            this.Hide();
            or.ShowDialog();
            this.Close();
        }

        #endregion

        //Metodos
        #region

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
            UsuarioN = Usuario;
            CargoN = Cargo;
            lblUsuario.Text = "Usuario: " + Usuario;
            lblCargo.Text = Cargo;
        }

        private void LlenarGrid()
        {
            dGClientes.DataSource = GetData("MostrarClientes");
            dGClientes.Columns["IdCliente"].Visible = false;
        }

        private void LimpiarCampos()
        {
            this.txtNombreCliente.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
        }

        private void Buscar()
        {
            try
            {
                cm = new SqlCommand("Buscar_Cliente", DB_CONN.DB_CONN);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtBuscar.Text;

                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                dGClientes.DataSource = dt;
                dGClientes.Columns["IdCliente"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
        }

        private void SeleccionarDatos()
        {

            if (this.dGClientes.SelectedRows.Count > 0) //Verificar que el grid tenga datos
            {
                IdCliente = (int)dGClientes.SelectedRows[0].Cells[0].Value;
                Nombre = dGClientes.SelectedRows[0].Cells[1].Value.ToString();
                Apellido = dGClientes.SelectedRows[0].Cells[2].Value.ToString();
                Telefono = dGClientes.SelectedRows[0].Cells[3].Value.ToString();

                this.txtNombreCliente.Text = Nombre;
                this.txtApellido.Text = Apellido;
                this.txtTelefono.Text = Telefono;
                
                añadirClienteToolStripMenuItem.Enabled = false;
            }
        }
        #endregion
        
        //Funciones Pantalla
        #region
        private void ImgActualiar_Click(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void añadirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Datos ingresados incorrectamente");
            }
            else
            {
                try
                {
                    //Guardar info del cliente
                    //(Nombre, Apellido, Telefono)
                    cm = new SqlCommand("AgregarCliente", DB_CONN.DB_CONN);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombreCliente.Text; //Guardar el nombre del cliente
                    cm.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = txtApellido.Text; //Guardar el apellido del cliente
                    cm.Parameters.Add("@Telefono", SqlDbType.Int).Value = Convert.ToInt32(txtTelefono.Text); //Guardar el telefono del cliente en caso de necesitar comunicación                    

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

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer actualizar los datos del cliente?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtNombreCliente.Text == "" || txtTelefono.Text == "" || IdCliente == 0)
                {
                    MessageBox.Show("No se ha seleccionado ningún campo o los datos se han ingresado incorrectamente");
                }
                else
                {
                    try
                    {
                        //Guardar info del cliente
                        //(Nombre, Telefono)
                        cm = new SqlCommand("ActualizarCliente", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;

                        cm.Parameters.Add("@IdCliente", SqlDbType.Int).Value = IdCliente; //Enviar id del cliente para actualizar el campo
                        cm.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombreCliente.Text; //Actualizar el nombre del cliente
                        cm.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = txtApellido.Text; //Actualizar el apellido del cliente
                        cm.Parameters.Add("@Telefono", SqlDbType.Int).Value = Convert.ToInt32(txtTelefono.Text); //Actualizar el telefono del cliente

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                        MessageBox.Show("Se actualizaron correctamente los datos del cliente");
                        
                        IdCliente = 0;
                        añadirClienteToolStripMenuItem.Enabled = true;
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

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer eliminar el campo?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtNombreCliente.Text == "" || txtTelefono.Text == "" || IdCliente == 0)
                {
                    MessageBox.Show("No se ha seleccionado ningún campo o los datos se han ingresado incorrectamente");
                }
                else
                {
                    try
                    {
                        cm = new SqlCommand("EliminarCliente", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;

                        cm.Parameters.Add("@IdCliente", SqlDbType.Int).Value = IdCliente; //Enviar id del cliente para eliminar sus datos
                        
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                        MessageBox.Show("Los datos del cliente han sido eliminados correctamente");

                        IdCliente = 0;
                        añadirClienteToolStripMenuItem.Enabled = true;
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

        private void ImgCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            añadirClienteToolStripMenuItem.Enabled = true;
            IdCliente = 0;
        }

        private void dGClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        #endregion


    }

}
