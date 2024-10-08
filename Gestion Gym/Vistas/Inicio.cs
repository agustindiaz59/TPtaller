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
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

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
            Application.Exit();
        }

        private void panelRedondo1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebard_tick(object sender, EventArgs e)
        {
            // Definir el paso de la animación
            const int step = 40; // Puedes ajustar este valor para más o menos velocidad

            if (sidebardExpand)
            {
                // Reducir el ancho de la barra lateral
                menuvertical.Width = Math.Max(menuvertical.Width - step, menuvertical.MinimumSize.Width);
                // Si ha alcanzado el tamaño mínimo
                if (menuvertical.Width == menuvertical.MinimumSize.Width)
                {
                    sidebardExpand = false; // Cambiar el estado
                    sidebardtimer.Stop(); // Detener el temporizador
                }
            }
            else
            {
                // Aumentar el ancho de la barra lateral
                menuvertical.Width = Math.Min(menuvertical.Width + step, menuvertical.MaximumSize.Width);
                // Si ha alcanzado el tamaño máximo
                if (menuvertical.Width == menuvertical.MaximumSize.Width)
                {
                    sidebardExpand = true; // Cambiar el estado
                    sidebardtimer.Stop(); // Detener el temporizador
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

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
