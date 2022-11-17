//MOSTRAR LA TABLA DE LOS 15 PRIMEROS NUMEROS, PASÁNDOLE POR PANTALLA EL NÚMERO DE ELEMENTOS

int numeroElementos;
Console.Write("Introduce el número de elementos: ");
numeroElementos = int.Parse(Console.ReadLine());

//Mostrar los 15 primeros números
for (int i = 1; i <= 15; i++)
{
    //Hacer la tabla de un número
    for (int j = 1; j <= numeroElementos; j++)
    {
        Console.WriteLine(i + " x " + j + " = " + j * i);
    }
    Console.WriteLine();
}

Console.ReadLine();


