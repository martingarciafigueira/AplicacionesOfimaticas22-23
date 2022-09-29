
/**
 * VAMOS A CREAR UN PROGRAMA PARA PODER REGISTRAR VUESTRA INFORMACIÓN DE CONTACTO:
 * 
 * - NOMBRE
 * - APELLIDOS
 * - EDAD
 * - DIRECCION
 * - GENERO
 */

//Declaramos las variables
string nombre;
string apellidos;
string direccion;
string genero;
int edad;

const string COLEGIO = "FP Montecastelo";

//Obtenemos la información (v1: Escribirla en codigo; v2: PEDIRLA POR PANTALLA)

/* v1: Version Very-Easy
nombre = "Nico";
apellidos = "Williams";
direccion = "Bilbao";
genero = "Hombre";
edad = 20; */

// v2: Version Total-Pro

Console.WriteLine("Dame tu nombre");
nombre = Console.ReadLine();

Console.WriteLine("Dame tus apellidos");
apellidos = Console.ReadLine();

Console.WriteLine("Dame tu direccion");
direccion = Console.ReadLine();

Console.WriteLine("Dame tu genero");
genero = Console.ReadLine();

Console.WriteLine("Dame tu edad");

edad = int.Parse(Console.ReadLine());

//La mostramos por pantalla

Console.WriteLine("Mi nombre es: " + nombre);
Console.WriteLine("Mi apellido es: " + apellidos);
Console.WriteLine("Mi direccion es: " + direccion);
Console.WriteLine("Mi genero es: " + genero);
Console.WriteLine("Mi centro de estudios es " + COLEGIO);
Console.WriteLine("Mi edad es: " + edad);

Console.ReadLine();