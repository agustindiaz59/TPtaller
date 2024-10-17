

namespace Gestion_Gym.Modelos
{
    public class Miembro : Persona
    {
        public Membresia TipoMembrecia { get; set; }
        public string DNI { get; set; }
        public string HorarioGYM { get; set; }
        public Miembro() : base()
        {
        }
        public Miembro(
            string nombre,
            string apellido,
            string dNI,
            string fNacimiento,
            char genero,
            string telefono,
            string email,
            string direccion,
            string fIngreso,
            Membresia tipoMembrecia,
            string horarioGYM) : base(nombre, apellido, fNacimiento, genero, telefono, email, direccion, fIngreso)
        {
            DNI = dNI;
            HorarioGYM = horarioGYM;
            TipoMembrecia = tipoMembrecia;

        }
        public override string ToString()
        {
            return 
                Nombre + " " +
                Apellido + " " +
                DNI + " " +
                FNacimiento + " " +
                Genero + " " +
                Telefono + " " +
                Email + " " +
                Direccion + " " +
                FIngreso + " " +
                TipoMembrecia + " " +
                HorarioGYM;
        }
    }
}
