//Ejemplo 5: Creamos una matriz de nombres y otra de edades
//Queremos saber quién es el primero en la lista y quién es el mayor y el más joven

string[] nombres = new string[] { "Rodrigo", "Aarón", "Rubén", "Leo", "David", "Iago", "Adrián" };
int[] edades = new int[] { 18, 17, 18, 19, 18, 18, 20 };

//Mostramos el primero en la lista, por orden alfabético: Aarón
Array.Sort(nombres);
Console.WriteLine("El primero de la lista es: " + nombres[0]);

//Mostramos el más mayor de la lista: Adrián
Array.Reverse(edades);
Console.WriteLine("El mayor de la lista tiene " + edades[0]);

//Buscamos el nombre de David en la lista ordenada
Array.Sort(nombres);
Console.WriteLine("El nombre de David en la lista ordenada está en la posición " + Array.BinarySearch(nombres, "David"));

//Comparación del for con un foreach
//Mostramos todos los nombres con un FOR
Console.WriteLine("Todos los nombres");
for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine(nombres[i]);
}
Console.WriteLine();
//Mostramos todos los nombres con un FOREACH
foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}

Console.ReadLine();
