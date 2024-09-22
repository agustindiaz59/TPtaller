using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Gym.Modelos
{
    internal class Usuario
    {
        private string NombreUsuario{get;set;}
        private string Contrasenia{get;set;}

        public Usuario() 
        {
            
        }

        public Usuario(string Usuario, string Contrasenia)
        {
            this.NombreUsuario = Usuario;
            this.Contrasenia = Contrasenia;
        }
    }
}
