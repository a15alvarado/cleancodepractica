using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode
{
    internal class Fibonacci
    {
        public static void main()
        {
            Console.WriteLine("\tSerie de Fibonacci");
            Console.WriteLine("Ingrese la cantidad de terminos de la secuencia Fibonacci que desea mostrar:");
            int limiteSecuenciaFibonacci = int.Parse(Console.ReadLine());
            int primerNumero = 0;
            int segundoNumero = 1;
            int siguienteNumero = 0;
            for (int i = 0; i < limiteSecuenciaFibonacci; i++)
            {
                if(i <= 1)
                {
                    siguienteNumero = i;
                }
                else
                {
                    siguienteNumero = primerNumero + segundoNumero;
                    primerNumero = segundoNumero;
                    segundoNumero = siguienteNumero;
                }
                Console.Write(siguienteNumero + " ");
            }
           
        }
    }
}
