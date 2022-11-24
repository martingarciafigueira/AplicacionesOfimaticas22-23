//Ejemplo 3: Crea 3 matrices y guarda la info de los alumnos presenciales
//Queremos guardar la siguiente información: Nombre, Edad, Videojuego favorito
//Elige el tipo de dato que necesites

/*
 * 
 *  Nombres son: Aaron, Rodrigo, Ruben, Leo, David
    Edades: 18, 17, 18, 19, 18
    Videojuegos favs: Candy Crush, WOW, DB, COD, RUST
 * 
 * 
 */

//Ejemplo de lo que debe salir: Aarón, 18, Candy Crush

//Resolución:

//Creamos y rellenamos las 3 matrices
string[] nombres = new string[] { "Aarón", "Rodrigo", "Rubén", "Leo", "David", "Enrique", "Ramón" };
int[] edades = new int[] { 18, 17, 18, 19, 18, 29, 31 };
string[] videojuegos = new string[] { "Candy Crush", "WOW", "DB", "COD", "RUST", "NBA 2K14", "Farming Simulator" };

//Hacemos un bucle y las recorremos
for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine(nombres[i] + ", " + edades[i] + ", " + videojuegos[i]);
}

Console.ReadLine();
