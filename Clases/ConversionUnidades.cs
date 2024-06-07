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

                 if (unidadMedidaActual < 1 || unidadMedidaActual > 17)
                 {
                     Console.WriteLine("Opción no válida");
                     RepetirMenuConversionUnidades();
                     continue;
                 }

                 Console.WriteLine("Ingrese la unidad de medida a la que desea convertir:");
                 int unidadMedidaConvertir = int.Parse(Console.ReadLine());

                 if (unidadMedidaConvertir < 1 || unidadMedidaConvertir > 17)
                 {
                     Console.WriteLine("Opción no válida");
                     RepetirMenuConversionUnidades();
                     continue;
                 }

                 RevisionConversionUnidades(unidadMedidaActual, unidadMedidaConvertir);
                 RepetirMenuConversionUnidades();
             }
         }

         public static void RevisionConversionUnidades(int unidadMedidaActual, int unidadMedidaConvertir)
         {
             if (unidadMedidaActual >= 1 && unidadMedidaActual <= 4 && unidadMedidaConvertir >= 1 && unidadMedidaConvertir <= 4)
             {
                 Console.WriteLine("Ingrese el valor a convertir:");
                 float valorConvertir = float.Parse(Console.ReadLine());
                 ConvertirEntreUnidadesLongitud(valorConvertir, unidadMedidaActual, unidadMedidaConvertir);
             }
             else if (unidadMedidaActual >= 5 && unidadMedidaActual <= 9 && unidadMedidaConvertir >= 5 && unidadMedidaConvertir <= 9)
             {
                 Console.WriteLine("Ingrese el valor a convertir:");
                 float valorConvertir = float.Parse(Console.ReadLine());
                 ConvertirEntreUnidadesMasa(valorConvertir, unidadMedidaActual, unidadMedidaConvertir);
             }
             else if (unidadMedidaActual >= 10 && unidadMedidaActual <= 13 && unidadMedidaConvertir >= 10 && unidadMedidaConvertir <= 13)
             {
                 Console.WriteLine("Ingrese el valor a convertir:");
                 float valorConvertir = float.Parse(Console.ReadLine());
                 ConvertirEntreUnidadesTiempo(valorConvertir, unidadMedidaActual, unidadMedidaConvertir);
             }
             else if (unidadMedidaActual >= 14 && unidadMedidaActual <= 17 && unidadMedidaConvertir >= 14 && unidadMedidaConvertir <= 17)
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
         public static void ConvertirEntreUnidadesLongitud(float valorConvertir, int unidadMedidaActual, int unidadMedidaConvertir)
         {
            float resultado = 0;
            resultado = unidadMedidaActual == 1 ? ConvertirMilimetros(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 2 ? ConvertirCentimetros(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 3 ? ConvertirMetros(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 4 ? ConvertirKilometros(valorConvertir, unidadMedidaConvertir) :
                        0;
            Console.WriteLine($"El valor {valorConvertir} en {ObtenerNombreUnidadMedida(unidadMedidaActual)} es igual a {resultado} en {ObtenerNombreUnidadMedida(unidadMedidaConvertir)}");
            Console.WriteLine($"El valor {valorConvertir} en {ObtenerNombreUnidadMedida(unidadMedidaActual)} es igual a {resultado} en {ObtenerNombreUnidadMedida(unidadMedidaConvertir)}");
         }
         public static void ConvertirEntreUnidadesMasa(float valorConvertir, int unidadMedidaActual, int unidadMedidaConvertir)
         {
             float resultado = 0;
            resultado = unidadMedidaActual == 5 ? ConvertirGramos(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 6 ? ConvertirKilogramos(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 7 ? ConvertirToneladas(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 8 ? ConvertirLibras(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 9 ? ConvertirOnzas(valorConvertir, unidadMedidaConvertir) :
                            0;
             Console.WriteLine($"El valor {valorConvertir} en {ObtenerNombreUnidadMedida(unidadMedidaActual)} es igual a {resultado} en {ObtenerNombreUnidadMedida(unidadMedidaConvertir)}");
         }
         public static void ConvertirEntreUnidadesTiempo(float valorConvertir, int unidadMedidaActual, int unidadMedidaConvertir)
         {
             float resultado = 0;
            resultado = unidadMedidaActual == 10 ? ConvertirSegundos(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 11 ? ConvertirMinutos(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 12 ? ConvertirHoras(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 13 ? ConvertirDias(valorConvertir, unidadMedidaConvertir) :
                            0;
             Console.WriteLine($"El valor {valorConvertir} en {ObtenerNombreUnidadMedida(unidadMedidaActual)} es igual a {resultado} en {ObtenerNombreUnidadMedida(unidadMedidaConvertir)}");
         }
         public static void ConvertirEntreUnidadesVolumen(float valorConvertir, int unidadMedidaActual, int unidadMedidaConvertir)
         {
             float resultado = 0;
            resultado = unidadMedidaActual == 14 ? ConvertirMililitros(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 15 ? ConvertirCentimetrosCubicos(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 16 ? ConvertirLitros(valorConvertir, unidadMedidaConvertir) :
                        unidadMedidaActual == 17 ? ConvertirMetrosCubicos(valorConvertir, unidadMedidaConvertir) :
                            0;
             Console.WriteLine($"El valor {valorConvertir} en {ObtenerNombreUnidadMedida(unidadMedidaActual)} es igual a {resultado} en {ObtenerNombreUnidadMedida(unidadMedidaConvertir)}");
         }
         public static float ConvertirMilimetros(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 1 ? valorConvertir :
                   unidadMedidaConvertir == 2 ? valorConvertir / 10 :
                   unidadMedidaConvertir == 3 ? valorConvertir / 1000 :
                   unidadMedidaConvertir == 4 ? valorConvertir / 1000000 :
                   0;
        }
        public static float ConvertirCentimetros(float valorConvertir, int unidadMedidaConvertir)
        { 
            return unidadMedidaConvertir == 1 ? valorConvertir * 10 :
                   unidadMedidaConvertir == 2 ? valorConvertir :
                   unidadMedidaConvertir == 3 ? valorConvertir / 100 :
                   unidadMedidaConvertir == 4 ? valorConvertir / 100000 :
                   0;
        }
        public static float ConvertirMetros(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 1 ? valorConvertir * 1000 :
                   unidadMedidaConvertir == 2 ? valorConvertir * 100 :
                   unidadMedidaConvertir == 3 ? valorConvertir :
                   unidadMedidaConvertir == 4 ? valorConvertir / 1000 :
                   0;
        }
        public static float ConvertirKilometros(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 1 ? valorConvertir * 1000000 :
                   unidadMedidaConvertir == 2 ? valorConvertir * 100000 :
                   unidadMedidaConvertir == 3 ? valorConvertir * 1000 :
                   unidadMedidaConvertir == 4 ? valorConvertir :
                   0;
        }
        public static float ConvertirGramos(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 5 ? valorConvertir :
                   unidadMedidaConvertir == 6 ? valorConvertir / 1000 :
                   unidadMedidaConvertir == 7 ? valorConvertir / 1000000 :
                   unidadMedidaConvertir == 8 ? valorConvertir / 454 :
                   unidadMedidaConvertir == 9 ? valorConvertir / 28350 :
                   0;
        }
        public static float ConvertirKilogramos(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 5 ? valorConvertir * 1000 :
                   unidadMedidaConvertir == 6 ? valorConvertir :
                   unidadMedidaConvertir == 7 ? valorConvertir / 1000 :
                   unidadMedidaConvertir == 8 ? valorConvertir / 0.454f :
                   unidadMedidaConvertir == 9 ? valorConvertir / 0.02835f :
                   0;
        }
        public static float ConvertirToneladas(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 5 ? valorConvertir * 1000000 :
                   unidadMedidaConvertir == 6 ? valorConvertir * 1000 :
                   unidadMedidaConvertir == 7 ? valorConvertir :
                   unidadMedidaConvertir == 8 ? valorConvertir / 0.000454f :
                   unidadMedidaConvertir == 9 ? valorConvertir / 0.00002835f :
                   0;
        }
        public static float ConvertirLibras(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 5 ? valorConvertir * 454 :
                   unidadMedidaConvertir == 6 ? valorConvertir * 0.454f :
                   unidadMedidaConvertir == 7 ? valorConvertir * 0.000454f :
                   unidadMedidaConvertir == 8 ? valorConvertir :
                   unidadMedidaConvertir == 9 ? valorConvertir / 16 :
                   0;
        }
        public static float ConvertirOnzas(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 5 ? valorConvertir * 28350 :
                   unidadMedidaConvertir == 6 ? valorConvertir * 28.35f :
                   unidadMedidaConvertir == 7 ? valorConvertir * 0.02835f :
                   unidadMedidaConvertir == 8 ? valorConvertir * 16 :
                   unidadMedidaConvertir == 9 ? valorConvertir :
                   0;
        }
        public static float ConvertirSegundos(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 10 ? valorConvertir :
                   unidadMedidaConvertir == 11 ? valorConvertir / 60 :
                   unidadMedidaConvertir == 12 ? valorConvertir / 3600 :
                   unidadMedidaConvertir == 13 ? valorConvertir / 86400 :
                   0;
        }
        public static float ConvertirMinutos(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 10 ? valorConvertir * 60 :
                   unidadMedidaConvertir == 11 ? valorConvertir :
                   unidadMedidaConvertir == 12 ? valorConvertir / 60 :
                   unidadMedidaConvertir == 13 ? valorConvertir / 1440 :
                   0;
        }
        public static float ConvertirHoras(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 10 ? valorConvertir * 3600 :
                   unidadMedidaConvertir == 11 ? valorConvertir * 60 :
                   unidadMedidaConvertir == 12 ? valorConvertir :
                   unidadMedidaConvertir == 13 ? valorConvertir / 24 :
                   0;
        }
        public static float ConvertirDias(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 10 ? valorConvertir * 86400 :
                   unidadMedidaConvertir == 11 ? valorConvertir * 1440 :
                   unidadMedidaConvertir == 12 ? valorConvertir * 24 :
                   unidadMedidaConvertir == 13 ? valorConvertir :
                   0;
        }
        public static float ConvertirMililitros(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 14 ? valorConvertir :
                   unidadMedidaConvertir == 15 ? valorConvertir / 1 :
                   unidadMedidaConvertir == 16 ? valorConvertir / 1000 :
                   unidadMedidaConvertir == 17 ? valorConvertir / 1000000 :
                   0;
        }
        public static float ConvertirCentimetrosCubicos(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 14 ? valorConvertir * 1 :
                   unidadMedidaConvertir == 15 ? valorConvertir :
                   unidadMedidaConvertir == 16 ? valorConvertir / 1000 :
                   unidadMedidaConvertir == 17 ? valorConvertir / 1000000 :
                   0;
        }
        public static float ConvertirLitros(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 14 ? valorConvertir * 1000 :
                   unidadMedidaConvertir == 15 ? valorConvertir * 1000 :
                   unidadMedidaConvertir == 16 ? valorConvertir :
                   unidadMedidaConvertir == 17 ? valorConvertir / 1000 :
                   0;
        }
        public static float ConvertirMetrosCubicos(float valorConvertir, int unidadMedidaConvertir)
        {
            return unidadMedidaConvertir == 14 ? valorConvertir * 1000000 :
                   unidadMedidaConvertir == 15 ? valorConvertir * 1000000 :
                   unidadMedidaConvertir == 16 ? valorConvertir * 1000 :
                   unidadMedidaConvertir == 17 ? valorConvertir :
                   0;
        }
        public static string ObtenerNombreUnidadMedida(int unidadMedida)
        {
        return unidadMedida==1?"milímetros":
                unidadMedida==2?"centímetros":
                unidadMedida==3?"metros":
                unidadMedida==4?"kilómetros":
                unidadMedida==5?"gramos":
                unidadMedida==6?"kilogramos":
                unidadMedida==7?"toneladas":
                unidadMedida==8?"libras":
                unidadMedida==9?"onzas":
                unidadMedida==10?"segundos":
                unidadMedida==11?"minutos":
                unidadMedida==12?"horas":
                unidadMedida==13?"días":
                unidadMedida==14?"mililitros":
                unidadMedida==15?"centímetros cúbicos":
                unidadMedida==16?"litros":
                unidadMedida==17?"metros cúbicos":
                                "";
        }
        public static void RepetirMenuConversionUnidades()
        {
            Console.WriteLine("¿Desea realizar otra conversión de unidades? (s/n)");            
            repetirConversion = Console.ReadLine().ToLower() == "s" ? true:false;            
        }
    }
}