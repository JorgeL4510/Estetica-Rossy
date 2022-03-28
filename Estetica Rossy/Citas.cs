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
    public partial class Citas : Form
    {
        String UsuarioN;
        String CargoN;

        Inicio U = new Inicio();
        
        


        Categoria cat = new Categoria();
        public Citas(string Usuario, string Cargo)
        {
            InitializeComponent();
            UsuarioN = Usuario;
            CargoN = Cargo;
            lblUsuario.Text = "Usuario: " + Usuario;
            lblCargo.Text = Cargo;
        }


        private void Citas_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            LlenarGrid();
            //dTFechaCita.MinDate = DateTime.Today;
        }

        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();

        DataTable dt;

        //idCita, Cliente, Telefono, Fecha, HoraInicio, Tratamiento, Cancelacion       
        int IdCita = 0;
        int IdCliente = 0;
        string Cliente;
        string Telefono;
        DateTime Fecha;
        string HoraInicio;
        string Tratamiento;
        Boolean Cancelacion;     

        //Cambiar ventana
        #region
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente mic = new Cliente(UsuarioN, CargoN);
            mic.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario minv = new Inventario(UsuarioN, CargoN);
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

        private void LimpiarCampos()
        {
            this.CMBCliente.SelectedIndex = 0;
            this.txtHoraInicio.Text = string.Empty;
            this.txtTratamiento.Text = string.Empty;            
            //this.dTFechaCita.Value = DateTime.Today;
            this.CBCancelacion.Checked = false;            
        }

        private void Buscar()
        {
            try
            {
                cm = new SqlCommand("Buscar_Cita", DB_CONN.DB_CONN);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@Fecha", SqlDbType.Date).Value = dTPBuscar.Value; //Guardar Fecha de Cita para realizar busqueda

                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                dGCitas.DataSource = dt;
                dGCitas.Columns["IdCita"].Visible = false;
                dGCitas.Columns["IdCliente"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
        }


        private void LlenarGrid()
        {
            dGCitas.DataSource = GetData("MostrarCita");
            dGCitas.Columns["IdCita"].Visible = false;
            dGCitas.Columns["IdCliente"].Visible = false;
        }

        private void CargarComboBox()
        {
            try
            {
                CMBCliente.DataSource = cat.CargarCombo_DatosClientes();
                CMBCliente.DisplayMember = "Nombre";
                CMBCliente.ValueMember = "IdCliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar algunos datos: " + ex.Message);
            }
        }

        private bool Condiciones()
        {
            if (CBCancelacion.Checked == true  || dTFechaCita.Value < DateTime.Today || txtHoraInicio.Text == "" || txtTratamiento.Text == "")
            {
                return true;
            }
            else
                return false;
        }

        private void SeleccionarDatos()
        { //idCita, IdCliente, (Nombre)Cliente, Telefono, Fecha, HoraInicio, Tratamiento
         
            IdCita = (int)dGCitas.SelectedRows[0].Cells[0].Value;
            IdCliente = (int)dGCitas.SelectedRows[0].Cells[1].Value;
            Cliente = dGCitas.SelectedRows[0].Cells[2].Value.ToString();
            //Telefono = dGCitas.SelectedRows[0].Cells[3].Value.ToString();
            Fecha = (DateTime)dGCitas.SelectedRows[0].Cells[4].Value;
            HoraInicio = dGCitas.SelectedRows[0].Cells[5].Value.ToString();
            Tratamiento = dGCitas.SelectedRows[0].Cells[6].Value.ToString();
            Cancelacion = (bool)dGCitas.SelectedRows[0].Cells[7].Value;

            this.CMBCliente.SelectedValue = IdCliente;
            this.txtHoraInicio.Text = HoraInicio;
            this.txtTratamiento.Text = Tratamiento.ToString();
            this.dTFechaCita.Value = Fecha;
            this.CBCancelacion.Checked = Cancelacion;

            añadirCitaToolStripMenuItem.Enabled = false;
        }

        #endregion

        //Funciones Pantalla
        #region

        private void dTPBuscar_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ImgActualiar_Click(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void añadirCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Condiciones())
            {
                MessageBox.Show("Datos ingresados incorrectamente");
            }
            else
            {
                try
                {
                    //Guardar info de la cita
                    //(Fecha, HoraInicio, HoraFin, Cancelacion, IdCliente)
                    cm = new SqlCommand("AgregarCita", DB_CONN.DB_CONN);
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add("@Fecha", SqlDbType.Date).Value = dTFechaCita.Value; //Guardar Fecha de Cita
                    cm.Parameters.Add("@HoraInicio", SqlDbType.VarChar).Value = txtHoraInicio.Text; // Guardar Hora de inicio de cita                    
                    cm.Parameters.Add("@Cancelacion", SqlDbType.Bit).Value = CBCancelacion.Checked; // En caso de cancelacion de cita, se modifica por el checkbox
                    cm.Parameters.Add("@idCliente", SqlDbType.Int).Value = CMBCliente.SelectedValue; // Guardar al cliente que agendo la cita
                    cm.Parameters.Add("@Tratamiento", SqlDbType.VarChar).Value = txtTratamiento.Text;

                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    cm.Dispose();
                    MessageBox.Show("Se registro la cita exitosamente");
                    LimpiarCampos(); //Limpiar los campos
                    LlenarGrid(); //Mostrar el registro en el Grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error " + ex.Message);
                }
            }

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer actualizar la cita?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dTFechaCita.Value < DateTime.Today || txtHoraInicio.Text == "" || txtTratamiento.Text == "" || IdCita == 0)
                {
                    MessageBox.Show("No se ha seleccionado ningún campo o los datos se han ingresado incorrectamente");
                }
                else
                {
                    try
                    {
                        //(Fecha, HoraInicio, HoraFin, Cancelacion, IdCliente)
                        cm = new SqlCommand("ActualizarCita", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.Add("@idCita", SqlDbType.Int).Value = IdCita; // Enviar el Id de la cita a modificar
                        cm.Parameters.Add("@Fecha", SqlDbType.Date).Value = dTFechaCita.Value; //Modificar la Fecha de Cita
                        cm.Parameters.Add("@HoraInicio", SqlDbType.VarChar).Value = txtHoraInicio.Text; // Modificar Hora de inicio de cita                    
                        cm.Parameters.Add("@Cancelacion", SqlDbType.Bit).Value = CBCancelacion.Checked; // Cambiar estado de la cita (Cancelacion: Si/No)
                        cm.Parameters.Add("@idCliente", SqlDbType.Int).Value = CMBCliente.SelectedValue; // Modificar el cliente que agendo la cita
                        cm.Parameters.Add("@Tratamiento", SqlDbType.VarChar).Value = txtTratamiento.Text; // Modificar el tratamiento

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                        MessageBox.Show("Los datos de la cita se han actualizado correctamente");

                        IdCita = 0;
                        añadirCitaToolStripMenuItem.Enabled = true;                        
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
            if (MessageBox.Show("¿Esta seguro de querer eliminar la cita?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Condiciones() || IdCita == 0)
                {
                    MessageBox.Show("No se ha seleccionado ningún campo o los datos se han ingresado incorrectamente");
                }
                else
                {
                    try
                    {
                        cm = new SqlCommand("EliminarCita", DB_CONN.DB_CONN);
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.Add("@idCita", SqlDbType.Int).Value = IdCita; // Enviar el Id de la cita a eliminar

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        cm.Dispose();
                        MessageBox.Show("La cita se ha eliminado correctamente");

                        IdCita = 0;
                        añadirCitaToolStripMenuItem.Enabled = true;
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

        private void dGCitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarDatos();
        }

        private void citasCanceladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGCitas.DataSource = GetData("Buscar_Citas_Canceladas");
        }

        private void todasLasCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGCitas.DataSource = GetData("Mostrar_Todas_Citas");
        }

        private void citasDeHoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGCitas.DataSource = GetData("Citas_Hoy");
        }

        private void ImgCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            añadirCitaToolStripMenuItem.Enabled = true;
            IdCita = 0;
            IdCliente = 0;
        }

        #endregion



    }
}
