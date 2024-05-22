using cleancode;

Console.WriteLine("\tELija que desea utilizar:");
Console.WriteLine("1)Calculadora    2)Tablas de multiplicar");
int menuPrincipal = int.Parse(Console.ReadLine());
switch (menuPrincipal)
{
    case 1:
        Calculadora_simple.main();
        break;
    case 2:
        tablas_multiplicar.main();
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}

