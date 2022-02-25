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

        public DataTable CargarCombo_DatosHorarioInicio()
        {
            SqlDataAdapter da = new SqlDataAdapter("CMB_Datos_HorarioInicio", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargarCombo_DatosHorarioFin()
        {
            SqlDataAdapter da = new SqlDataAdapter("CMB_Datos_HorarioFin", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
