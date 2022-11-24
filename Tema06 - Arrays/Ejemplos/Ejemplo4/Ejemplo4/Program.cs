//Ejemplo 4: Introducimos info para jugadores del Mundial.
//Queremos saber los siguientes datos:
// - Cantidad de jugadores (Tamaño de los arrays)
// - Para cada jugador: (Dentro del bucle)
//      - Nombres
//      - Nacionalidades
//      - Goles
//      - Asistencias

//Metemos la siguiente información: NOMBRE JUGADOR - NACIONALIDAD - GOLES - ASISTENCIAS

//Ejemplo de como debe aparecer: CRISTIANO - PORTUGUES - 999 - 2

int cantidadJugadores;

//Pedimos el tamaño de los arrays
Console.Write("Dime cuántos jugadores vas a guardar:");
cantidadJugadores = int.Parse(Console.ReadLine());

//Creamos los arrays
string[] nombres = new string[cantidadJugadores];
string[] nacionalidades = new string[cantidadJugadores];
int[] goles = new int[cantidadJugadores];
int[] asistencias = new int[cantidadJugadores];

//Pedimos los datos por pantalla
for (int i = 0; i < cantidadJugadores; i++)
{
    Console.Write("Nombre jugador: ");
    nombres[i] = Console.ReadLine();

    Console.Write("Nacionalidad jugador: ");
    nacionalidades[i] = Console.ReadLine();

    Console.Write("Goles jugador: ");
    goles[i] = int.Parse(Console.ReadLine());

    Console.Write("Asistencias jugador: ");
    asistencias[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
//Mostramos la información por pantalla
for (int i = 0; i < cantidadJugadores; i++)
{
    Console.WriteLine(nombres[i] + " " + nacionalidades[i] + " " + goles[i] + " " + asistencias[i]);
    Console.WriteLine();
}

Console.ReadLine();