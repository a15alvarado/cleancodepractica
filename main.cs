using cleancode;

Console.WriteLine("\tELija que desea utilizar:");
Console.WriteLine("1) Calculadora\t\t\t2) Tablas de multiplicar\t\t3) Suma de números pares e impares" +
                "\n4) Fibonacci\t\t\t5) Contador de vocales y consonantes\t6) Conversión de unidades" +
                "\n7) Ordenar lista de números\t8) Validación de contraseñas");

int numeroOpcionMenu = int.Parse(Console.ReadLine());
switch (numeroOpcionMenu)
{
    case 1:
        CalculadoraSimple.ObtenerCalculosAritmeticos();
        break;
    case 2:
        TablasMultiplicar.GenerarTablasMultiplicar();
        break;
    case 3:
        SumaNumeroParImpar.RevisarListaNumeroParImpar();
        break;
    case 4:
        Fibonacci.ObtenerSecuenciaFibonacci();
        break;
    case 5:
        ContadorVocalesConsonantes.main();
        break;
    case 6:
        ConversionUnidades.main();
        break;
    case 7:
        OrdenarListaNumeros.main();
        break;
    case 8:
        ValidacionContrasena.main();
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}

