using Gestion_Gym.Modelos;
using Gestion_Gym.Servicios.Persistencia;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Gestion_Gym.Vistas
{
    public partial class Editar : Form
    {
        private MiembroDAO miembroDAO = new MiembroDAO();
        private Miembro editar;
        Buscar_Miembro buscar_Miembro;
        public Editar(string DNI, Buscar_Miembro buscar_Miembro)
        {
            InitializeComponent();

            this.buscar_Miembro = buscar_Miembro;

            editar = miembroDAO.Traer(DNI);

            txtNombre.Text = editar.Nombre;
            txtApellido.Text = editar.Apellido;
            DNITB.Text = DNI.Trim();
            FNacimDT.Text = editar.FNacimiento;
            dateTimePickerFIngreso.Text = editar.FIngreso;
            EmailTB.Text = editar.Email;
            DireccionTB.Text = editar.Direccion.ToString();
            MembresiaCB.SelectedIndex = Convert.ToInt32(editar.TipoMembrecia) - 1;
            HorarioGymCB.Text = editar.HorarioGYM.ToString();
            TelefonoTB.Text = editar.Telefono.ToString();
            

            if (editar.Genero == 'F' || editar.Genero == 'f')
                FemeninoRB.Checked = true;
            else
                MasculinoRB.Checked = true;

            txtNombre.Focus();
            DNITB.Enabled = false;
            DNITB.Enabled = false;
            FNacimDT.MaxDate = DateTime.Now;
            //dateTimePickerFIngreso.MinDate = DateTime.Now;
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

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            //Ejemplo de uso, por campos
            Miembro editar = new Miembro();
            editar.Nombre = txtNombre.Text;
            editar.Apellido = txtApellido.Text;
            // NO CAMBIES el DNI
            editar.FNacimiento = FNacimDT.Text;
            editar.Telefono = TelefonoTB.Text;
            editar.Email = EmailTB.Text;
            editar.FIngreso = dateTimePickerFIngreso.Text;
            editar.HorarioGYM = HorarioGymCB.Text;
            editar.Direccion = DireccionTB.Text;
            editar.TipoMembrecia = (Membresia)(MembresiaCB.SelectedIndex + 1);

            if (MasculinoRB.Checked)
                editar.Genero = 'M';
            else if (FemeninoRB.Checked)
                editar.Genero = 'F';
            else
                editar.Genero = 'X';

            miembroDAO.Editar(editar);

            buscar_Miembro.CargarMiembros(miembroDAO.TraerTodos());
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Realizar la acción importante
                miembroDAO.Eliminar(editar.DNI);
                MessageBox.Show("Datos Eliminados Correctamente.");
                Close();
                buscar_Miembro.CargarMiembros(miembroDAO.TraerTodos());
            }
        }
        private void btnReiniciar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFIngreso_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePickerFIngreso.Value < DateTime.Now)
            {
                MessageBox.Show("error de fecha");
            }
        }
    }
}
