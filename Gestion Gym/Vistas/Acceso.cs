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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text == "admin" && txtBoxContraseña.Text == "1234")
            {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El Usuario o Contraseña son Incorrectos. Por favor ingreselos nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
