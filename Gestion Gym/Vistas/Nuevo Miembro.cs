using Gestion_Gym.Servicios.Persistencia;
using System;
using System.Windows.Forms;
using Gestion_Gym.Modelos;
using System.Drawing;
using System.Net;
using static Mysqlx.Crud.Order.Types;
using Gestion_Gym.Servicios;

namespace Gestion_Gym
{
    internal partial class Nuevo_Miembro : Form
    {
        //Accesos a la base de datos
        private DAO<Miembro> MiembroRepositorio = new MiembroDAO();

        public Nuevo_Miembro()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validarDatos =
                Validacion.ValidarCadenaEstandar(txtNombre.Text) &&
                Validacion.ValidarCadenaEstandar(txtApellido.Text) &&
                Validacion.ValidarDocumento(DNITB.Text) &&
                Validacion.ValidarFecha(FNacimDT.Text) &&
                Validacion.ValidarCelular(TelefonoTB.Text) &&
                Validacion.ValidarEmail(EmailTB.Text) &&
                Validacion.ValidarFecha(dateTimePickerFIngreso.Text.ToString()) &&
                Validacion.ValidarCadenaEstandar(DireccionTB.Text.ToString())
                ;

            if (validarDatos) 
            {
                GuardarMiembro();
            }
            else 
            {
                MessageBox.Show("Verifique que los datos sean correctos");
            }

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // limpiamos los campos llenados
            txtNombre.Clear();
            txtApellido.Clear();

            MasculinoRB.Checked = false;
            FemeninoRB.Checked = false;

            TelefonoTB.Clear();
            EmailTB.Clear();

            HorarioGymCB.ResetText();
            DireccionTB.Clear();
            MembresiaCB.ResetText();

            FNacimDT.Value = DateTime.Now;
            dateTimePickerFIngreso.Value = DateTime.Now;

        }

        private void NombreText_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void NombreText_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void Apellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void Apellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Silver;
            }
        }

        private void Dni_enter(object sender, EventArgs e)
        {
            if (DNITB.Text == "Ingresar el DNI")
            {
                DNITB.Text = "";
                DNITB.ForeColor = Color.Black;
            }
        }

        private void Dni_leave(object sender, EventArgs e)
        {
            if (DNITB.Text == "")
            {
                DNITB.Text = "Ingresar el DNI";
                DNITB.ForeColor = Color.Silver;
            }
        }

        private void email_enter(object sender, EventArgs e)
        {
            if (EmailTB.Text == "correo@ejemplo.com")
            {
                EmailTB.Text = "";
                EmailTB.ForeColor = Color.Black;
            }
        }

        private void email_leave(object sender, EventArgs e)
        {
            if (EmailTB.Text == "")
            {
                EmailTB.Text = "correo@ejemplo.com";
                EmailTB.ForeColor = Color.Silver;
            }
        }

        private void Tel_enter(object sender, EventArgs e)
        {
            if (TelefonoTB.Text == "Ingrese su teléfono")
            {
                TelefonoTB.Text = "";
                TelefonoTB.ForeColor = Color.Black;
            }
        }

        private void Tel_leave(object sender, EventArgs e)
        {
            if (TelefonoTB.Text == "")
            {
                TelefonoTB.Text = "Ingrese su teléfono";
                TelefonoTB.ForeColor = Color.Silver;
            }
        }

        private void Direccion_enter(object sender, EventArgs e)
        {
            if (DireccionTB.Text == "Ingrese su dirección")
            {
                DireccionTB.Text = "";
                DireccionTB.ForeColor = Color.Black;
            }
        }

        private void Direccion_leave(object sender, EventArgs e)
        {
            if (DireccionTB.Text == "")
            {
                DireccionTB.Text = "Ingrese su dirección";
                DireccionTB.ForeColor = Color.Silver;
            } 
        }

        private void Nuevo_Miembro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GuardarMiembro()
        {
            //Ejemplo de uso, por campos
            Miembro miembro1 = new Miembro();
            miembro1.Nombre = txtNombre.Text;
            miembro1.Apellido = txtApellido.Text;
            miembro1.DNI = DNITB.Text;
            miembro1.FNacimiento = FNacimDT.Text;
            miembro1.Telefono = TelefonoTB.Text;
            miembro1.Email = EmailTB.Text;
            miembro1.FIngreso = dateTimePickerFIngreso.Text;
            miembro1.HorarioGYM = HorarioGymCB.Text;
            miembro1.Direccion = DireccionTB.Text;
            miembro1.TipoMembrecia = (Membresia)(MembresiaCB.SelectedIndex + 1);

            if (MasculinoRB.Checked)
                miembro1.Genero = 'M';
            else if (FemeninoRB.Checked)
                miembro1.Genero = 'F';
            else
                miembro1.Genero = 'X';

            MiembroRepositorio.Guardar(miembro1);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nuevo_Miembro_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}