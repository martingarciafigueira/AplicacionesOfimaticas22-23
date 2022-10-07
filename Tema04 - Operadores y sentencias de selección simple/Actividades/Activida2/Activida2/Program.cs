//Definimos las variables
byte edadHermano1, edadHermano2;

//Pedimos los datos por pantalla
Console.Write("¿Cuántos años tiene el primer hermano?: ");
edadHermano1 = byte.Parse(Console.ReadLine());

Console.Write("¿Cuántos años tiene el segundo hermano?: ");
edadHermano2 = byte.Parse(Console.ReadLine());

//Hacemos los cálculos
if (edadHermano1 > edadHermano2)
{
    Console.WriteLine("El hermano 1 es mayor");
}
else if (edadHermano1 == edadHermano2)
{
    Console.WriteLine("Los dos hermanos tienen la misma edad");
}
else
{
    Console.WriteLine("El hermano 2 es mayor");
}

Console.ReadLine();
