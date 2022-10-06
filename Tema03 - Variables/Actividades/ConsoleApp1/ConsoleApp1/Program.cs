
List<int> numeros = new List<int>();
string strNumeroIngresado = "";
int numeroConvertido;

Console.WriteLine("Ingresa X numeros por pantalla hasta que pulses la P");

//Recogemos los datos por pantalla

do
{
    strNumeroIngresado = Console.ReadLine();
    int.TryParse(strNumeroIngresado, out numeroConvertido);
    numeros.Add(numeroConvertido);
} while (strNumeroIngresado != "P");

//Calculamos el promedio

Console.WriteLine("El promedio es: " + numeros.Average());

Console.ReadLine();