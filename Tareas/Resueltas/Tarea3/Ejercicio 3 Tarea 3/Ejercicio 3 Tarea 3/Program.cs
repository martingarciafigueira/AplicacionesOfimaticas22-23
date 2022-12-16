string numeroString;
int numero, contador = 0;

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Escribe \" STOP \" en cualquier momento para cerrar el programa.\n");
Console.ForegroundColor = ConsoleColor.White;

while (true)
{
    Console.Write("Introduce un número: ");
    numeroString = Console.ReadLine();

    if (numeroString == "STOP")
    {
        break;
    }

    if (int.TryParse(numeroString, out numero))
    {
        numero = int.Parse(numeroString);
    }

    if (numero <= 0)
    {
        Console.Clear();
    }

    if (numero > 0)
    {
        for (int x = 1; x < numero + 1; x++)
        {
            if ((numero % x) == 0)
            {
                contador++;
            }
        }

        if (contador != 2)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nEl número " + numero + " no es primo!\n");
            Console.ForegroundColor = ConsoleColor.White;

            contador = 0;
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nEl número " + numero + " es primo!\n");
            Console.ForegroundColor = ConsoleColor.White;

            contador = 0;
        }
    }  
}