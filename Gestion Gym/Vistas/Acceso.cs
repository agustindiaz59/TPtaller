using System;
using System.Windows.Forms;

namespace Gestion_Gym.Vistas
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panelRedondo1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text == "admin" && txtBoxContraseña.Text == "1234")
            {
                Inicio fi = new Inicio();
                fi.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("El Usuario o Contraseña son Incorrectos. Por favor ingreselos nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
