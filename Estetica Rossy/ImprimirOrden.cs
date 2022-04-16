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
    public partial class ImprimirOrden : Form
    {
        string UsuarioN;
        string CargoN;
        public ImprimirOrden(string Usuario, string Cargo)
        {
            InitializeComponent();
            DatosUsuario(Usuario, Cargo);
        }

        //Metodos
        #region
        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();


        DataTable dt;

        Categoria cat = new Categoria();
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

        private void BuscarOrden(string busqueda)
        {
            try
            {
                cm = new SqlCommand("BuscarOrden", DB_CONN.DB_CONN);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@Buscar", SqlDbType.VarChar).Value = busqueda;

                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                dGOrden.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
        }

        #endregion

        //Funciones pantalla
        #region

        private void ImgImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("MostrarOrdenId", DB_CONN.DB_CONN);
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.Add("@Id", SqlDbType.Int).Value = NUDOrden.Value;

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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al Agregar" + ex.Message);
            }
        }

        private void ImgCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            NUDOrden.Value = 0;
        }

        private void ImprimirOrden_Load(object sender, EventArgs e)
        {
            dGOrden.DataSource = GetData("EXEC MostrarOrden");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarOrden(txtBuscar.Text);
        }

        private void DTPFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("BuscarOrdenFecha", DB_CONN.DB_CONN);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@Buscar", SqlDbType.Date).Value = DTPFecha.Value;

                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                dGOrden.DataSource = dt;
                cm.Parameters.Clear();
                cm.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }

        }

        private void ImgActualiar_Click(object sender, EventArgs e)
        {
            dGOrden.DataSource = GetData("EXEC MostrarOrden");
        }
        #endregion

    }
}
