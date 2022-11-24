//Ejercicio 2

float numero, contadorDivisores = 0, sumadorDivisores = 0, mediaDivisores;

//Ejemplo: 10 -> Divisores: 1, 2, 5, 10

Console.Write("Introduce un número: ");
numero = int.Parse(Console.ReadLine());

//Bucle para calcular los divisores del numero
for (int i = 1; i <= numero; i++)
{
    //Calculamos si un número es divisor
    if (numero % i == 0)
    {
        contadorDivisores = contadorDivisores + 1;
        sumadorDivisores = sumadorDivisores + i;
    }
}

//Calculamos la media de divisores
mediaDivisores = sumadorDivisores / contadorDivisores;

Console.Write("La media de los divisores de " + numero + " es: " + mediaDivisores);

Console.ReadLine();