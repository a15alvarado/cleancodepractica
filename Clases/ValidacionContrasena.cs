using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Clases
{
    internal class ValidacionContrasena
    {
        public static void VerificarContrasena()
        {
            bool esValida = false;
            do
            {
                Console.WriteLine("\tValidación de contraseña");
                Console.WriteLine("Ingrese una contraseña:");
                Console.WriteLine("NOTA:La contraseña debe tener al menos 8 caracteres, una letra mayúscula, un número y un carácter especial");
                string contrasena = Console.ReadLine();
                ChequeoIngresoCorrectoContrasena(contrasena, ref esValida);
            } while (!esValida);

        }
        public static void ChequeoIngresoCorrectoContrasena(string contrasena, ref bool esValida)
        {
            if (contrasena.Length < 8)
            {
                Console.WriteLine("La contraseña debe tener al menos 8 caracteres");
                esValida = false;
            }
            if (!contrasena.Any(char.IsUpper))
            {
                Console.WriteLine("La contraseña debe tener al menos una letra mayúscula");
                esValida = false;
            }
            if (!contrasena.Any(char.IsDigit))
            {
                Console.WriteLine("La contraseña debe tener al menos un número");
                esValida = false;
            }
            if (!contrasena.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                Console.WriteLine("La contraseña debe tener al menos un carácter especial");
                esValida = false;
            }
            if (contrasena.Length >= 8 && contrasena.Any(char.IsUpper) && contrasena.Any(char.IsDigit) && contrasena.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                Console.WriteLine("La contraseña es válida");
                esValida = true;
            }
        }
    }
}
