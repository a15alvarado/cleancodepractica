using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Clases
{
    internal class ConversionUnidades
    {
        public static bool repetirConversion = true;
        public static void CalcularUnidadMedida()
        {
            while (repetirConversion)
            {
                Console.WriteLine("Seleccione la categoría de la unidad de conversión:");
                Console.WriteLine("1) Longitud\n2) Masa\n3) Tiempo\n4) Volumen");
                int categoria = int.Parse(Console.ReadLine());

                string[] unidades = ObtenerUnidades(categoria);

                Console.WriteLine("Seleccione la unidad de origen:");
                for (int i = 0; i < unidades.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) {unidades[i]}");
                }
                int unidadOrigenIndex = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("Seleccione la unidad de destino:");
                for (int i = 0; i < unidades.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) {unidades[i]}");
                }
                int unidadDestinoIndex = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("Ingrese el valor a convertir:");
                double valor = double.Parse(Console.ReadLine());

                string conversion = $"{unidades[unidadOrigenIndex]} a {unidades[unidadDestinoIndex]}";

                try
                {
                    double resultado = Conversiones.Convertir(conversion, valor);
                    Console.WriteLine($"El resultado de la conversión es: {resultado}\n");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                RepetirMenuConversionUnidades();
            }
        }

        static string[] ObtenerUnidades(int categoria)
        {
            switch (categoria)
            {
                case 1:
                    return new string[] { "Milímetros", "Centímetros", "Metros", "Kilómetros" };
                case 2:
                    return new string[] { "Gramos", "Kilogramos", "Toneladas", "Libras", "Onzas" };
                case 3:
                    return new string[] { "Segundos", "Minutos", "Horas", "Días" };
                case 4:
                    return new string[] { "Mililitros", "Centímetros cúbicos", "Litros", "Metros cúbicos" };
                default:
                    return new string[0];
            }
        }

        public static void RepetirMenuConversionUnidades()
        {
            Console.WriteLine("¿Desea realizar otra conversión de unidades? (s/n)");            
            repetirConversion = Console.ReadLine().ToLower() == "s" ? true:false;            
        }
    }

    public static class Conversiones
    {
        private static readonly Dictionary<string, Func<double, double>> conversionesLongitud = new Dictionary<string, Func<double, double>>
    {
        {"Milímetros a Centímetros", valor => valor / 10.0},
        {"Milímetros a Metros", valor => valor / 1000.0},
        {"Milímetros a Kilómetros", valor => valor / 1_000_000.0},
        {"Centímetros a Milímetros", valor => valor * 10.0},
        {"Centímetros a Metros", valor => valor / 100.0},
        {"Centímetros a Kilómetros", valor => valor / 100_000.0},
        {"Metros a Milímetros", valor => valor * 1000.0},
        {"Metros a Centímetros", valor => valor * 100.0},
        {"Metros a Kilómetros", valor => valor / 1000.0},
        {"Kilómetros a Milímetros", valor => valor * 1_000_000.0},
        {"Kilómetros a Centímetros", valor => valor * 100_000.0},
        {"Kilómetros a Metros", valor => valor * 1000.0}
    };

        private static readonly Dictionary<string, Func<double, double>> conversionesMasa = new Dictionary<string, Func<double, double>>
    {
        {"Gramos a Kilogramos", valor => valor / 1000.0},
        {"Gramos a Toneladas", valor => valor / 1_000_000.0},
        {"Gramos a Libras", valor => valor * 0.00220462},
        {"Gramos a Onzas", valor => valor * 0.035274},
        {"Kilogramos a Gramos", valor => valor * 1000.0},
        {"Kilogramos a Toneladas", valor => valor / 1000.0},
        {"Kilogramos a Libras", valor => valor * 2.20462},
        {"Kilogramos a Onzas", valor => valor * 35.274},
        {"Toneladas a Gramos", valor => valor * 1_000_000.0},
        {"Toneladas a Kilogramos", valor => valor * 1000.0},
        {"Toneladas a Libras", valor => valor * 2204.62},
        {"Toneladas a Onzas", valor => valor * 35274},
        {"Libras a Gramos", valor => valor * 453.592},
        {"Libras a Kilogramos", valor => valor * 0.453592},
        {"Libras a Toneladas", valor => valor * 0.000453592},
        {"Libras a Onzas", valor => valor * 16.0},
        {"Onzas a Gramos", valor => valor * 28.3495},
        {"Onzas a Kilogramos", valor => valor * 0.0283495},
        {"Onzas a Toneladas", valor => valor * 0.0000283495},
        {"Onzas a Libras", valor => valor * 0.0625}
    };

        private static readonly Dictionary<string, Func<double, double>> conversionesTiempo = new Dictionary<string, Func<double, double>>
    {
        {"Segundos a Minutos", valor => valor / 60.0},
        {"Segundos a Horas", valor => valor / 3600.0},
        {"Segundos a Días", valor => valor / 86_400.0},
        {"Minutos a Segundos", valor => valor * 60.0},
        {"Minutos a Horas", valor => valor / 60.0},
        {"Minutos a Días", valor => valor / 1_440.0},
        {"Horas a Segundos", valor => valor * 3600.0},
        {"Horas a Minutos", valor => valor * 60.0},
        {"Horas a Días", valor => valor / 24.0},
        {"Días a Segundos", valor => valor * 86_400.0},
        {"Días a Minutos", valor => valor * 1_440.0},
        {"Días a Horas", valor => valor * 24.0}
    };

        private static readonly Dictionary<string, Func<double, double>> conversionesVolumen = new Dictionary<string, Func<double, double>>
    {
        {"Mililitros a Centímetros cúbicos", valor => valor},
        {"Mililitros a Litros", valor => valor / 1000.0},
        {"Mililitros a Metros cúbicos", valor => valor / 1_000_000.0},
        {"Centímetros cúbicos a Mililitros", valor => valor},
        {"Centímetros cúbicos a Litros", valor => valor / 1000.0},
        {"Centímetros cúbicos a Metros cúbicos", valor => valor / 1_000_000.0},
        {"Litros a Mililitros", valor => valor * 1000.0},
        {"Litros a Centímetros cúbicos", valor => valor * 1000.0},
        {"Litros a Metros cúbicos", valor => valor / 1000.0},
        {"Metros cúbicos a Mililitros", valor => valor * 1_000_000.0},
        {"Metros cúbicos a Centímetros cúbicos", valor => valor * 1_000_000.0},
        {"Metros cúbicos a Litros", valor => valor * 1000.0}
    };

        public static double Convertir(string conversion, double valor)
        {
            if (conversionesLongitud.TryGetValue(conversion, out var funcionLongitud))
                return funcionLongitud(valor);
            if (conversionesMasa.TryGetValue(conversion, out var funcionMasa))
                return funcionMasa(valor);
            if (conversionesTiempo.TryGetValue(conversion, out var funcionTiempo))
                return funcionTiempo(valor);
            if (conversionesVolumen.TryGetValue(conversion, out var funcionVolumen))
                return funcionVolumen(valor);

            throw new ArgumentException("Conversión no soportada.");
        }
    }

}