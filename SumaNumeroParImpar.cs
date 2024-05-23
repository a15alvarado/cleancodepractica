using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode
{
    internal class SumaNumeroParImpar
    {
        public static void main()
        {
            Console.WriteLine("\tSuma de números pares e impares");
            Console.WriteLine("Ingrese un listado de numeros separados por comas, sin espacios");
            string[] numero = Console.ReadLine().Split(',',StringSplitOptions.RemoveEmptyEntries);
            int sumaPar = 0;
            int sumaImpar = 0;
            int[]numeroPar = new int[numero.Length];
            int[]numeroImpar = new int[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                if (int.Parse(numero[i]) % 2 == 0)
                {
                    numeroPar[i] = int.Parse(numero[i]);
                    sumaPar += numeroPar[i];
                }
                else
                {
                    numeroImpar[i] = int.Parse(numero[i]);
                    sumaImpar += numeroImpar[i];
                }
            }
            Console.Write("\nLista de numeros pares: ");
            ImprimirLista(numeroPar);
            Console.WriteLine("\nLa suma de los números pares es: " + sumaPar);

            Console.Write("\nLista de numeros impares: ");
            ImprimirLista(numeroImpar);
            Console.WriteLine("\nLa suma de los números impares es: " + sumaImpar);
            
            void ImprimirLista(int[] lista)
            {
                foreach (var item in lista)
                {
                    QuitarCero(item);
                }
            }

            void QuitarCero(int item)
            {
                if (item != 0)
                {
                    Console.Write(item + ",");
                }
            }
        }
    }
}
