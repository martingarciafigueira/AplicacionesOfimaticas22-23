int i = 2, numero;
bool esPrimo = true;

Console.WriteLine("Mete un número");
numero = int.Parse(Console.ReadLine());

//Saber si un número es par o impar
if (numero % 2 == 0)
{
    Console.WriteLine("Numero par");
}
else
{
    Console.WriteLine("Numero impar");
}

//Saber si un número es primo
while (i < numero)
{
    Console.WriteLine("Ejecución " + i);
    if (numero % i == 0)
    {
        esPrimo = false;        
        break;
    }
    i++;
}

if (esPrimo == true)
{
    Console.WriteLine("Número primo");
}
else
{
    Console.WriteLine("Número no primo");
}

Console.ReadLine();