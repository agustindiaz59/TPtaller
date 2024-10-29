using System.Text.RegularExpressions;

namespace Gestion_Gym.Servicios
{
    public static class Validacion
    {
        private static readonly Regex CadenaEstandar = new Regex(@"^[a-zA-Z ]+$");
        private static readonly Regex Email = new Regex(@"^[\d\w]+\@[\d\w]+\.[\d\w]+$");
        private static readonly Regex Celular = new Regex(@"^[0-9]{10}");
        private static readonly Regex Documento = new Regex(@"^[0-9]{8}");
        private static readonly Regex Cuil = new Regex(@"^\d{2}\-?\d{8}\-?\d{1}$");
        private static readonly Regex Fecha = new Regex(@"^\d{1,2}\/\d{1,2}\/\d{2,4}$");

        //Valida un texto que solo contiene caracteres alfabeticos, sin numeros
        public static bool ValidarCadenaEstandar(string cadenaEstandar) 
        {
       
            return CadenaEstandar.Match(cadenaEstandar).Success;
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
        public static bool ValidarFecha(string fecha)
        {
            return Fecha.IsMatch(fecha);
        }
    }
}
