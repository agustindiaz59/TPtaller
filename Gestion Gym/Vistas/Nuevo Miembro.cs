using Gestion_Gym.Servicios.Persistencia;
using System;
using System.Windows.Forms;
using Gestion_Gym.Modelos;
using System.Drawing;
using System.Net;
using static Mysqlx.Crud.Order.Types;

namespace Gestion_Gym
{
    internal partial class Nuevo_Miembro : Form
    {
        //Accesos a la base de datos
        DAO<Miembro> MiembroRepositorio = new MiembroDAO();

        public Nuevo_Miembro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            miembro1.TipoMembrecia = (Membresia) MembresiaCB.SelectedIndex;
            
            if (MasculinoRB.Checked)
                miembro1.Genero = 'M';
            else if (FemeninoRB.Checked)
                miembro1.Genero = 'F';
            else
                miembro1.Genero = 'X';

            MiembroRepositorio.Guardar(miembro1);
            /*

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            string genero = "";
            bool ischecked = MasculinoRB.Checked;

            if (ischecked)
            {
                genero = MasculinoRB.Text;
            }
            else
            {
                genero = FemeninoRB.Text;
            }
            string fnacim = FNacimDT.Text;
            string email = EmailTB.Text;
            string fingreso = dateTimePickerFIngreso.Text;
            string horariogym = HorarioGymCB.Text;
            string direccion = DireccionTB.Text;
            string tiempomembresia = MembresiaCB.Text;


            //Ejemplo de uso, por constructor
            Miembro miembro = new Miembro
                (
                    nombre,
                    apellido,
                    DNITB.Text,
                    fnacim,
                    genero.ToCharArray()[0],
                    TelefonoTB.Text,
                    email,
                    direccion,
                    fingreso,
                    Membresia.STANDAR,
                    horariogym
                    
                );
            
            MiembroRepositorio.Guardar(miembro);

            /*
             * 
            SqlConnection con = new SqlConnection("data source = GONZALO; database = GymBD; integrated security = True;");
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "insert into Nuevo_Miembro (nombre,apellido,genero,fnacim, telefono,email,fingreso,horariogym, direccion, tiempomembresia) VALUES ('"+ nombre + "','" + apellido + "','"+ genero + "','" + fnacim  + "','"+ telefono + "','" + email + "','"+ fingreso + "','"+ horariogym+ "','" + direccion + "','"+ tiempomembresia + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            MessageBox.Show("Datos Guardados Correctamente.");
            */

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

        private void Nuevo_Miembro_Load(object sender, EventArgs e)
        {
           
        }

        private void panelRedondo1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
    }
}
