/*
 * Ejemplo: Crea una aplicación en la que introduzcas 5 notas de un alumno y calcula su nota media, con bucle
 */

//Declaramos las variables
float nota, notaMedia, sumaNotas = 0;
int numeroNotas;

//Pedir la cantidad de notas a ingresar
Console.Write("¿Cuántas notas quieres meter?: ");
numeroNotas = int.Parse(Console.ReadLine());

for (int i = 0; i < numeroNotas; i++)
{
    //Pedir los datos al usuario
    Console.Write("Introduce tu nota:");
    nota = float.Parse(Console.ReadLine());
    sumaNotas += nota;
}

//Calcular la nota media
notaMedia = sumaNotas / numeroNotas;

//Mostrarla por pantalla
Console.WriteLine("Mi nota media es: " + notaMedia);

Console.ReadLine();