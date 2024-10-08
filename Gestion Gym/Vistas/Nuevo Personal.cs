using Gestion_Gym.Modelos;
using Gestion_Gym.Servicios.Persistencia;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_Gym
{
    public partial class Nuevo_Personal : Form
    {
        //Acceso a la base de datos
        DAO<Personal> PersonalRepositorio = new PersonalDAO();

        public Nuevo_Personal()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            

            string genero = "";
            bool ischecked = radioButtonMasculino.Checked;

            if (ischecked)
            {
                genero = radioButtonMasculino.Text;
            }
            else
            {
                genero = radioButtonFemenino.Text;
            }
            string fnacim = dateTimePickerFNacim.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string fingreso = dateTimePickerFIngreso.Text;
            string calle = txtCalle.Text;
            string localidad = txtLocalidad.Text;
            string provincia = txtProvincia.Text;

            string direccion = calle + "," + localidad + "," + provincia;

            string cuil = textBox1.Text;

            Personal nuevo = new Personal(
                nombre,
                apellido,
                cuil,
                fnacim,
                genero.ToCharArray()[0],
                telefono,
                email,
                direccion,
                fingreso
                );

            PersonalRepositorio.Guardar(nuevo);

            MessageBox.Show("Datos Guardados Correctamente.");
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // limpiamos los campos llenados
            txtNombre.Clear();
            txtApellido.Clear();
           

            radioButtonMasculino.Checked = false;
            radioButtonFemenino.Checked = false;

            txtTelefono.Clear();
            txtEmail.Clear();

            txtCalle.Clear();
            txtLocalidad.Clear();
            txtProvincia.Clear();

            dateTimePickerFNacim.Value = DateTime.Now;
            dateTimePickerFIngreso.Value = DateTime.Now;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Desactivar la actualización visual temporalmente
            txtTelefono.SuspendLayout();

            // Operaciones que afectan la UI

            // Reactivar la actualización visual
            txtTelefono.ResumeLayout();
        }

        private void dateTimePickerFNacim_ValueChanged(object sender, EventArgs e)
        {
            // Desactivar la actualización visual temporalmente
            txtTelefono.SuspendLayout();

            // Operaciones que afectan la UI

            // Reactivar la actualización visual
            txtTelefono.ResumeLayout();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
