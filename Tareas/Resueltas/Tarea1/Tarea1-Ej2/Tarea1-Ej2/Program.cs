//Declaramos las variables
string nombre, ciclo;

//Pedimos los datos por pantalla
Console.Write("Escribe tu nombre: ");
nombre = Console.ReadLine();
Console.Write("Escribe el ciclo que vas a cursar: ");
ciclo = Console.ReadLine();

//Mostramos la información por pantalla
Console.WriteLine("¡Hola, {0}! Bienvenido al curso de {1}", nombre, ciclo);
Console.ReadLine();