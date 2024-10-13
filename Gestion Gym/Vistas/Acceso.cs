using Gestion_Gym.Servicios.Persistencia;
using System;
using System.Windows.Forms;

namespace Gestion_Gym.Vistas
{
    public partial class Acceso : Form
    {
        PersonalDAO PersonalDAO = new PersonalDAO();
        public Acceso()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (PersonalDAO.VerificarCredenciales(txtBoxUsuario.Text, txtBoxContraseña.Text))
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

        private void Acceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
