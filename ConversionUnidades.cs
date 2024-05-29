using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode
{
    internal class ConversionUnidades
    {
        public static void CalcularUnidadMedida()
        {
            bool repetirConversion = true;
            while (repetirConversion)
            {
                Console.WriteLine("\tConversion de unidades");
                Console.WriteLine("\n\tUnidades de longitud:");
                Console.WriteLine("1) Milímetros\t2) Centímetros\n3) Metros\t4) Kilómetros");
                Console.WriteLine("\n\tUnidades de masa:");
                Console.WriteLine("5) Gramos\t6) Kilogramos\n7) Toneladas\t8) Libras\n9) Onzas");
                Console.WriteLine("\n\tUnidades de tiempo:");
                Console.WriteLine("10) Segundos\t11) Minutos\n12) Horas\t13) Días");
                Console.WriteLine("\n\tUnidades de volumen:");
                Console.WriteLine("14) Mililitros\t15) Centímetros cúbicos\n16) Litros\t17) Metros cúbicos");
                Console.WriteLine("\nIngrese la unidad de medida actual:");
                int unidadMedidaActual = int.Parse(Console.ReadLine());
                if(unidadMedidaActual < 1 || unidadMedidaActual > 17)
                {
                    Console.WriteLine("Opción no válida");
                    RepetirMenuConversionUnidades(repetirConversion);
                    continue;
                }
                Console.WriteLine("Ingrese la unidad de medida a la que desea convertir:");
                int unidadMedidaConvertir = int.Parse(Console.ReadLine());
                if (unidadMedidaConvertir < 1 || unidadMedidaConvertir > 17)
                {
                    Console.WriteLine("Opción no válida");
                    RepetirMenuConversionUnidades(repetirConversion);
                    continue;
                }
                
                RevisionConversionUnidades(unidadMedidaActual, unidadMedidaConvertir);
                RepetirMenuConversionUnidades(repetirConversion);
                
            }

        }
        
        public static void RevisionConversionUnidades(int unidadMedidaActual, int unidadMedidaConvertir)
        {
            if ((unidadMedidaActual >= 1 && unidadMedidaActual <= 4) && (unidadMedidaConvertir >= 1 && unidadMedidaConvertir <= 4))
            {
                Console.WriteLine("Ingrese el valor a convertir:");
                float valorConvertir = float.Parse(Console.ReadLine());
                ConvertirEntreUnidadesLongitud(valorConvertir, unidadMedidaActual, unidadMedidaConvertir);
            }
            else if ((unidadMedidaActual >= 5 && unidadMedidaActual <= 9) && (unidadMedidaConvertir >= 5 && unidadMedidaConvertir <= 9))
            {
                Console.WriteLine("Ingrese el valor a convertir:");
                float valorConvertir = float.Parse(Console.ReadLine());
                ConvertirEntreUnidadesMasa(valorConvertir, unidadMedidaActual, unidadMedidaConvertir);
            }
            else if ((unidadMedidaActual >= 10 && unidadMedidaActual <= 13) && (unidadMedidaConvertir >= 10 && unidadMedidaConvertir <= 13))
            {
                Console.WriteLine("Ingrese el valor a convertir:");
                float valorConvertir = float.Parse(Console.ReadLine());
                ConvertirEntreUnidadesTiempo(valorConvertir, unidadMedidaActual, unidadMedidaConvertir);
            }
            else if ((unidadMedidaActual >= 14 && unidadMedidaActual <= 17) && (unidadMedidaConvertir >= 14 && unidadMedidaConvertir <= 17))
            {
                Console.WriteLine("Ingrese el valor a convertir:");
                float valorConvertir = float.Parse(Console.ReadLine());
                ConvertirEntreUnidadesVolumen(valorConvertir, unidadMedidaActual, unidadMedidaConvertir);
            }
            else
            {
                Console.WriteLine("Unidades no compatibles");
            }        
            
        }
        public static void ConvertirEntreUnidadesLongitud(float valorConvertir,int unidadMedidaActual, int unidadMedidaConvertir)
        {
            float resultado = 0;
            switch (unidadMedidaActual)
            {
                case 1:
                    resultado = ConvertirMilimetros(valorConvertir, unidadMedidaConvertir);
                    break;
                case 2:
                    resultado = ConvertirCentimetros(valorConvertir, unidadMedidaConvertir);
                    break;
                case 3:
                    resultado = ConvertirMetros(valorConvertir, unidadMedidaConvertir);
                    break;
                case 4:
                    resultado = ConvertirKilometros(valorConvertir, unidadMedidaConvertir);
                    break;
            }
            Console.WriteLine($"El valor {valorConvertir} en {ObtenerNombreUnidadMedida(unidadMedidaActual)} es igual a {resultado} en {ObtenerNombreUnidadMedida(unidadMedidaConvertir)}");
        }
        public static void ConvertirEntreUnidadesMasa(float valorConvertir, int unidadMedidaActual, int unidadMedidaConvertir)
        {
            float resultado = 0;
            switch (unidadMedidaActual)
            {
                case 5:
                    resultado = ConvertirGramos(valorConvertir, unidadMedidaConvertir);
                    break;
                case 6:
                    resultado = ConvertirKilogramos(valorConvertir, unidadMedidaConvertir);
                    break;
                case 7:
                    resultado = ConvertirToneladas(valorConvertir, unidadMedidaConvertir);
                    break;
                case 8:
                    resultado = ConvertirLibras(valorConvertir, unidadMedidaConvertir);
                    break;
                case 9:
                    resultado = ConvertirOnzas(valorConvertir, unidadMedidaConvertir);
                    break;
            }
            Console.WriteLine($"El valor {valorConvertir} en {ObtenerNombreUnidadMedida(unidadMedidaActual)} es igual a {resultado} en {ObtenerNombreUnidadMedida(unidadMedidaConvertir)}");
        }
        public static void ConvertirEntreUnidadesTiempo(float valorConvertir, int unidadMedidaActual, int unidadMedidaConvertir)
        {
            float resultado = 0;
            switch (unidadMedidaActual)
            {
                case 10:
                    resultado = ConvertirSegundos(valorConvertir, unidadMedidaConvertir);
                    break;
                case 11:
                    resultado = ConvertirMinutos(valorConvertir, unidadMedidaConvertir);
                    break;
                case 12:
                    resultado = ConvertirHoras(valorConvertir, unidadMedidaConvertir);
                    break;
                case 13:
                    resultado = ConvertirDias(valorConvertir, unidadMedidaConvertir);
                    break;
            }
            Console.WriteLine($"El valor {valorConvertir} en {ObtenerNombreUnidadMedida(unidadMedidaActual)} es igual a {resultado} en {ObtenerNombreUnidadMedida(unidadMedidaConvertir)}");
        }
        public static void ConvertirEntreUnidadesVolumen(float valorConvertir, int unidadMedidaActual, int unidadMedidaConvertir)
        {
            float resultado = 0;
            switch (unidadMedidaActual)
            {
                case 14:
                    resultado = ConvertirMililitros(valorConvertir, unidadMedidaConvertir);
                    break;
                case 15:
                    resultado = ConvertirCentimetrosCubicos(valorConvertir, unidadMedidaConvertir);
                    break;
                case 16:
                    resultado = ConvertirLitros(valorConvertir, unidadMedidaConvertir);
                    break;
                case 17:
                    resultado = ConvertirMetrosCubicos(valorConvertir, unidadMedidaConvertir);
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            Console.WriteLine($"El valor {valorConvertir} en {ObtenerNombreUnidadMedida(unidadMedidaActual)} es igual a {resultado} en {ObtenerNombreUnidadMedida(unidadMedidaConvertir)}");
        }
        public static float ConvertirMilimetros(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 1:
                    return valorConvertir;
                case 2:
                    return valorConvertir / 10;
                case 3:
                    return valorConvertir / 1000;
                case 4:
                    return valorConvertir / 1000000;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirCentimetros(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 1:
                    return valorConvertir * 10;
                case 2:
                    return valorConvertir;
                case 3:
                    return valorConvertir / 100;
                case 4:
                    return valorConvertir / 100000;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirMetros(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 1:
                    return valorConvertir * 1000;
                case 2:
                    return valorConvertir * 100;
                case 3:
                    return valorConvertir;
                case 4:
                    return valorConvertir / 1000;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirKilometros(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 1:
                    return valorConvertir * 1000000;
                case 2:
                    return valorConvertir * 100000;
                case 3:
                    return valorConvertir * 1000;
                case 4:
                    return valorConvertir;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirGramos(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 5:
                    return valorConvertir;
                case 6:
                    return valorConvertir / 1000;
                case 7:
                    return valorConvertir / 1000000;
                case 8:
                    return valorConvertir / 454;
                case 9:
                    return valorConvertir / 28350;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirKilogramos(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 5:
                    return valorConvertir * 1000;
                case 6:
                    return valorConvertir;
                case 7:
                    return valorConvertir / 1000;
                case 8:
                    return valorConvertir / 0.454f;
                case 9:
                    return valorConvertir / 0.02835f;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirToneladas(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 5:
                    return valorConvertir * 1000000;
                case 6:
                    return valorConvertir * 1000;
                case 7:
                    return valorConvertir;
                case 8:
                    return valorConvertir / 0.000454f;
                case 9:
                    return valorConvertir / 0.00002835f;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirLibras(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 5:
                    return valorConvertir * 454;
                case 6:
                    return valorConvertir * 0.454f;
                case 7:
                    return valorConvertir * 0.000454f;
                case 8:
                    return valorConvertir;
                case 9:
                    return valorConvertir / 16;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirOnzas(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 5:
                    return valorConvertir * 28350;
                case 6:
                    return valorConvertir * 0.02835f;
                case 7:
                    return valorConvertir * 0.00002835f;
                case 8:
                    return valorConvertir * 16;
                case 9:
                    return valorConvertir;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirSegundos(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 10:
                    return valorConvertir;
                case 11:
                    return valorConvertir / 60;
                case 12:
                    return valorConvertir / 3600;
                case 13:
                    return valorConvertir / 86400;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirMinutos(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 10:
                    return valorConvertir * 60;
                case 11:
                    return valorConvertir;
                case 12:
                    return valorConvertir / 60;
                case 13:
                    return valorConvertir / 1440;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirHoras(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 10:
                    return valorConvertir * 3600;
                case 11:
                    return valorConvertir * 60;
                case 12:
                    return valorConvertir;
                case 13:
                    return valorConvertir / 24;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirDias(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 10:
                    return valorConvertir * 86400;
                case 11:
                    return valorConvertir * 1440;
                case 12:
                    return valorConvertir * 24;
                case 13:
                    return valorConvertir;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirMililitros(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 14:
                    return valorConvertir;
                case 15:
                    return valorConvertir;
                case 16:
                    return valorConvertir / 1000;
                case 17:
                    return valorConvertir / 1000000;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirCentimetrosCubicos(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 14:
                    return valorConvertir;
                case 15:
                    return valorConvertir;
                case 16:
                    return valorConvertir / 1000;
                case 17:
                    return valorConvertir / 1000000;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirLitros(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 14:
                    return valorConvertir * 1000;
                case 15:
                    return valorConvertir * 1000;
                case 16:
                    return valorConvertir;
                case 17:
                    return valorConvertir / 1000;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static float ConvertirMetrosCubicos(float valorConvertir, int unidadMedidaConvertir)
        {
            switch (unidadMedidaConvertir)
            {
                case 14:
                    return valorConvertir * 1000000;
                case 15:
                    return valorConvertir * 1000000;
                case 16:
                    return valorConvertir * 1000;
                case 17:
                    return valorConvertir;
                default:
                    Console.WriteLine("Opción no válida");
                    return 0;
            }
        }
        public static string ObtenerNombreUnidadMedida(int unidadMedida)
        {
            switch (unidadMedida)
            {
                case 1:
                    return "milímetros";
                case 2:
                    return "centímetros";
                case 3:
                    return "metros";
                case 4:
                    return "kilómetros";
                case 5:
                    return "gramos";
                case 6:
                    return "kilogramos";
                case 7:
                    return "toneladas";
                case 8:
                    return "libras";
                case 9:
                    return "onzas";
                case 10:
                    return "segundos";
                case 11:
                    return "minutos";
                case 12:
                    return "horas";
                case 13:
                    return "días";
                case 14:
                    return "mililitros";
                case 15:
                    return "centímetros cúbicos";
                case 16:
                    return "litros";
                case 17:
                    return "metros cúbicos";
                default:
                    return "";
            }
        }

        public static void RepetirMenuConversionUnidades(bool repetirConversion)
        {
            Console.WriteLine("¿Desea realizar otra conversión de unidades? (s/n)");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() != "s")
            {
                repetirConversion = false;
            }
        }
    }
}
