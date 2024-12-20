﻿using Gestion_Gym.Modelos;
using Gestion_Gym.Servicios;
using Gestion_Gym.Servicios.Persistencia;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Gym
{
    public partial class Nuevo_Personal : Form
    {
        //Acceso a la base de datos
        private DAO<Personal> PersonalRepositorio = new PersonalDAO();

        public Nuevo_Personal()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;


            string genero = "";
            bool ischecked = radioButtonMasculino.Checked;

            if (ischecked)
            {
                genero = "M";
            }
            else
            {
                genero = "F";
            }
            string fnacim = dateTimePickerFNacim.Text.ToString();
            string telefono = txtTelefono.Text.ToString();
            string email = txtEmail.Text.ToString();
            string fingreso = dateTimePickerFIngreso.Text.ToString();
            string calle = txtCalle.Text.ToString();
            string localidad = txtLocalidad.Text.ToString();
            string provincia = txtProvincia.Text.ToString();

            string direccion = calle + " " + localidad + " " + provincia;

            string cuil = textBox1.Text.ToString();

            bool validarDatos =
                Validacion.ValidarCadenaEstandar(nombre) &&
                Validacion.ValidarCadenaEstandar(apellido) &&
                Validacion.ValidarCuil(cuil) &&
                Validacion.ValidarFecha(fnacim) &&
                Validacion.ValidarCelular(telefono) &&
                Validacion.ValidarEmail(email) &&
                Validacion.ValidarFecha(fingreso) &&
                Validacion.ValidarCadenaEstandar(direccion)
                ;

            //MessageBox.Show(
            //    nombre + Validacion.ValidarCadenaEstandar(nombre) +
            //    apellido + Validacion.ValidarCadenaEstandar(apellido) +
            //    cuil + Validacion.ValidarCuil(cuil) +
            //    fnacim + Validacion.ValidarFecha(fnacim) +
            //    telefono + Validacion.ValidarCelular(telefono) +
            //    email + Validacion.ValidarEmail(email) +
            //    fingreso + Validacion.ValidarFecha(fingreso) +
            //    direccion + Validacion.ValidarCadenaEstandar(direccion) 
            //    );

            if (validarDatos)
            {
                GuardarPersonal();
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
            if (txtNombre.Text == "")
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
            if (txtApellido.Text == "")
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
            if (textBox1.Text == "")
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
            if (txtTelefono.Text == "")
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
            if (txtEmail.Text == "")
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
            if (txtCalle.Text == "")
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
            if (txtLocalidad.Text == "")
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
            if (txtProvincia.Text == "")
            {
                txtProvincia.Text = "Ingrese su provincia";
                txtProvincia.ForeColor = Color.Silver;
            }
        }

        private void Nuevo_Personal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GuardarPersonal()
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

        private void Nuevo_Personal_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }
    }
}
