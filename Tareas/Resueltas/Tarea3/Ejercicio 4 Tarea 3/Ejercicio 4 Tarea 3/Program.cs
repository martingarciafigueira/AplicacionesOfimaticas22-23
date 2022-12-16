int factor1 = 10, factor2 = 10;

for (int x = 1; x <= factor1; x++)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("La tabla del " + x + " es: \n");
    Console.ForegroundColor = ConsoleColor.White;

    for (int i = 1; i <= factor2; i++)
	{
		Console.WriteLine(x + " * " + i + " = " + (x * i));
	}

    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Pulsa cualquier tecla para salir del programa ");
Console.ReadKey();