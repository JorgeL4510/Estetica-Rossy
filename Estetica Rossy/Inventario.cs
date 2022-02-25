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

        }

        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();

        DataTable dt;

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

        private void ImgActualiar_Click(object sender, EventArgs e)
        {
            dGInventario.DataSource = GetData("MostrarProductos");
        }
    }
}
