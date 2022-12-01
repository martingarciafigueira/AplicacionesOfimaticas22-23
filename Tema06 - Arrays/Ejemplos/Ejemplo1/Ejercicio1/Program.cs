//Ejemplo 1: Guardar los nombres de los alumnos en Meet y mostrarlos por pantalla

//Pasos a seguir
//1. Crear una matriz con todos los nombres
string[] nombresMeet = new string[6];

//2. Accedemos a cada una de las posiciones
nombresMeet[0] = "Alex";
nombresMeet[1] = "Angel";
nombresMeet[2] = "Dani";
nombresMeet[3] = "Jaime";
nombresMeet[4] = "Roberto";
nombresMeet[5] = "Sergio";

//3. Pintamos por pantalla todos los nombres
for (int i = 0; i <= 5; i++)
{
    Console.WriteLine(nombresMeet[i]);
}
Console.WriteLine();

//4. Cambio Angel por David
nombresMeet[1] = "David";

//5. Volvemos a pintar con el cambio
for (int i = 0; i <= 5; i++)
{
    Console.WriteLine(nombresMeet[i]);
}



Console.ReadLine();


