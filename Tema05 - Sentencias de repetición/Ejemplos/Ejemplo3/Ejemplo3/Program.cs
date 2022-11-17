//Mostramos los números desde el 1 hasta el 20, pero nos saltamos el 13
bool estaAprobado = false;

for (int i = 1; i <= 20; i++)
{
    if (i == 13)
    {
        continue;
    }
    Console.WriteLine(i);
}

//Diferencia entre While y Do-While

while (estaAprobado == true)
{
    Console.WriteLine("ENTRA EN EL WHILE");
}

do
{
    Console.WriteLine("ENTRA EN EL DO-WHILE");
} while (estaAprobado == true);

Console.ReadLine();