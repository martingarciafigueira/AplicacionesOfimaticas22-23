//Declaramos las variables
double num1, num2, num3, num4, num5, max, min, sumaFinal = 0;

//Pedimos los valores por pantalla
Console.Write("Introduce el número 1:");
num1 = double.Parse(Console.ReadLine());

Console.Write("Introduce el número 2:");
num2 = double.Parse(Console.ReadLine());

Console.Write("Introduce el número 3:");
num3 = double.Parse(Console.ReadLine());

Console.Write("Introduce el número 4:");
num4 = double.Parse(Console.ReadLine());

Console.Write("Introduce el número 5:");
num5 = double.Parse(Console.ReadLine());

//Calculamos el maximo y minimo
min = Math.Min(num1, num2);
min = Math.Min(min, num3);
min = Math.Min(min, num4);
min = Math.Min(min, num5);

max = Math.Max(num1, num2);
max = Math.Max(max, num3);
max = Math.Max(max, num4);
max = Math.Max(max, num5);

//Comprobamos las condiciones
if (max > 0)
{
    sumaFinal += Math.Sqrt(max);
}
else
{
    sumaFinal += max;
}

if (min < 0)
{
    sumaFinal += Math.Pow(min, min);
}
else
{
    sumaFinal += min;
}

//Muestra por pantalla todo
Console.WriteLine("Los numeros iniciales son: {0}, {1}, {2}, {3}, {4}", num1, num2, num3, num4, num5);
Console.WriteLine("El máximo es: " + max);
Console.WriteLine("El mínimo es: " + min);
Console.WriteLine("La suma final es: " + sumaFinal);

Console.ReadLine();
