
int[] valores = new int[100];
Random aleatorio = new Random();

//Guardamos valores entre 0 y 10 en el array
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = aleatorio.Next(0, 10 + 1);
}

//Mostramos cada uno de los valores
foreach (int valor in valores)
{
    Console.Write(valor + ", ");
}

Console.ReadLine();