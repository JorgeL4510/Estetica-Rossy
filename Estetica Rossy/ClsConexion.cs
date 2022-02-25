using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Estetica_Rossy
{
    class ClsConexion
    {
        public SqlConnection DB_CONN;

        public ClsConexion()
        {
            try
            {
                DB_CONN = new SqlConnection(ConfigurationManager.ConnectionStrings["Estetica_Rossy.Properties.Settings.ConexionBD"].ConnectionString);
                DB_CONN.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudede conectar a la base de datos" + ex.ToString());
            }
        }

        public SqlConnection LeerCadena()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;
        }


    }
}
