using Gestion_Gym.Servicios;
using System;

namespace Gestion_Gym.Modelos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FNacimiento { get; set; }
        public char Genero { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string FIngreso { get; set; }

        public Persona()
        {
        }
        public Persona(
            string nombre,
            string apellido,
            string fNacimiento,
            char genero,
            string telefono,
            string email,
            string direccion,
            string fIngreso
            )
        {
            Nombre = nombre;
            Apellido = apellido;
            FNacimiento = fNacimiento;
            Genero = genero;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            FIngreso = fIngreso;
        }
    }
}
