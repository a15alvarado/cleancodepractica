using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Clases
{
    internal class TablasMultiplicar
    {
        public static void GenerarTablasMultiplicar()
        {
            Console.WriteLine("\tTablas de multiplicar");
            Console.WriteLine("Ingrese el número de la tabla a mostrar:");
            int numeroTabla = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el número hasta donde desea que se muestre la tabla:");
            int numeroLimite = int.Parse(Console.ReadLine());
            for (int multiplo = 1; multiplo <= numeroLimite; multiplo++)
            {
                Console.WriteLine(numeroTabla + " x " + multiplo + " = " + numeroTabla * multiplo);
            }

        }
    }
}
