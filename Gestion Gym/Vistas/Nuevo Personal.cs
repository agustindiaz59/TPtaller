using Gestion_Gym.Modelos;
using Gestion_Gym.Servicios;
using Gestion_Gym.Servicios.Persistencia;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Gym
{
    public partial class Nuevo_Personal : Form
    {
        // Acceso a la base de datos
        private PersonalDAO personalDAO = new PersonalDAO();

        public Nuevo_Personal()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1) Tomar valores
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string cuil = textBox1.Text.Trim();

            char genero = radioButtonMasculino.Checked ? 'M' : 'F';

            string fnacim = dateTimePickerFNacim.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string email = txtEmail.Text.Trim();
            string fingreso = dateTimePickerFIngreso.Text.Trim();

            string calle = txtCalle.Text.Trim();
            string localidad = txtLocalidad.Text.Trim();
            string provincia = txtProvincia.Text.Trim();
            string direccion = $"{calle}, {localidad}, {provincia}";

            // 2) Validaciones
            bool validarDatos =
                Validacion.ValidarCadenaEstandar(nombre) &&
                Validacion.ValidarCadenaEstandar(apellido) &&
                Validacion.ValidarCuil(cuil) &&
                Validacion.ValidarFecha(fnacim) &&
                Validacion.ValidarCelular(telefono) &&
                Validacion.ValidarEmail(email) &&
                Validacion.ValidarFecha(fingreso) &&
                Validacion.ValidarCadenaEstandar(calle) &&
                Validacion.ValidarCadenaEstandar(localidad) &&
                Validacion.ValidarCadenaEstandar(provincia);

            if (!validarDatos)
            {
                MessageBox.Show("Verificá que los datos sean correctos.");
                return;
            }

            // 3) Construir entidad
            var nuevo = new Personal(
                nombre,
                apellido,
                cuil,
                fnacim,
                genero,
                telefono,
                email,
                direccion,
                fingreso
            );

            // 4) Guardar con control de duplicado (PersonalDAO.Guardar devuelve 0 si CUIL existe)
            try
            {
                int resultado = personalDAO.Guardar(nuevo);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos guardados correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("CUIL duplicado. No se guardaron los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            textBox1.Clear();

            radioButtonMasculino.Checked = false;
            radioButtonFemenino.Checked = false;

            txtTelefono.Clear();
            txtEmail.Clear();

            txtCalle.Clear();
            txtLocalidad.Clear();
            txtProvincia.Clear();

            dateTimePickerFNacim.Value = DateTime.Now;
            dateTimePickerFIngreso.Value = DateTime.Now;

            txtNombre.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.SuspendLayout();
            txtTelefono.ResumeLayout();
        }

        private void dateTimePickerFNacim_ValueChanged(object sender, EventArgs e)
        {
            txtTelefono.SuspendLayout();
            txtTelefono.ResumeLayout();
        }

        private void label13_Click(object sender, EventArgs e) { }

        private void nombre_enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void nombre_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void apellido_enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void apellido_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Silver;
            }
        }

        private void cuil_enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ingrese su CUIL")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void cuil_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Ingrese su CUIL";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void telefono_enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Ingrese su teléfono")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void telefono_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                txtTelefono.Text = "Ingrese su teléfono";
                txtTelefono.ForeColor = Color.Silver;
            }
        }

        private void email_enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "correo@ejemplo.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void email_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "correo@ejemplo.com";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void calle_enter(object sender, EventArgs e)
        {
            if (txtCalle.Text == "Ingrese su calle")
            {
                txtCalle.Text = "";
                txtCalle.ForeColor = Color.Black;
            }
        }

        private void calle_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCalle.Text))
            {
                txtCalle.Text = "Ingrese su calle";
                txtCalle.ForeColor = Color.Silver;
            }
        }

        private void localidad_enter(object sender, EventArgs e)
        {
            if (txtLocalidad.Text == "Ingrese su localidad")
            {
                txtLocalidad.Text = "";
                txtLocalidad.ForeColor = Color.Black;
            }
        }

        private void localidad_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocalidad.Text))
            {
                txtLocalidad.Text = "Ingrese su localidad";
                txtLocalidad.ForeColor = Color.Silver;
            }
        }

        private void Provincia_enter(object sender, EventArgs e)
        {
            if (txtProvincia.Text == "Ingrese su provincia")
            {
                txtProvincia.Text = "";
                txtProvincia.ForeColor = Color.Black;
            }
        }

        private void Provincia_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProvincia.Text))
            {
                txtProvincia.Text = "Ingrese su provincia";
                txtProvincia.ForeColor = Color.Silver;
            }
        }

        private void Nuevo_Personal_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        // Importante: no cierres toda la app al cerrar este formulario
        private void Nuevo_Personal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si este formulario es modal, simplemente cerralo.
            // Si es el principal, podés dejar Application.Exit();
            // Application.Exit(); // Evitar cerrar toda la app si no corresponde
        }
    }
}
