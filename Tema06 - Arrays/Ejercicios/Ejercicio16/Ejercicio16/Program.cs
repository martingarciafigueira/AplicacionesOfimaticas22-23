﻿Random rnd = new Random();
int[] valores = new int[100];
int contador = 0;

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rnd.Next(-10, 11);
}

for (int i = 0; i < valores.Length; i++)
{
    Console.Write(valores[i] + ", ");
    if (valores[i] < 0)
    {
        contador++;
    }
}
Console.WriteLine();
Console.WriteLine("Tenemos {0} valores negativos", contador);

Console.ReadLine();