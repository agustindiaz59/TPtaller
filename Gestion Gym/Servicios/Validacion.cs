using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gestion_Gym.Servicios
{
    public static class Validacion
    {
        private static readonly Regex CadenaEstandar = new Regex(@"^[a-zA-Z ]+$");
        private static readonly Regex Email = new Regex(@"^[\d\w]+\@[\d\w]+\.[\d\w]+$");
        private static readonly Regex Celular = new Regex(@"^[0-9]{10}$");
        private static readonly Regex Documento = new Regex(@"^[0-9A-Z]{8}$");
        private static readonly Regex Cuil = new Regex(@"^\d{2}\-?\d{8}\-?\d{1}$");
        private static readonly Regex Fecha = new Regex(@"^\d{1,2}\/\d{1,2}\/\d{2,4}$");









        //Valida un texto que solo contiene caracteres alfabeticos, sin numeros
        public static bool ValidarCadenaEstandar(string cadenaEstandar) 
        {
            if (cadenaEstandar.Trim().Equals("") || cadenaEstandar.Trim().Contains("Nombre") || cadenaEstandar.Trim().Contains("Apellido")) return false;
            
            return CadenaEstandar.Match(cadenaEstandar).Success;
        }








        public static bool ValidarCadenaEstandar(string cadenaEstandar, string Nombre)
        {

            if (ValidarCadenaEstandar(cadenaEstandar)) 
            {
                return true;
            }
            else
            {
                MessageBox.Show($"El campo {Nombre} es inválido");
                return false;
            }



        }













        //Valida un texto con formato de email ejemplo@dominio.com|.net
        public static bool ValidarEmail(string email)
        {
            if (email.Trim().Equals("") || email.Trim().Contains("correo@ejemplo.com")) return false;
            return Email.IsMatch(email); 
        }













        public static bool ValidarEmail(string email, string Nombre)
        {
            if(ValidarEmail(email))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"El campo {Nombre} es inválido");
                return false;
            }
        }












        public static bool ValidarCelular(string celular)
        {
            if (celular.Trim().Equals("")) return false;
            return Celular.IsMatch(celular);
        }












        public static bool ValidarCelular(string celular, string Nombre)
        {
            
            if(ValidarCelular(celular))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"El campo {Nombre} es inválido");
                return false;
            }
        }











        //Valida un texto de documento DNI sin puntos, comas ni guiones
        public static bool ValidarDocumento(string documento)
        {
            if (documento.Trim().Equals("")) return false;
            return Documento.IsMatch(documento);
        }












        public static bool ValidarDocumento(string documento, string Nombre)
        {
            if(ValidarDocumento(documento))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"El campo {Nombre} es inválido");
                return false;
            }
        }











        public static bool ValidarCuil(string cuil) 
        {
            if (cuil.Trim().Equals("")) return false;
            return Cuil.IsMatch(cuil);
        }











        public static bool ValidarCuil(string cuil, string Nombre)
        {
            if(ValidarCuil(cuil))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"El campo {Nombre} es inválido");
                return false;
            }
        }












        public static bool ValidarFecha(string fecha)
        {
            if (fecha.Trim().Equals("")) return false;
            return Fecha.IsMatch(fecha);
        }











        public static bool ValidarFecha(string fecha, string Nombre)
        {
            if (ValidarFecha(fecha))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"El campo {Nombre} es inválido");
                return false;
            }
        }
    }
}
