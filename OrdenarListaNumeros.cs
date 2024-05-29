using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode
{
    internal class OrdenarListaNumeros
    {
        public static void ObtenerNumerosEnterosOrdenados()
        {
            Console.WriteLine("\tOrdenador ascendente y descendente de lista de números");
            Console.WriteLine("Ingrese los números separados por coma");
            string[] filtroListaNumeros = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            OrdenarListaNumerosAscendente(filtroListaNumeros);
            OrdenarListaNumerosDescendente(filtroListaNumeros);            
        }
        public static void OrdenarListaNumerosAscendente(string[] filtroListaNumeros)
        {
            int[] listaNumerosEnteros = new int[filtroListaNumeros.Length];
            for (int i = 0; i < filtroListaNumeros.Length; i++)
            {
                listaNumerosEnteros[i] = int.Parse(filtroListaNumeros[i]);
            }
            Array.Sort(listaNumerosEnteros);
            Console.WriteLine("Lista de números ordenados de forma ascendente:");
            foreach (var numerosOrdenados in listaNumerosEnteros)
            {
                Console.Write(numerosOrdenados + ",");
            }
            Console.WriteLine();
        }
        public static void OrdenarListaNumerosDescendente(string[] filtroListaNumeros)
        {
            int[] listaNumerosEnteros = new int[filtroListaNumeros.Length];
            for (int i = 0; i < filtroListaNumeros.Length; i++)
            {
                listaNumerosEnteros[i] = int.Parse(filtroListaNumeros[i]);
            }
            Array.Sort(listaNumerosEnteros);
            Array.Reverse(listaNumerosEnteros);
            Console.WriteLine("Lista de números ordenados de forma descendente:");
            foreach (var numerosOrdenados in listaNumerosEnteros)
            {
                Console.Write(numerosOrdenados + ",");
            }
            Console.WriteLine();
        }
        
    }
}
