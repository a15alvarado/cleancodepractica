﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode
{
    internal class CalculadoraSimple
    {
        public static void main()
        {

            Console.WriteLine("\tCalculadora");
            float menuOperacionAritmetica;
            //tablas_multiplicar.main();
            do
            {
                Console.WriteLine("Ingrese la operación a realizar:");
                Console.WriteLine("1)Suma    2)Resta    3)Multiplicar    4)Dividir    0)Salir");
                menuOperacionAritmetica = float.Parse(Console.ReadLine());
                if (menuOperacionAritmetica == 0) break;
                if (menuOperacionAritmetica < 0 || menuOperacionAritmetica > 4)
                {
                    Console.Write("Operación no válida, ");
                    continue;
                }
                Console.WriteLine("Ingrese No. 1:");
                float numero1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese No. 2:");
                float numero2 = float.Parse(Console.ReadLine());

                switch (menuOperacionAritmetica)
                {
                    case 1:
                        Console.WriteLine("La suma es: " + Suma(numero1, numero2));
                        break;
                    case 2:
                        Console.WriteLine("La resta es: " + Resta(numero1, numero2));
                        break;
                    case 3:
                        Console.WriteLine("La multiplicación es: " + Multiplicar(numero1, numero2));
                        break;
                    case 4:
                        Console.WriteLine("La división es: " + Dividir(numero1, numero2));
                        break;
                }
            } while (menuOperacionAritmetica != 0);


            float Suma(float numero1, float numero2)
            {
                return numero1 + numero2;
            }
            float Resta(float numero1, float numero2)
            {
                return numero1 - numero2;
            }
            float Multiplicar(float numero1, float numero2)
            {
                return numero1 * numero2;
            }
            float Dividir(float numero1, float numero2)
            {
                return numero1 / numero2;
            }
        }
    }
}