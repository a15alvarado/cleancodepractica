using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode
{
    internal class ContadorVocalesConsonantes
    {
        public static void AnalizarTexto()
        {
            Console.WriteLine("\tContador de vocales y consonantes");
            Console.WriteLine("Ingrese una palabra o frase:");
            string texto = Console.ReadLine();
            DiferenciarVocalConsonante(texto);
        }
        public static void DiferenciarVocalConsonante(string texto)
        {
            int contadorVocales = 0;
            int contadorConsonantes = 0;
            foreach (char letra in texto)
            {
                if (char.IsLetter(letra))
                {
                    SepararVocalConsonante(letra, ref contadorVocales, ref contadorConsonantes);
                }
            }
            ImprimirAnalisisTexto(texto, contadorVocales, contadorConsonantes);
        }

        public static void SepararVocalConsonante(char letra, ref int contadorVocales, ref int contadorConsonantes)
        {
            if ("aeiouAEIOU".Contains(letra))
            {
                contadorVocales++;
            }
            else
            {
                contadorConsonantes++;
            }
        }
        public static void ImprimirAnalisisTexto(string texto, int contadorVocales, int contadorConsonantes)
        {
            Console.WriteLine($"La palabra o frase '{texto}' tiene {contadorVocales} vocales y {contadorConsonantes} consonantes");
        }
    }
}
