//Declaramos las variables
long dineroEnElBanco = 1000;

//Pedimos saber cuánto dinero tenemos en el banco

Console.WriteLine("¿Cuánta pasta tenemos en el banco?");
dineroEnElBanco = long.Parse(Console.ReadLine());

if (dineroEnElBanco == 0)
{
    Console.Write("No tengo nada en el banco");
}
else if (dineroEnElBanco < 0)
{
    Console.Write("No tengo nada, y debo pasta");
}
else if (dineroEnElBanco > 1000000000)
{
    Console.Write("Estoy forradisimo");
}
else
{
    Console.Write("Tengo poco dinero... o mucho. Quién sabe.");
}

//Comprobamos el dinero en el banco
switch (dineroEnElBanco)
{
    case >= 100000000:
        {
            Console.WriteLine("Acaso soy yo Messi?");
            break;
        }
    case < 100000000 and >= 100:
        {
            Console.WriteLine("Puedo tener mucho dinero... O no.");
            break;
        }
    case < 100:
        {
            Console.WriteLine("No me da ni para pipas");
            break;
        }
}

Console.ReadLine();
