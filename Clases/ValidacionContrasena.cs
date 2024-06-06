using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Clases
{
    internal class ValidacionContrasena
    {
        public static bool esValida=false;
        public static void VerificarContrasena()
        {
            
            do
            {
                Console.WriteLine("\tValidación de contraseña");
                Console.WriteLine("Ingrese una contraseña:");
                Console.WriteLine("NOTA:La contraseña debe tener al menos 8 caracteres, una letra mayúscula, un número y un carácter especial");
                string contrasena = Console.ReadLine();
                esValida= ChequeoIngresoCorrectoContrasena(contrasena);
            } while (!esValida);

        }
        public static bool ChequeoIngresoCorrectoContrasena(string contrasena)
        {
            if (contrasena.Length < 8)
            {
                Console.WriteLine("La contraseña debe tener al menos 8 caracteres");
                return false;
            }
            if (!contrasena.Any(char.IsUpper))
            {
                Console.WriteLine("La contraseña debe tener al menos una letra mayúscula");
                return false;
            }
            if (!contrasena.Any(char.IsDigit))
            {
                Console.WriteLine("La contraseña debe tener al menos un número");
                return false;
            }
            if (!contrasena.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                Console.WriteLine("La contraseña debe tener al menos un carácter especial");
                return false;
            }
            Console.WriteLine("La contraseña es válida\n");
            return true;
        }
    }
}
