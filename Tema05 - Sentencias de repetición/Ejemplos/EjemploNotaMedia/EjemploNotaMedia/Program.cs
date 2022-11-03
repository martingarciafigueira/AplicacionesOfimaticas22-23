/*
 * Ejemplo: Crea una aplicación en la que introduzcas notas de un alumno hasta que su nota media sea mayor que 5.
 */

//Declaramos las variables
float nota, notaMedia = 0, sumaNotas = 0;
int numeroNotas = 0;
bool estaAprobado = false;

while (estaAprobado == false)
{
    //Pedimos los datos al usuario
    Console.Write("Mete una nota: ");
    nota = float.Parse(Console.ReadLine());

    //Guardamos la nota y actualizamos el número de notas
    sumaNotas = sumaNotas + nota;
    numeroNotas = numeroNotas + 1;

    //Calculamos la nota media
    notaMedia = sumaNotas / numeroNotas;

    //Mostrar la nota media
    Console.WriteLine("Su nota media es: " + notaMedia);

    //Calculamos si está aprobado o no
    if (notaMedia >= 5)
    {
        estaAprobado = true;
    }
}

//Mostramos el resultado final
if (estaAprobado)
{
    Console.WriteLine("APROBADO!");
}

Console.ReadLine();