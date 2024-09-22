using System.Text.RegularExpressions;

namespace Gestion_Gym.Servicios
{
    internal static class Validacion
    {
        private static readonly Regex CadenaEstandar = new Regex(@"^[a-zA-Z]+$");
        private static readonly Regex Email = new Regex(@"[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[(com)|(net)]");
        private static readonly Regex Celular = new Regex(@"[0-9]{10}");
        private static readonly Regex Documento = new Regex(@"[0-9]{10}");
        private static readonly Regex Cuil = new Regex(@"[1-9]{2}[-]?[0-9]{10}[-]?[1-9]");

        //Valida un texto que solo contiene caracteres alfabeticos, sin numeros
        public static bool ValidarCadenaEstandar(string cadenaEstandar) 
        {
            return CadenaEstandar.IsMatch(cadenaEstandar);
        }

        //Valida un texto con formato de email ejemplo@dominio.com|.net
        public static bool ValidarEmail(string email) 
        {  
            return Email.IsMatch(email); 
        }

        public static bool ValidarCelular(string celular) 
        {
            return Celular.IsMatch(celular);
        }
        //Valida un texto de documento DNI sin puntos, comas ni guiones
        public static bool ValidarDocumento(string documento) 
        {
            return Documento.IsMatch(documento);
        }
        public static bool ValidarCuil(string cuil) 
        {
            return Cuil.IsMatch(cuil);
        }
    }
}
