using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Clases
{
    internal class Fibonacci
    {
        public static int limiteSecuenciaFibonacci = 0;
        public static int primerNumero = 0;
        public static int segundoNumero = 1;
        public static int siguienteNumero = 0;
        public static void ObtenerSecuenciaFibonacci()
        {
            Console.WriteLine("\tSerie de Fibonacci");
            Console.WriteLine("Ingrese la cantidad de terminos de la secuencia Fibonacci que desea mostrar:");
            limiteSecuenciaFibonacci = int.Parse(Console.ReadLine());
            Console.Write("Cadena de Fibonacci de los primeros " + limiteSecuenciaFibonacci + " términos: "); GenerarSecuenciaFibonacci();
        }
        public static void GenerarSecuenciaFibonacci()
        {
            for (int i = 0; i < limiteSecuenciaFibonacci; i++)
            {
                Console.Write(siguienteNumero + " ");
                primerNumero = segundoNumero;
                segundoNumero = siguienteNumero;
                siguienteNumero = primerNumero + segundoNumero;
            }
            Console.WriteLine();
        }
    }
}