using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Gym.Vistas
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void nombre_enter(object sender, System.EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void nombre_leave(object sender, System.EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void apellido_enter(object sender, System.EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void apellido_leave(object sender, System.EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Silver;
            }
        }

        private void dni_enter(object sender, System.EventArgs e)
        {
            if (DNITB.Text == "Ingresar el DNI")
            {
                DNITB.Text = "";
                DNITB.ForeColor = Color.Black;
            }
        }

        private void dni_leave(object sender, System.EventArgs e)
        {
            if (DNITB.Text == "")
            {
                DNITB.Text = "Ingresar el DNI";
                DNITB.ForeColor = Color.Silver;
            }
        }

        private void correo_enter(object sender, System.EventArgs e)
        {
            if (EmailTB.Text == "correo@ejemplo.com")
            {
                EmailTB.Text = "";
                EmailTB.ForeColor = Color.Black;
            }
        }

        private void correo_leave(object sender, System.EventArgs e)
        {
            if (EmailTB.Text == "")
            {
                EmailTB.Text = "correo@ejemplo.com";
                EmailTB.ForeColor = Color.Silver;
            }
        }

        private void telefono_enter(object sender, System.EventArgs e)
        {
            if (TelefonoTB.Text == "Ingrese su teléfono")
            {
                TelefonoTB.Text = "";
                TelefonoTB.ForeColor = Color.Black;
            }
        }

        private void telefono_leave(object sender, System.EventArgs e)
        {
            if (TelefonoTB.Text == "")
            {
                TelefonoTB.Text = "Ingrese su teléfono";
                TelefonoTB.ForeColor = Color.Silver;
            }
        }

        private void direccion_enter(object sender, System.EventArgs e)
        {
            if (DireccionTB.Text == "Ingrese su dirección")
            {
                DireccionTB.Text = "";
                DireccionTB.ForeColor = Color.Black;
            }
        }

        private void direccion_leave(object sender, System.EventArgs e)
        {
            if (DireccionTB.Text == "")
            {
                DireccionTB.Text = "Ingrese su dirección";
                DireccionTB.ForeColor = Color.Silver;
            }
        }
    }
}
