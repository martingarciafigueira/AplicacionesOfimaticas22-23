//Declaramos las variables
int nota1, nota2, nota3, nota4, nota5, max, min;
float notaMedia;

//Pedimos las notas por teclado
Console.Write("Introduce la nota 1: ");
nota1 = int.Parse(Console.ReadLine());

Console.Write("Introduce la nota 2: ");
nota2 = int.Parse(Console.ReadLine());

Console.Write("Introduce la nota 3: ");
nota3 = int.Parse(Console.ReadLine());

Console.Write("Introduce la nota 4: ");
nota4 = int.Parse(Console.ReadLine());

Console.Write("Introduce la nota 5: ");
nota5 = int.Parse(Console.ReadLine());

//Hacemos los cálculos
//Calculamos la nota media
notaMedia = (nota1 + nota2 + nota3 + nota4 + nota5) / 5f;

//Calculamos la nota máxima
max = Math.Max(nota1, nota2);
max = Math.Max(max, nota3);
max = Math.Max(max, nota4);
max = Math.Max(max, nota5);

//Calculamos la nota mínima
min = Math.Min(nota1, nota2);
min = Math.Min(min, nota3);
min = Math.Min(min, nota4);
min = Math.Min(min, nota5);

//Mostramos las notas
Console.WriteLine();
Console.WriteLine("Mostramos todas las notas:");
Console.WriteLine("Nota 1: " + nota1);
Console.WriteLine("Nota 2: " + nota2);
Console.WriteLine("Nota 3: " + nota3);
Console.WriteLine("Nota 4: " + nota4);
Console.WriteLine("Nota 5: " + nota5);
Console.WriteLine();
Console.WriteLine("Mostramos la nota media:");
Console.WriteLine("Nota media: " + notaMedia);
Console.WriteLine();
Console.WriteLine("Mostramos la nota máxima:");
Console.WriteLine("Nota máxima: " + max);
Console.WriteLine();
Console.WriteLine("Mostramos la nota mínima:");
Console.WriteLine("Nota mínima: " + min);

Console.ReadLine();
