﻿using Gestion_Gym.Modelos;
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

            miembroDAO.Editar(miembro1);

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
    }
}
