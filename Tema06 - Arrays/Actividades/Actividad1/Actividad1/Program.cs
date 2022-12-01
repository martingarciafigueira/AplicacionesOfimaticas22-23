
double[] notasAlumnos = new double[] { 45, 8, 9, 4.6, 7, 6, 2.9, 10 };
double[] copiaNotas = new double[8];
bool sonIguales = true;

//Copiamos el array notasAlumnos en copiaNotas
for (int i = 0; i < notasAlumnos.Length; i++)
{
    copiaNotas[i] = notasAlumnos[i];
}

//Comparamos los dos arrays
for (int i = 0; i < notasAlumnos.Length; i++)
{
	if (notasAlumnos[i] != copiaNotas[i])
	{
		sonIguales = false;
		break;
	}
}
if (sonIguales == true)
{
	Console.WriteLine("Son matrices iguales");
}
else
{
    Console.WriteLine("Son matrices diferentes");
}

//Mostramos los dos por pantalla
for (int i = 0; i < notasAlumnos.Length; i++)
{
	Console.Write(notasAlumnos[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < copiaNotas.Length; i++)
{
    Console.Write(copiaNotas[i] + " ");
}

Console.ReadLine();