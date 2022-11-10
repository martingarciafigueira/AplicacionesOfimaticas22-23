int num1, num2, num3, menor, mayor, intermedio = 0;

Console.Write("Introduzca el número 1: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Introduzca el número 2: ");
num2 = int.Parse(Console.ReadLine());
Console.Write("Introduzca el número 3: ");
num3 = int.Parse(Console.ReadLine());

menor = Math.Min(num1, Math.Min(num2, num3));
mayor = Math.Max(num1, Math.Max(num2, num3));

if (num1 > menor && num1 < mayor)
{
    intermedio = num1;
}
else if (num2 > menor && num2 < mayor)
{
    intermedio = num2;
}
else
{
    intermedio = num3;
}

Console.WriteLine("El orden es: {0},{1},{2}", menor, intermedio, mayor);

Console.ReadLine();
