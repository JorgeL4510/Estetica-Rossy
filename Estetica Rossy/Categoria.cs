using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Estetica_Rossy
{
    class Categoria
    {
        ClsConexion cn = new ClsConexion();

        public DataTable CargarCombo_Catalogo()
        {
            SqlDataAdapter da = new SqlDataAdapter("CMB_Catalogo_Productos", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargarCombo_DatosClientes()
        {
            SqlDataAdapter da = new SqlDataAdapter("CMB_Datos_Clientes", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable CargarCombo_DatosMarcas()
        {
            SqlDataAdapter da = new SqlDataAdapter("CMB_Datos_Marcas", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargarCombo_DatosProveedores()
        {
            SqlDataAdapter da = new SqlDataAdapter("CMB_Datos_Proveedores", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        

         public DataTable CargarCombo_DatosProductos()
        {
            SqlDataAdapter da = new SqlDataAdapter("CMB_Datos_Producto", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



    }
}
