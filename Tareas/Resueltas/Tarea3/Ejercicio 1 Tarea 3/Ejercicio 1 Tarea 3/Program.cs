using System.Linq;

Random random = new Random();
int[,] randomInts = new int[10, 10];
int[] masrepeArray = new int[11];

int cantidadNegativos = 0, cantidadPositivos = 0, cantidadRango = 0, cantidadCeros = 0;
int numeroRepe = 0, max = 0, cantidad1 = 0, cantidad2 = 0, cantidad3 = 0, cantidad4 = 0, cantidad5 = 0, 

    cantidadm1 = 0, cantidadm2 = 0, cantidadm3 = 0, cantidadm4 = 0, cantidadm5 = 0;

int contadorLineas = 1, contadorPorcentaje = 0;


for (int x = 0; x < randomInts.GetLength(0); x++)
{

    for (int i = 0; i < randomInts.GetLength(1); i++)
    {
        randomInts[x, i] = random.Next(-5, 6);
    }
}

for (int x = 0; x < randomInts.GetLength(0); x++)
{
    for (int i = 0; i < randomInts.GetLength(1); i++)
    {
        Console.Write(randomInts[x, i] + ", ");
    }

    Console.WriteLine();
}

Console.WriteLine("\n----------------------------------------------|");
Console.WriteLine("\nSegunda parte del ejercicio: \n");

for (int x = 0; x < randomInts.GetLength(0); x++)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nFila " + contadorLineas + ": \n");
    Console.ForegroundColor = ConsoleColor.White;

    for (int i = 0; i < randomInts.GetLength(1); i++)
    {
        Console.Write(randomInts[x, i] + ", ");
    
        if (randomInts[x, i] < 0)
        {
            cantidadNegativos++;
        }

        else if (randomInts[x, i] > 0)
        {
            cantidadPositivos++;
        }

        else
        {
            cantidadCeros++;
        }

        if (randomInts[x, i] >= -3 && randomInts[x, i] <= 3)
        {
            cantidadRango++;
        }

        //Más Repetido.

        if (randomInts[x, i] == 1)
        {
            cantidad1++;
        }

        else if (randomInts[x, i] == 2)
        {
            cantidad2++;
        }

        else if (randomInts[x, i] == 3)
        {
            cantidad3++;
        }

        else if (randomInts[x, i] == 4)
        {
            cantidad4++;
        }

        else if (randomInts[x, i] == 5)
        {
            cantidad5++;
        }

        else if (randomInts[x, i] == -1)
        {
            cantidadm1++;
        }

        else if (randomInts[x, i] == -2)
        {
            cantidadm2++;
        }

        else if (randomInts[x, i] == -3)
        {
            cantidadm3++;
        }

        else if (randomInts[x, i] == -4)
        {
            cantidadm4++;
        }

        else if (randomInts[x, i] == -5)
        {
            cantidadm5++;
        }

        masrepeArray[0] = cantidadCeros;
        masrepeArray[1] = cantidad1;
        masrepeArray[2] = cantidad2;
        masrepeArray[3] = cantidad3;
        masrepeArray[4] = cantidad4;
        masrepeArray[5] = cantidad5;
        masrepeArray[6] = cantidadm1;
        masrepeArray[7] = cantidadm2;
        masrepeArray[8] = cantidadm3;
        masrepeArray[9] = cantidadm4;
        masrepeArray[10] = cantidadm5;

        max = masrepeArray.Max();
        numeroRepe = masrepeArray.ToList().IndexOf(max);

        if (numeroRepe == 10)
        {
            numeroRepe = -5;
        }

        else if (numeroRepe == 9)
        {
            numeroRepe = -4;
        }

        else if (numeroRepe == 8)
        {
            numeroRepe = -3;
        }

        else if (numeroRepe == 7)
        {
            numeroRepe = -2;
        }

        else if (numeroRepe == 6)
        {
            numeroRepe = -1;
        }

        else
        {
            numeroRepe = masrepeArray.ToList().IndexOf(max);
        }

        //Fin número más repetido. (Si hay más de un número repetido las mismas veces muestra el que le apetece :D)

        contadorPorcentaje++;
    }

    Console.WriteLine();
    
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\nEl total de números negativos es: " + cantidadNegativos);
    Console.WriteLine("\nEl total de números positivos es: " + cantidadPositivos);
    Console.WriteLine("\nEl total de números neutros ( 0 ) es: " + cantidadCeros);
    Console.WriteLine("\nEl porcentaje de números entre el -3 y el 3 es del: " + cantidadRango * (100 / contadorPorcentaje) + "%");
    Console.WriteLine("\nEl valor más repetido es: " + numeroRepe);
    Console.ForegroundColor = ConsoleColor.White;

    cantidadNegativos = 0;
    cantidadPositivos = 0;
    cantidadCeros = 0;
    cantidadRango = 0;
    contadorPorcentaje = 0;

    cantidad1 = 0;
    cantidad2 = 0;
    cantidad3 = 0;
    cantidad4 = 0;
    cantidad5 = 0;
    cantidadm1 = 0;
    cantidadm2 = 0;
    cantidadm3 = 0;
    cantidadm4 = 0;
    cantidadm5 = 0;

    contadorLineas++;

    Console.WriteLine();
}

Console.ReadKey();