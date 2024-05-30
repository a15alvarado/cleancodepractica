using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode
{
    internal class SumaNumeroParImpar
    {
        public static void RevisarListaNumeroParImpar()
        {
            Console.WriteLine("\tSuma de números pares e impares");
            Console.WriteLine("Ingrese un listado de numeros separados por comas, sin espacios");
            string[] listaNumero = Console.ReadLine().Split(',',StringSplitOptions.RemoveEmptyEntries);
            int sumaPar = 0;
            int sumaImpar = 0;
            int[] listaNumeroPar = new int[listaNumero.Length];
            int[] listaNumeroImpar = new int[listaNumero.Length];
            for (int i = 0; i < listaNumero.Length; i++)
            {
                if (int.Parse(listaNumero[i]) % 2 == 0)
                {
                    listaNumeroPar[i] = int.Parse(listaNumero[i]);
                    sumaPar += listaNumeroPar[i];
                }
                else
                {
                    listaNumeroImpar[i] = int.Parse(listaNumero[i]);
                    sumaImpar += listaNumeroImpar[i];
                }
            }
            Console.Write("\nLista de numeros pares: ");
            ImprimirListaNumeros(listaNumeroPar);
            Console.WriteLine("\nLa suma de los números pares es: " + sumaPar);

            Console.Write("\nLista de numeros impares: ");
            ImprimirListaNumeros(listaNumeroImpar);
            Console.WriteLine("\nLa suma de los números impares es: " + sumaImpar);
            
            
        }
        public static void ImprimirListaNumeros(int[] lista)
        {
            foreach (var item in lista)
            {
                QuitarCeroLista(item);
            }
        }

        public static void QuitarCeroLista(int item)
        {
            if (item != 0)
            {
                Console.Write(item + ",");
            }
        }
    }
}
