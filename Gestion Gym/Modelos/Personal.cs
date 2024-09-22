
using Gestion_Gym.Servicios;
using System;

namespace Gestion_Gym.Modelos
{
    public class Personal : Persona
    {

        public string Cuil { get; set; }

        public Personal(
            string nombre,
            string apellido,
            string cuil,
            string fNacimiento,
            char genero,
            string telefono,
            string email,
            string direccion,
            string fIngreso) : base(nombre, apellido, fNacimiento, genero, telefono, email, direccion, fIngreso)
        {
            Cuil = cuil;
        }

    }
}
