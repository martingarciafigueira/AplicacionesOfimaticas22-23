//Ejemplos: Creamos una matriz de 5 alumnos
//Posteriormente, metemos un profesor, redimensionando la matriz

string[] alumnos = new string[] {"Aarón", "Rodrigo", "Rubén", "Leo", "David" };

foreach (string alumno in alumnos)
{
    Console.WriteLine(alumno);
}

Console.WriteLine();

//Metemos un profesor, por lo tanto, aumentamos la posición en 1
Array.Resize(ref alumnos, alumnos.Length + 1);

alumnos[alumnos.Length - 1] = "Martín";

foreach (string alumno in alumnos)
{
    Console.WriteLine(alumno);
}

Console.ReadLine();