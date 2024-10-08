using Gestion_Gym.Modelos;
using Gestion_Gym.Servicios.Persistencia;
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
        private MiembroDAO repositorio = new MiembroDAO();
        public Buscar_Miembro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                List<Miembro> miembros = new List<Miembro>();
                miembros.Add(repositorio.Traer(txtBuscar.Text));

                dataGridView1.DataSource = miembros;
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
