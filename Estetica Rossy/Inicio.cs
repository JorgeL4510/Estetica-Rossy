using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Estetica_Rossy
{
    public partial class Inicio : Form
    {        
     
        public string UsuarioN;
        public string CargoN;
        
        

        public Inicio()
        {
            InitializeComponent();
        }        

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login();
        }



        public void Login()
        {
            try
            {
                string Con = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(Con))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Nombre, Contraseña FROM Usuarios WHERE Nombre='" + txtUsuario.Text + "'AND Contraseña='" + txtContraseña.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        
                        if (dr.Read())
                        {                           
                            EsteticaTableAdapters.UsuariosTableAdapter ta = new EsteticaTableAdapters.UsuariosTableAdapter();
                            int cargo = (int)ta.GetCargo(txtUsuario.Text, txtContraseña.Text);
                            UsuarioN = ta.GetNombre(txtUsuario.Text, txtContraseña.Text);
                            
                            Acceder(cargo);                           
                        }
                        else
                        {
                            MessageBox.Show("Datos ingresados incorrectamente", "Sistema");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }


        private void Acceder(int Cargo)
        {
            if (Cargo == 1)
            {
                CargoN = "Administrador";
                Citas m = new Citas(UsuarioN, CargoN);               
                m.Show();
            }
            if (Cargo == 2)
            {
                CargoN = "Empleado";
                Cliente mc = new Cliente(UsuarioN, CargoN);                
                mc.Show();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt16(e.KeyChar) == Convert.ToInt16(Keys.Enter))
            {
                this.btnIngresar.PerformClick();
            }           
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == Convert.ToInt16(Keys.Enter))
            {
                this.txtContraseña.Focus();
            }
        }

        private void Inicio_Load_1(object sender, EventArgs e)
        {

        }
    }
}
