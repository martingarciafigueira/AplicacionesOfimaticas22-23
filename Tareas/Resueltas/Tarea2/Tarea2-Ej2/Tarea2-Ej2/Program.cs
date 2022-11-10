int anho;

while (true)
{
    Console.Write("Por favor, introduzca un año:");
    anho = int.Parse(Console.ReadLine());
    if (anho % 4 == 0)
    {
        if (anho % 100 == 0)
        {
            if (anho % 400 == 0)
            {
                Console.WriteLine("Año bisiesto");
            }
            else
            {
                Console.WriteLine("Año no bisiesto");
            }
        }
        else
        {
            Console.WriteLine("Año bisiesto");
        }
    }
    else
    {
        Console.WriteLine("Año no bisiesto");
    }
}

Console.ReadLine();
