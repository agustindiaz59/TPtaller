using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Gestion_Gym.Servicios;
using Gestion_Gym.Vistas;

namespace Gestion_Gym
{
    public partial class Inicio : Form
    {
        bool sidebardExpand;
        public Inicio()
        {
            InitializeComponent();
            this.Load += new EventHandler(iniciobtn_Click);
        }

        private void MostrarFormularioEnPanel(Form formulario)
        {
            // Limpiar cualquier control que ya esté en el panel
            panelRedondo1.Controls.Clear();

            // Configurar el formulario para que no tenga bordes y sea un control secundario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel y mostrarlo
            panelRedondo1.Controls.Add(formulario);
            formulario.Show();


        }

        private void iniciobtn_Click(object sender, EventArgs e)
        {
            Dashboard mn = new Dashboard();
            MostrarFormularioEnPanel(mn);
        }

        private void nuevo1btn_Click(object sender, EventArgs e)
        {
            Nuevo_Miembro mn = new Nuevo_Miembro();
            MostrarFormularioEnPanel(mn);
        }

        private void nuevo2btn_Click(object sender, EventArgs e)
        {
            Nuevo_Personal mn = new Nuevo_Personal();
            MostrarFormularioEnPanel(mn);
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            Buscar_Miembro mn = new Buscar_Miembro();
            MostrarFormularioEnPanel(mn);
        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelRedondo1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebard_tick(object sender, EventArgs e)
        {
            if (sidebardExpand)
            {
                menuvertical.Width -= 10;
                if (menuvertical.Width == menuvertical.MinimumSize.Width)
                {
                    sidebardExpand = false;
                    sidebardtimer.Stop();
                }
            }
            else
            {
                menuvertical.Width += 10;
                if (menuvertical.Width == menuvertical.MaximumSize.Width)
                {
                    sidebardExpand = true;
                    sidebardtimer.Stop();
                }
            }
        }
        private void menuvertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btmenu_Click(object sender, EventArgs e)
        {
            sidebardtimer.Start();
        }
    }
}
