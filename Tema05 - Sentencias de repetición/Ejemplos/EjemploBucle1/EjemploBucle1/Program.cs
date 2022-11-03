//Pedimos n notas por pantalla y calculamos su promedio
int numeroNotas, iteracion = 0;
float nota, promedio, sumaNotas = 0, notaMenor, notaMayor;

//Pedimos el numero de notas que va a meter el usuario
Console.Write("Cuantas notas va a meter: ");
numeroNotas = int.Parse(Console.ReadLine());

while (iteracion < numeroNotas)
{
    Console.Write("Nota: ");
    nota = float.Parse(Console.ReadLine());
    iteracion = iteracion + 1;
    sumaNotas += nota;
}

promedio = sumaNotas / numeroNotas;

Console.WriteLine("El promedio de notas es: " + promedio);

Console.ReadKey();


