int nota1, nota2, nota3, nota4, nota5;
int min, max;

Console.WriteLine("Mete una nota");
nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Mete una nota");
nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Mete una nota");
nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("Mete una nota");
nota4 = int.Parse(Console.ReadLine());

Console.WriteLine("Mete una nota");
nota5 = int.Parse(Console.ReadLine());

//Calculo la nota minima

min = Math.Min(nota1, nota2);
min = Math.Min(min, nota3);
min = Math.Min(min, nota4);
min = Math.Min(min, nota5);

Console.WriteLine("El minimo es: " + min);

//Calculo la nota maxima

max = Math.Max(nota1, nota2);
max = Math.Max(max, nota3);
max = Math.Max(max, nota4);
max = Math.Max(max, nota5);

Console.WriteLine("El máximo es: " + max);

Console.ReadLine();
