﻿Random rnd = new Random();
int[] valores = new int[100];
int[] valores2 = new int[100];
bool sonIguales = true;

//Rellenamos el array con los numeros
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rnd.Next(0, 11);
}

Array.Copy(valores, valores2, valores.Length);

for (int i = 0; i < valores.Length; i++)
{
    if (valores[i] != valores2[i])
    {
        sonIguales = false;
        break;
    }
}

if (sonIguales)
{
    Console.WriteLine("Los arrays son iguales");
}
else
{
    Console.WriteLine("Los arrays no son iguales");
}
Console.ReadLine();