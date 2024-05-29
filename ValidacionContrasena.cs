using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode
{
    internal class ValidacionContrasena
    {
        public static void VerificarContrasena()
        {
            Console.WriteLine("\tValidación de contraseña");
            Console.WriteLine("Ingrese una contraseña:");
            Console.WriteLine("NOTA:La contraseña debe tener al menos 8 caracteres, una letra mayúscula, un número y un carácter especial");
            string contrasena = Console.ReadLine();
            ChequeoIngresoCorrectoContrasena(contrasena);
        }
        public static void ChequeoIngresoCorrectoContrasena(string contrasena)
        {
            if (contrasena.Length < 8)
            {
                Console.WriteLine("La contraseña debe tener al menos 8 caracteres");
            }
            if (!contrasena.Any(char.IsUpper))
            {
                Console.WriteLine("La contraseña debe tener al menos una letra mayúscula");
            }
            if (!contrasena.Any(char.IsDigit))
            {
                Console.WriteLine("La contraseña debe tener al menos un número");
            }
            if (!contrasena.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                Console.WriteLine("La contraseña debe tener al menos un carácter especial");
            }
            if (contrasena.Length >= 8 && contrasena.Any(char.IsUpper) && contrasena.Any(char.IsDigit) && contrasena.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                Console.WriteLine("La contraseña es válida");
            }
        }
    }
}
