//Ejemplo 2: Vamos a crear dos matrices para profesores:
//nombres: Nombres de profesores
//apellidos: Apellidos de profesores

//1. Definimos las matrices
string[] nombres = new string[2] { "Enrique", "Martín" };
string[] apellidos = new string[2] { "Prieto Magán", "García Figueira" };

//2. Mostramos los nombres
for (int i = 0; i <= 1; i++)
{
    Console.WriteLine(nombres[i]);
}
Console.WriteLine();
//3. Mostramos los apellidos
for (int i = 0; i <= 1; i++)
{
    Console.WriteLine(apellidos[i]);
}
Console.WriteLine();
//4. Mostramos los nombres completos
for (int i = 0; i <= 1; i++)
{
    Console.WriteLine(nombres[i] + " " + apellidos[i]);
}

Console.ReadLine();