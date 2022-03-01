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

        public Cliente(string Usuario, string Cargo)
        {
            InitializeComponent();
            DatosUsuario(Usuario, Cargo);
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();

        DataTable dt;

        //Cambiar ventana
        #region
        private void inicioCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas min = new Citas(UsuarioN, CargoN);
            this.Dispose();
            min.ShowDialog();
        }
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario minv = new Inventario(UsuarioN, CargoN);
            this.Dispose();
            minv.ShowDialog();
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
        }

        private void LimpiarCampos()
        {
            this.txtNombreCliente.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;            
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
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
                    //(Nombre, Telefono)
                    cm = new SqlCommand("AgregarCliente", DB_CONN.DB_CONN);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombreCliente.Text; //Guardar el nombre del cliente
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

        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        
    }
}
