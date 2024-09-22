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

namespace Gestion_Gym
{
    public partial class Buscar_Miembro : Form
    {
        public Buscar_Miembro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            { 
          
            //CONEXION BaSE DE DATOS

            SqlConnection con = new SqlConnection(); // Crea un objeto sqlconnection */
            con.ConnectionString = "data source = GONZALO; database = GymBD; integrated security = True;"; // agrega una cadena de conexion que especifica servidor GONZALO y la BASE DE DATOS 
            SqlCommand cmd = new SqlCommand(); // CREA UN OBJETO SqlCommand 
            cmd.Connection = con; // asigna la conexion al comando recien creado 

            cmd.CommandText = "select * from Nuevo_Miembro where miembroID = " + txtBuscar.Text + " ";

            SqlDataAdapter DA = new SqlDataAdapter (cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables [0];
            }

            else
            {
                MessageBox.Show(" Por Favor Ingrese algun ID", "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buscar_Miembro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
