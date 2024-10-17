using Gestion_Gym.Servicios.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Gym.Vistas
{
    public partial class Dashboard : Form
    {
        private MiembroDAO miembroDAO = new MiembroDAO();
        private PersonalDAO personalDAO = new PersonalDAO();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            TotalActivosLBL.Text = miembroDAO.TraerTodos().Count().ToString();
            PersonalActivoLBL.Text = personalDAO.TraerTodos().Count().ToString();
            MiembrosMesLBL.Text = miembroDAO.Select(
                "select * from miembro m " +
                "inner join persona p " +
                "on m.id_persona = p.id_persona " +
                $"where p.f_inicio like '%{DateTime.Today.Month}%' ").Count().ToString();
        }


        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
