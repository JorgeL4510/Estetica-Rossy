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
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }        

        private void Marcas_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        //Metodos
        #region

        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();

        DataTable dt;

        Categoria cat = new Categoria();

        int IdMarca = 0;
        string NombreMarca;
        private void Buscar()
        {
            try
            {
                cm = new SqlCommand("Buscar_Marca", DB_CONN.DB_CONN);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@Marca", SqlDbType.VarChar).Value = txtBuscar.Text;

                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                dGMarcas.DataSource = dt;
                dGMarcas.Columns["IdMarca"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
        }

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
            dGMarcas.DataSource = GetData("MostrarMarca");
            dGMarcas.Columns["IdMarca"].Visible = false;
        }

        private void LimpiarCampos()
        {
            this.txtNombreM.Text = string.Empty;
        }

        private void SeleccionarDatos()
        {//(IdProducto, IdMarca, IdProveedor, NombreP, IdMarca, Costo, Precio, Inventario, idProveedor)

            IdMarca = (int)dGMarcas.SelectedRows[0].Cells[0].Value;
            NombreMarca = dGMarcas.SelectedRows[0].Cells[1].Value.ToString();

            this.txtNombreM.Text = NombreMarca;

            añadirMarcaToolStripMenuItem.Enabled = false;
        }     



        #endregion

        //Funciones pantalla
        #region

        private void dGMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarDatos();
        }

        private void ImgActualiar_Click(object sender, EventArgs e)
        {
            dGMarcas.DataSource = GetData("MostrarMarca");
        }

        private void ImgCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            añadirMarcaToolStripMenuItem.Enabled = true;
            IdMarca = 0;
        }

        private void añadirMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombreM.Text == "")
            {
                MessageBox.Show("Datos ingresados incorrectamente");
            }
            else
            {
                try
                {
                    //Guardar info de la marca
                    //(IdMarca, Marca)
                    cm = new SqlCommand("AgregarMarca", DB_CONN.DB_CONN);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.Add("@Marca", SqlDbType.VarChar).Value = txtNombreM.Text; //Guardar el nombre de la marca

                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    cm.Dispose();
                    MessageBox.Show("Se registro la marca exitosamente");
                    LimpiarCampos(); //Limpiar los campos
                    LlenarGrid(); //Mostrar el registro en el Grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error " + ex.Message);
                }
            }
        }

        private void editarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer actualizar la marca?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtNombreM.Text == "" || IdMarca == 0)
                {
                    MessageBox.Show("No se ha seleccionado ningún campo o los datos se han ingresado incorrectamente");
                }
                else
                {
                    try
                    {
                        //(IdProducto, NombreP, IdMarca, Costo, Precio, Inventario, IdProveedor)
                        cm = new SqlCommand("ActualizarMarca", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.Add("@idMarca", SqlDbType.Int).Value = IdMarca; // Enviar el Id de la marca a editar
                        cm.Parameters.Add("@Marca", SqlDbType.VarChar).Value = txtNombreM.Text; //Guardar el nombre de la marca

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                        MessageBox.Show("Los datos de la marca se han actualizado correctamente");

                        IdMarca = 0;
                        añadirMarcaToolStripMenuItem.Enabled = true;
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

        private void eliminarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer eliminar la marca?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtNombreM.Text == "" || IdMarca == 0)
                {
                    MessageBox.Show("No se ha seleccionado ningún campo o los datos se han ingresado incorrectamente");
                }
                else
                {
                    try
                    {
                        cm = new SqlCommand("EliminarMarca", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.Add("@IdMarca", SqlDbType.Int).Value = IdMarca; // Enviar el Id del producto a eliminar

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                        MessageBox.Show("El producto se ha eliminado correctamente");

                        IdMarca = 0;
                        añadirMarcaToolStripMenuItem.Enabled = true;
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        #endregion




    }
}
