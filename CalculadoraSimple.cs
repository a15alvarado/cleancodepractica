using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode
{
    internal class CalculadoraSimple
    {
        public static void ObtenerCalculosAritmeticos()
        {

            Console.WriteLine("\tCalculadora");
            float numeroOpcionOperacionAritmetica;
            //tablas_multiplicar.main();
            do
            {
                Console.WriteLine("Ingrese la operación a realizar:");
                Console.WriteLine("1)Suma    2)Resta    3)Multiplicar    4)Dividir    0)Salir");
                numeroOpcionOperacionAritmetica = float.Parse(Console.ReadLine());
                if (numeroOpcionOperacionAritmetica == 0) break;
                if (numeroOpcionOperacionAritmetica < 0 || numeroOpcionOperacionAritmetica > 4)
                {
                    Console.Write("Operación no válida, ");
                    continue;
                }
                Console.WriteLine("Ingrese No. 1:");
                float numero1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese No. 2:");
                float numero2 = float.Parse(Console.ReadLine());

                switch (numeroOpcionOperacionAritmetica)
                {
                    case 1:
                        Suma(numero1, numero2);
                        break;
                    case 2:
                        Resta(numero1, numero2);
                        break;
                    case 3:
                        Multiplicar(numero1, numero2);
                        break;
                    case 4:
                        Dividir(numero1, numero2);
                        break;
                }
            } while (numeroOpcionOperacionAritmetica != 0);

        }
        public static void Suma(float numero1, float numero2)
        {
            Console.WriteLine("La suma es: " + (numero1 + numero2));
        }
        public static void Resta(float numero1, float numero2)
        {
            Console.WriteLine("La resta es: " + (numero1 - numero2));
        }
        public static void  Multiplicar(float numero1, float numero2)
        {
            Console.WriteLine("La multiplicación es: " + (numero1 * numero2));
        }
        public static void Dividir(float numero1, float numero2)
        {
            if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividir por 0");
            }
            else
            {
                Console.WriteLine("La división es: " + (numero1 / numero2));
            }
        }
    }
}
