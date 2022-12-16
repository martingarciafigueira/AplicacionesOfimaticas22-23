int valor, resultadoFactorial = 1;
string valorString;

Console.Write("Introduce un valor: ");
valorString = Console.ReadLine();

if (int.TryParse(valorString, out valor))
{
    valor = int.Parse(valorString);
}

if (valor <= 0)
{
    valor = 1;

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nEl valor introducido no es válido y se ha cambiado por \" 1 \"");
    Console.ForegroundColor = ConsoleColor.White;
}
Console.Write("\nEl factorial de " + valor + " es: ");

while (true)
{
    Console.Write(valor);

    if (valor == 1)
    {
        break;
    }

    Console.Write("*");

    resultadoFactorial *= valor;
    valor--;
}

Console.Write(" = " + resultadoFactorial);

Console.ReadKey();