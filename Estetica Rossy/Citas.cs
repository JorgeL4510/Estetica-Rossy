﻿using System;
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
        Categoria cat = new Categoria();
        public Citas(string Usuario, string Cargo)
        {
            InitializeComponent();
            UsuarioN = Usuario;
            CargoN = Cargo;
            lblUsuario.Text = "Usuario: " + Usuario;
            lblCargo.Text = Cargo;
            //LlenarGrid();
        }

        
        private void Citas_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        ClsConexion DB_CONN = new ClsConexion();
        SqlCommand cm = new SqlCommand();

        DataTable dt;
        string IdCliente;

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
            this.dTPBuscar.Value = DateTime.Now;
            this.CMBCliente.SelectedIndex = 0;
            this.CMBHoraFin.SelectedIndex = 0;
            this.CMBHoraInicio.SelectedIndex = 0;
            this.CBCancelacion.Checked = false;
            dTFechaCita.MinDate = DateTime.Today;
        }

        private void Buscar()
        {
            try
            {
                cm = new SqlCommand("Buscar_Cita", DB_CONN.DB_CONN);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@Fecha", SqlDbType.Date).Value = dTPBuscar.Value; //Guardar Fecha de Cita


                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                dGCitas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
        }


        private void LlenarGrid()
        {
            dGCitas.DataSource = GetData("MostrarCita");
        }

        private void CargarComboBox()
        {
            try
            {
                CMBCliente.DataSource = cat.CargarCombo_DatosClientes();
                CMBCliente.DisplayMember = "Nombre";
                CMBCliente.ValueMember = "IdCliente";

                CMBHoraInicio.DataSource = cat.CargarCombo_DatosHorarioInicio();
                CMBHoraInicio.DisplayMember = "HoraInicio";
                CMBHoraInicio.ValueMember = "IdHoraInicio";

                CMBHoraFin.DataSource = cat.CargarCombo_DatosHorarioFin();
                CMBHoraFin.DisplayMember = "HoraFin";
                CMBHoraFin.ValueMember = "IdHoraFin";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar las ComboBox" + ex.Message);
            }
        }

        private int? GetID()
        {
            try
            {                
                return int.Parse(dGCitas.Rows[dGCitas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        #endregion

        //Funciones Pantalla
        #region

        private void ImgLupa_Click_1(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ImgActualiar_Click(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void añadirCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CBCancelacion.Checked == true || (int)CMBHoraInicio.SelectedValue > (int)CMBHoraFin.SelectedValue)
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
                    cm.Parameters.Add("@HoraInicio", SqlDbType.Int).Value = CMBHoraInicio.SelectedValue; // Guardar Hora de inicio de cita
                    cm.Parameters.Add("@HoraFin", SqlDbType.Int).Value = CMBHoraFin.SelectedValue; // Guardar Hora de fin de cita
                    cm.Parameters.Add("@Cancelacion", SqlDbType.Bit).Value = CBCancelacion.Checked; // En caso de cancelacion de cita, se modifica por el checkbox
                    cm.Parameters.Add("@idCliente", SqlDbType.Int).Value = CMBCliente.SelectedValue; // Guardar al cliente que agendo la cita

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

        #endregion


    }
}
